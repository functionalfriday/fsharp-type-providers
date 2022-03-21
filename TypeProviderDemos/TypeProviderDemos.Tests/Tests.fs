module Tests

open Xunit
open TypeProviderDemos

[<Fact>]
let ``My test`` () =
    Assert.True(true)
    
[<Fact>]
let ``Can call other dll`` () =
    let result = Say.hello
    Assert.Equal("Hello World", result)