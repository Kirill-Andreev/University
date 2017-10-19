module ParseTree.Tests

open Program
open NUnit.Framework
open FsUnit

[<Test>]
    let ``(4 + 5) * (5 - 7) test`` () =
        let testTree = 
            Node(
             Mult, 
             Node(Add, Tip(4), Tip(5)),
             Node(Sub, Tip(5), Tip(7))
            )
        parse testTree |> should equal -18

[<Test>]
    let ``(1 + 7) / (7 - 5) test`` () =
        let testTree = 
            Node(
             Div, 
             Node(Add, Tip(1), Tip(7)),
             Node(Sub, Tip(7), Tip(5))
            )
        parse testTree |> should equal 4

