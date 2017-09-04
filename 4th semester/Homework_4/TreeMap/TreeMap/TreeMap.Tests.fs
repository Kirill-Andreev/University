module TreeMap.Tests

open Program
open NUnit.Framework
open FsUnit

[<Test>]
    let ``standart test`` () =
        let testTree = 
                Tree(
                    3, 
                    Tree(2, Tip(4), Tip(5)), 
                    Tree(4, Tip(5), Tip(7))
                )
        let doubledTree =
                Tree(
                    6, 
                    Tree(4, Tip(8), Tip(10)), 
                    Tree(8, Tip(10), Tip(14))
                )
        treeMap testTree (fun x -> 2 * x) |> should equal doubledTree