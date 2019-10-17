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
//p.ParseMacros<-true
//p.ParseAsCpp<-false
//p.AutoSquashTypedef<-false
//p.TargetSystem<- "_WIN32"

//WHY U NO WORK?
//let parsed = CppParser.ParseFiles(headers,p)
let parsed = CppParser.ParseFile(@"..\..\..\..\raylib\src\raylib.h" , p)
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
  |"void (*)"->"IntPtr"// not sure if right?
  |"float[4]"->"Vector4"
  |"char[32]"->"string" //Going to need  [<FixedBuffer(typeof<char>, 0x80)>] as attribute...
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
  if String.IsNullOrWhiteSpace(enum.GetDisplayName()) 
  then sb
  else
    sb.AppendLine (sprintf "and %O =" (enum.GetDisplayName()))|>ignore
    String.Join('\n', enum.Items |> Seq.map (fun x -> sprintf "|%O = %O" x.Name x.Value))
    |> sb.AppendLine      

//let printTypeDef (sb:StringBuilder) (td:CppTypedef)  = 
//  //if (td.ElementType.GetDisplayName()) = td.Name |> not
//  //then 
//    sprintf "type %O = %O" (td.ElementType.GetDisplayName())  td.Name       
//       |> sb.AppendLine
//  //else printStructDef sb td

let printStruct (sb:StringBuilder) (struc: CppClass ) =
  //sb.AppendLine("[<StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)>]")|>ignore
  sb.AppendLine(sprintf "and %O =" (struc.GetDisplayName()))|>ignore
  sb.AppendLine(sprintf"  struct")|>ignore
  struc.Fields|>Seq.iter(fun field -> sb.AppendLine (sprintf "    val %O: %O" (sanitizeVarName field.Name) (sanitizedTypeName field.Type))|>ignore)
  sb.AppendLine(sprintf "  end")
  //struc.Typedefs |> Seq.fold printTypeDef sb

let sanitizeFieldName str =
  match str with
  |"rec"->"rect"
  |_->str
let printFunc (sb:StringBuilder) (assembly:string) (func:CppFunction ) =

  let printWeirdParams=      
    func.Parameters
    |> Seq.map (fun x->
      sanitizedTypeName x.Type + " " + sanitizeFieldName x.Name 
      )

  let printTupled = "(" + String.Join (", ", printWeirdParams) + ")"

  sb.AppendLine(sprintf "[<DllImport(%O, CallingConvention = CallingConvention.Cdecl)>]" assembly)|>ignore
  sb.AppendLine(sprintf "extern %O %O %O" (sanitizedTypeName func.ReturnType) func.Name printTupled)|>ignore
  if func.Parameters.Count > 1
  then
    let printParams=  
      func.Parameters
      |> Seq.map (fun x->sanitizeFieldName x.Name + " : " + sanitizedTypeName x.Type)
    let printSeparate = String.Join (" ",printParams|> Seq.map(fun s -> sprintf "(%O)" s))
    let paramsNoType =
      String.Join( ", ",
        func.Parameters |> Seq.map (fun x->sanitizeFieldName x.Name)
      )
    sb.AppendLine(sprintf "let nice%O %O = %O(%O)" func.Name printSeparate func.Name paramsNoType)|>ignore

  sb

let parsed2 = CppParser.ParseFile(@"..\..\..\..\raylib\src\raylib.h")

  

//let printFuncs ass sb =   
//  parsed.Functions 
//  |>Seq.fold(fun builder x -> printfunc builder ass x ) sb
 
//[<StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)>]
//let printEnums sb = 
//  parsed.Enums
//  |>Seq.fold(fun builder x -> printEnum builder x ) sb

//let printStructs sb =
//  parsed.Classes
//  |>Seq.fold(fun builder x -> printStruct builder x) sb

//let printTypeDefs sb = 
//  parsed.Typedefs
//  |>Seq.fold(fun builder x -> printTypeDef builder x) sb
let printTypeDef (sb:StringBuilder) (td:CppTypedef) =
  sprintf "and %O = %O"   td.Name       (td.ElementType.GetDisplayName())
  |> sb.AppendLine

let rec handleCppDecl (sb:StringBuilder) (decl:ICppElement) =
  match decl with
  | :? CppEnum as enum -> printEnum sb enum
  | :? CppFunction as func -> printFunc sb "\"Assembly name here\"" func
  | :? CppClass as struc -> printStruct sb struc
  | :? CppTypedef as tdef -> fixTypeDef sb tdef
  |_ -> sb.AppendLine(sprintf "//not added: %O" decl)

and fixTypeDef (sb:StringBuilder) (td:CppTypedef)  = 
  if (td.ElementType.GetDisplayName()) = td.Name |> not 
      && (String.IsNullOrWhiteSpace(td.ElementType.GetDisplayName())|> not)
  then
    printTypeDef sb td
  else 
    (parsed2.FindByName (td.GetDisplayName()) ) |> handleCppDecl sb


let parseChildren sb =
  parsed.Children()
  |> Seq.fold handleCppDecl sb

[<EntryPoint>]
let main argv =
    let sb = StringBuilder()
    sb.AppendLine "module Raylib"|>ignore
    sb.AppendLine "open System"|>ignore
    sb.AppendLine "open System.Runtime.InteropServices"|>ignore    
    
    parseChildren sb |> ignore

    File.WriteAllText (@"..\..\..\..\Bindings\raylib.fs", sb.ToString())
    Console.WriteLine("====================")
    printfn"Ignored:"
    
    0 // return an integer exit code
