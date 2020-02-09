module Tests
open Xunit
open Swensen.Unquote
open FsCheck
open FsCheck.Xunit

[<Property>]
let ``convertNumber returns the number if not divisible by 3 or 5`` (n:int) =
    (n % 3 > 0 && n % 5 > 0) ==> lazy
        (string n) =! Program.convertNumber n

[<Property>]
let ``convertNumber returns 'Fizz' if number is divisible by 3`` (n:PositiveInt) =
    (n.Get % 3 = 0 && n.Get % 5 > 0) ==> lazy
        "Fizz" =! Program.convertNumber n.Get

[<Property>]
let ``convertNumber returns 'Buzz' if number is divisible by 5`` (n:PositiveInt) =
    (n.Get % 5 = 0 && n.Get % 3 > 0) ==> lazy
        "Buzz" =! Program.convertNumber n.Get

let makeDivisable n x =
    match x % n with
    | 0 -> x
    | _ -> x * n

[<Property>]
let ``convertNumber returns 'FizzBuzz' if number is divisible by 3 and 5`` () =
    let correct (PositiveInt x) =
        x |> makeDivisable 3 |> makeDivisable 5
    Arb.generate<PositiveInt>
    |> Gen.map correct
    |> Arb.fromGen
    |> Prop.forAll <| fun x ->
        "FizzBuzz" =! Program.convertNumber x
    
[<Property>]
let ``generate returns list of specified size`` (size:NonNegativeInt) =
    size.Get =! (Program.generate size.Get |> List.length)

[<Fact>]
let ``output joins list with spaces`` () =
    "hallo welt" =! Program.output ["hallo"; "welt"]

