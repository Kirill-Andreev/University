module MaxSum.Tests

open Program
open NUnit.Framework
open FsUnit

[<Test>]
    let ``standart test`` () =
        positionOfMaxSum [1; 5; 6; 2] |> should equal 2

[<Test>]
    let ``empty list test`` () =
        positionOfMaxSum [] |> should equal 0

[<Test>]
    let ``identical numbers list test`` () =
        positionOfMaxSum [1; 1; 1; 1] |> should equal 1

