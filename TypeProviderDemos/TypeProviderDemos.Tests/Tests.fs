module Tests

open Swensen.Unquote
open Xunit
open TypeProviderDemos
open TypeProviderDemos.Demo1
open TypeProviderDemos.Demo1

[<Fact>]
let ``My test`` () =
    true =! true
    
[<Fact>]
let ``Can call other dll`` () =
    let result = Say.hello
    result =! "Hello World"

[<Fact>]
let ``simple json works`` () =

    let bart =
        """
{
firstname: "Bart",
lastname: "Simpson",
age: 10
}
"""
    let actual = json2type bart
    actual =! { Name = "Bart Simpson"; Age = 10 }
    
