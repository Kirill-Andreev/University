module IsUniqueElementInList.Tests

open Program
open NUnit.Framework
open FsUnit

[<Test>]
    let ``unique list test`` () =
        isUnique [1 .. 10] |> should equal true

[<Test>]
    let ``non-unique list test`` () =
        isUnique [1; 1; 3] |> should equal false

[<Test>]
    let ``empty list test`` () =
        isUnique [] |> should equal true