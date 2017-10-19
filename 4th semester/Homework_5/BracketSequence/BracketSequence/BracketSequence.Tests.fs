module BracketSequence.Tests

open Program
open NUnit.Framework
open FsUnit

[<Test>]
    let ``correct bracket sequence test`` () =
        isCorrect <| Seq.toList "({[]})" |> should equal true

[<Test>]
    let ``incorrect bracket sequence test`` () =
        isCorrect <| Seq.toList "({])" |> should equal false

[<Test>]
    let ``empty bracket sequence test`` () =
        isCorrect <| Seq.toList "" |> should equal true

