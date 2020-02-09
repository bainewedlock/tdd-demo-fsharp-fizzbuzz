let convertNumber n =
  match n with
  | n when n % 3 = 0 && n % 5 = 0 -> "FizzBuzz"
  | n when n % 3 = 0 -> "Fizz"
  | n when n % 5 = 0 -> "Buzz"
  | _ -> string n

let generate size =
  [1..size]
  |> List.map convertNumber

let output xs = String.concat " " xs

[<EntryPoint>]
let main argv =
  generate 100 |> output |> printfn "%s"
  0 // return an integer exit code
