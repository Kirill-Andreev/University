module MergeSort.Tests

open Program
open NUnit.Framework
open FsUnit

[<Test>]
    let ``merge sort test`` () =
        mergeSort [1; 3; 2; 10; 5; 4;] |> should equal [1; 2; 3; 4; 5; 10]

[<Test>]
    let ``split test`` () =
        split [1; 3; 2; 10; 5; 4] |> should equal ([5; 2; 1], [4; 10; 3])

[<Test>]
    let ``empty list test`` () =
        mergeSort [] |> should equal []

[<Test>]
    let ``single-element list test`` () =
        mergeSort [1] |> should equal [1]