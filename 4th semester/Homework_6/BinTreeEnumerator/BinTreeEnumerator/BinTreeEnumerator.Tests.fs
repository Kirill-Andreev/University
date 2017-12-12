module BinTreeEnumerator.Tests

open Program
open NUnit.Framework
open FsUnit

[<Test>]
    let ``Add test``() =
        let tree = BinaryTree()
        [4; 1; 2; 7] |> List.iter tree.Add
        tree.Contains 4 |> should equal true
        tree.Contains 1 |> should equal true
        tree.Contains 2 |> should equal true
        tree.Contains 7 |> should equal true
        tree.Contains 8 |> should equal false

[<Test>]
    let ``Remove test``() =
        let tree = BinaryTree()
        [4; 1; 2; 7] |> List.iter tree.Add
        tree.Remove 4
        tree.Remove 3
        tree.Contains 1 |> should equal true
        tree.Contains 2 |> should equal true
        tree.Contains 4 |> should equal false
        tree.Contains 3 |> should equal false
        tree.Remove 1
        tree.Remove 2
        tree.Remove 4
        tree.Remove 7
        tree.IsEmpty |> should equal true

[<Test>]
let ``Another remove test``() =
    let tree = BinaryTree()
    [2; 1; 6; 3; 9; 7; 8] |> List.iter tree.Add
    tree.Remove 6
    tree.Contains 6 |> should equal false
    tree.Contains 3 |> should equal true
    tree.Contains 7 |> should equal true