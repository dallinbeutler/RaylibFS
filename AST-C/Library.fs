//namespace AST_C
module AST_C.Say
open FParsec.Pipes
open FParsec

let ws = spaces

let test p str =
  match run p str with
  | Success(result, _, _)   -> printfn "Success: %A" result
  | Failure(errorMsg, _, _) -> printfn "Failure: %s" errorMsg



let hello name =
   printfn "Hello %s" name
