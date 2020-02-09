module Tests

open System
open Xunit
open Swensen.Unquote
open FsCheck
open FsCheck.Xunit


[<Fact>]
let ``My test`` () =
    Assert.True(true)

[<Fact>]
let ``convertNumber returns the number if not divisible by 3 or 5`` () =
    "1" =! Program.convertNumber 1

[<Fact>]
let ``convertNumber returns Fizz if number is divisible by 3`` () =
    "Fizz" =! Program.convertNumber 3

[<Fact>]
let fstest_demo_1 () =
    let revRevIsOrig (xs:list<int>) = List.rev(List.rev xs) = xs
    Check.Quick revRevIsOrig

[<Property>]
let fstest_demo_2 (xs:list<int>) =
    List.rev(List.rev xs) = xs
