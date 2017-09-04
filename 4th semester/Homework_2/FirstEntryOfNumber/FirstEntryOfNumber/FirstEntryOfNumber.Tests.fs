module FirstEntryOfNumber.Tests

open Program
open NUnit.Framework
open FsUnit

[<Test>]
    let ``standart test`` () =
        firstEntryOfNumber [1; 3; 5; 0; 4] 0 |> should equal 3

[<Test>]
    let ``repeating number test`` () =
        firstEntryOfNumber [1; 3; 0; 5; 4; 0] 0 |> should equal 2

[<Test>]
    let ``non-existent number test`` () =
         firstEntryOfNumber [1; 3; 0; 5; 4; 0] 9 |> should equal -1

[<Test>]
    let ``empty list test`` () =
         firstEntryOfNumber [] 0 |> should equal -1