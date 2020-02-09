module Tests

open System
open Xunit

[<Fact>]
let ``My test`` () =
    Assert.True(true)

[<Fact>]
let ``well lets hope this is actually`` () =
    Assert.True(2 = 2)
