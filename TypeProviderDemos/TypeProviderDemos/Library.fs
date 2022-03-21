namespace TypeProviderDemos

open FSharp.Data.JsonProvider

module Demo1 =
    // target type
    type Person = { Name: string; Age: int }
    
    // input type
    type Simpsons = JsonProvider<"simpsons.json">
    
    let json2type json =
        let simpson = Simpsons.Parse json
        let result =
            {
                Name = simpson.Firstname + " " + simpson.Lastname
                Age = simpson.Age
            }
        result