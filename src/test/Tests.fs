module Tests

open System
open Xunit
open Swensen.Unquote

[<Fact>]
let ``My test`` () =
    Assert.True(true)

[<Fact>]
let ``convertNumber returns the number if not divisible by 3 or 5`` () =
    "1" =! Program.convertNumber 1

[<Fact>]
let ``convertNumber returns Fizz if number is divisible by 3`` () =
    "Fizz" =! Program.convertNumber 3
