module ReverseList.Tests

open Program
open NUnit.Framework
open FsUnit

[<Test>]
    let ``reverse list test`` () = 
        reverseList [1; 2; 3; 4; 5] |> should equal [5; 4; 3; 2; 1]

[<Test>]
    let ``empty list test`` () =
        reverseList [] |> should equal []

[<Test>]
    let ``one element list test`` () =
        reverseList [1] |> should equal [1]