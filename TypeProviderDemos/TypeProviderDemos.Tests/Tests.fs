module Tests

open Swensen.Unquote
open Xunit
open TypeProviderDemos.Demo1

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
    
