﻿module BinTreeEnumerator.Tests

open Program
open NUnit.Framework
open FsUnit

[<Test>]
    let ``add test``() =
        binaryTree.Contains 4 |> should equal true
        binaryTree.Contains 1 |> should equal true
        binaryTree.Contains 2 |> should equal true
        binaryTree.Contains 7 |> should equal true
        binaryTree.Contains 8 |> should equal false

[<Test>]
    let ``remove test``() =
        binaryTree <- binaryTree.Remove 4
        binaryTree <- binaryTree.Remove 3
        binaryTree.Contains 1 |> should equal true
        binaryTree.Contains 2 |> should equal true
        binaryTree.Contains 4 |> should equal false
        binaryTree.Contains 3 |> should equal false
        binaryTree <- binaryTree.Remove 1
        binaryTree <- binaryTree.Remove 2
        binaryTree <- binaryTree.Remove 4
        binaryTree <- binaryTree.Remove 7
        binaryTree.IsEmpty |> should equal true