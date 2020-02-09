module Tests

open System
open Xunit

[<Fact>]
let ``My test`` () =
    Assert.True(true)

[<Fact>]
let ``convertNumber returns Fizz if number is divisible by 3`` () =
    Assert.True("Fizz" = Program.convertNumber 3)
