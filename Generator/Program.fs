// Learn more about F# at http://fsharp.org

open System
open CppAst
open System.IO
open System.Collections.Generic
open System.Text
open System.Runtime.InteropServices

let dir = Directory.EnumerateFiles(@"C:\IAS_Projects\Cloned\raylib\src")
let headers = 
  dir 
  |> Seq.filter(fun str -> str.EndsWith(".h"))
  |> List<string> 

let p  = CppParserOptions ()
p.ParseMacros<-true
p.ParseAsCpp<-false
//p.AutoSquashTypedef<-false
p.TargetSystem<- "_WIN32"

//WHY U NO WORK?
//let parsed = CppParser.ParseFiles(headers,p)
let parsed = CppParser.ParseFile(@"..\..\..\..\raylib\src\raylib.h")
//let poo = parsed.Classes |> Seq.head

let sanitizedTypeName (intype:CppType) = 
  let tname = intype.GetDisplayName()
  let tname = if tname.EndsWith '*' then tname.Replace("*","[]") else tname

  match tname with
  |"const char[]"->"string"
  |x when x.StartsWith "unsigned char"->"byte"
  |x when x.StartsWith "unsigned int"->"uint32"
  |x when x.StartsWith "unsigned short"->"uint16"
  |"void[]"->"IntPtr"
  |_-> tname  

let sanitizeVarName (str:string)=
  if (str.Length <= 1) then str
  else (str.[..0].ToUpper() + str.[1..])
  
type Scope(sb:StringBuilder)=
  member this.Write (str:string) = 
     (sb.Append('\t')).AppendLine(str) |>ignore
  interface IDisposable with
    member this.Dispose(): unit = 
      ()

let printEnum (sb:StringBuilder) (enum:CppEnum)=
  sb.AppendLine (sprintf "type %O =" enum.Name)|>ignore
  String.Join('\n', enum.Items |> Seq.map (fun x -> sprintf "|%O = %O" x.Name x.Value))
  |> sb.AppendLine  

let printStruct (sb:StringBuilder) (struc: CppClass ) =
  sb.AppendLine("[<StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)>]")|>ignore
  sb.AppendLine(sprintf "type %O =" (struc.GetDisplayName()))|>ignore
  sb.AppendLine(sprintf"  struct")|>ignore
  struc.Fields|>Seq.iter(fun field -> sb.AppendLine (sprintf "    val %O: %O" (sanitizeVarName field.Name) (sanitizedTypeName field.Type))|>ignore)
  sb.AppendLine(sprintf "  end")

let printfunc (sb:StringBuilder) (assembly:string) (func:CppFunction ) =

  let printWeirdParams=      
    func.Parameters
    |> Seq.map (fun x->
      sanitizedTypeName x.Type + " " + x.Name 
      )

  let printTupled = "(" + String.Join (", ", printWeirdParams) + ")"

  sb.AppendLine(sprintf "[<DllImport(%O, CallingConvention = CallingConvention.Cdecl)>]" assembly)|>ignore
  sb.AppendLine(sprintf "extern %O %O %O" (sanitizedTypeName func.ReturnType) func.Name printTupled)|>ignore
  if func.Parameters.Count > 1
  then
    let printParams=  
      func.Parameters
      |> Seq.map (fun x-> x.Name + " : " + sanitizedTypeName x.Type)
    let printSeparate = String.Join (" ",printParams|> Seq.map(fun s -> sprintf "(%O)" s))
    let paramsNoType =
      String.Join( ", ",
        func.Parameters |> Seq.map (fun x-> x.Name)
      )
    sb.AppendLine(sprintf "let nice%O %O = %O(%O)" func.Name printSeparate func.Name paramsNoType)|>ignore

  sb

let printFuncs ass sb =   
  parsed.Functions 
  |>Seq.fold(fun builder x -> printfunc builder ass x ) sb
 

//[<StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)>]
let printEnums sb = 
  parsed.Enums
  |>Seq.fold(fun builder x -> printEnum builder x ) sb

let printStructs sb =
  parsed.Classes
  |>Seq.fold(fun builder x -> printStruct builder x) sb



[<EntryPoint>]
let main argv =
    let sb = StringBuilder()
    sb.AppendLine "module Raylib"|>ignore
    sb.AppendLine "open System"|>ignore
    sb.AppendLine "open System.Runtime.InteropServices"|>ignore
    
    sb.AppendLine() |> ignore    
    sb.AppendLine(@"//Enums") |> ignore
    printEnums sb |> ignore
    sb.AppendLine() |> ignore
    sb.AppendLine(@"//Structs") |> ignore
    printStructs sb |>ignore
    sb.AppendLine() |> ignore
    sb.AppendLine(@"//Functions") |> ignore
    printFuncs "\"Ass here\"" sb |> ignore    
    File.WriteAllText (@"..\..\..\..\Bindings\raylib.fs", sb.ToString())
    Console.WriteLine("====================")
    printfn"Ignored:"
    parsed.Typedefs |> Seq.iter(fun x -> printfn "%O->%O" (x.ElementType.GetDisplayName())  x.Name)
    0 // return an integer exit code
