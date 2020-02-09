// Learn more about F# at http://fsharp.org

open System


let convertNumber n =
  match n with
  | 1 -> "1"
  | _ -> "Fizz"


[<EntryPoint>]
let main argv =
  printfn "Hello World from F#!"
  0 // return an integer exit code
