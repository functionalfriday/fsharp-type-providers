module Tests

open Swensen.Unquote
open Xunit
open TypeProviderDemos

[<Fact>]
let ``My test`` () =
    true =! true
    
[<Fact>]
let ``Can call other dll`` () =
    let result = Say.hello
    result =! "Hello World"
