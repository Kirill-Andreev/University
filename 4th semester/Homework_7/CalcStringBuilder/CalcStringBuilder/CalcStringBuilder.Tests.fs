module CalcStringBuilder.Tests

open Program
open NUnit.Framework
open FsUnit

[<Test>]
let ``Addition of two numbers`` () = 
    let result = 
        stringExpr {
            let! x = "1"
            let! y = "2"
            let z = x + y
            return z
        }
    result |> should equal <| Some 3.0

[<Test>]
let ``Addition of number and not a number`` () = 
    let result = 
        stringExpr {
            let! x = "1"
            let! y = "f"
            let z = x + y
            return z
        }
    result |> should equal <| null


