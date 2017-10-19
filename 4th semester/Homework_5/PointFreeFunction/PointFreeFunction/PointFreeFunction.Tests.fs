module PointFreeFunction.Tests

open Program
open NUnit.Framework
open FsUnit

[<Test>]
    let ``standart test`` () =
        pointFreeFunction 5 [1; 2; 3; 4] |> should equal [5; 10; 15; 20]
        pointFreeFunction1 5 [1; 2; 3; 4] |> should equal [5; 10; 15; 20]
        pointFreeFunction2 5 [1; 2; 3; 4] |> should equal [5; 10; 15; 20]
        pointFreeFunction3 5 [1; 2; 3; 4] |> should equal [5; 10; 15; 20]
        pointFreeFunction4 5 [1; 2; 3; 4] |> should equal [5; 10; 15; 20]

[<Test>]
    let ``empty list test`` () =
        pointFreeFunction 5 [] |> should equal []
        pointFreeFunction1 5 [] |> should equal []
        pointFreeFunction2 5 [] |> should equal []
        pointFreeFunction3 5 [] |> should equal []
        pointFreeFunction4 5 [] |> should equal []

