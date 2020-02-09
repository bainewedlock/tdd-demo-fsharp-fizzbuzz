// Learn more about F# at http://fsharp.org


let convertNumber n =
  match n with
  | n when n % 3 = 0 && n % 5 = 0 -> "FizzBuzz"
  | n when n % 3 = 0 -> "Fizz"
  | n when n % 5 = 0 -> "Buzz"
  | _ -> string n


[<EntryPoint>]
let main argv =
  printfn "Hello World from F#!"
  0 // return an integer exit code
