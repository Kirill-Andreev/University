module BinTreeEnumerator.Tests

open Program
open NUnit.Framework
open FsUnit
//open System
open System.Collections
//open System.Collections.Generic

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

[<Test>]
let ``Enumerator test``() =
    let tree = BinaryTree()
    [2; 1; 6] |> List.iter tree.Add
    let enumerator = (tree :> IEnumerable).GetEnumerator ()
    enumerator.MoveNext () |> ignore
    enumerator.Current |> should equal 1
    enumerator.Current |> should equal 1

[<Test>]
    let ``Enumerator test1``() =
        let tree = BinaryTree()
        [2; 1; 6; 3; 9; 7; 8] |> List.iter tree.Add
        let enumerator = (tree :> IEnumerable).GetEnumerator ()
        enumerator.MoveNext () |> ignore
        enumerator.Current |> should equal 1
        enumerator.MoveNext () |> ignore
        enumerator.Current |> should equal 2
        enumerator.MoveNext () |> ignore
        enumerator.Current |> should equal 3
        enumerator.MoveNext () |> ignore
        enumerator.Current |> should equal 6
        enumerator.MoveNext () |> ignore
        enumerator.Current |> should equal 7
        enumerator.MoveNext () |> ignore
        enumerator.Current |> should equal 8
        enumerator.MoveNext () |> ignore
        enumerator.Current |> should equal 9
