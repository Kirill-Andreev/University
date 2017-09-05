module PointFreeFunction.Tests

open Program
open NUnit.Framework
open FsUnit

[<Test>]
    let ``standart test`` () =
        pointFreeFunction 5 [1; 2; 3; 4] |> should equal [5; 10; 15; 20]

[<Test>]
    let ``empty list test`` () =
        pointFreeFunction 5 [] |> should equal []

