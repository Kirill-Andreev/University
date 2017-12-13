﻿module Program

open System
open System.Collections
open System.Collections.Generic

type Tree<'a> =
    | Empty
    | Tip of 'a
    | Tree of 'a * Tree<'a> * Tree<'a>
    
type TreeEnumerator<'a when 'a : comparison>(tree : Tree<'a>) =
    let rec treeToList tree =
       match tree with
        | Empty -> []
        | Tip(value) -> [value] 
        | Tree(value, left, right) ->  value :: treeToList left @ treeToList right

    let mutable currentList = treeToList tree
    
    interface IEnumerator<'a> with
        member this.Current
            with get() = currentList.Head :> obj
        member this.Current
            with get() = currentList.Head
        member this.MoveNext() =
            match currentList with
                | h :: t -> currentList <- t
                            not t.IsEmpty
                | [] -> false
        member this.Reset() = currentList <- (treeToList tree)
        member this.Dispose() = ()    

type BinaryTree<'a when 'a : comparison>() = 
    let mutable tree : Tree<'a> = Empty
    member this.Add value =
        let rec aux value node =
            match node with 
            | Tree(node, left, right) -> if (value > node) then Tree(node, left, aux value right)
                                         elif (value < node) then Tree(node, aux value left, right)
                                         else Tree(node, left, right)
            | Tip(node) -> if (value > node) then Tree(node, Empty, Tip(value))
                           elif (value < node) then Tree(node, Tip(value), Empty)
                           else Tree(node, Empty, Empty)
            | Empty -> Tip(value)
        tree <- aux value tree

    member this.IsEmpty =
        let rec aux node =
            match node with
            | Tree(_) -> false
            | Tip(_) -> false 
            | Empty -> true
        aux tree

    member this.Remove value =
        let rec mostLeftNode tree =
            match tree with
            | Empty -> Empty
            | Tip(node) -> Tip(node)
            | Tree(node, left, right) -> match left with
                                         | Empty -> tree
                                         | _ -> mostLeftNode left

        let rec aux value node =                            
            match node with
            | Empty -> Empty
            | Tip(node) -> if (node = value) then Empty
                           else failwith "Contains method error"
            | Tree(node, left, right) when (node < value) -> Tree(node, left, aux value right)
            | Tree(node, left, right) when (node > value) -> Tree(node, aux value left, right)
            | Tree(node, left, right) ->  match left with
                                              | Empty -> right
                                              | _ -> match right with
                                                     | Empty -> left
                                                     | Tip(a) -> Tree(a, left, Empty)
                                                     | Tree(node1, left1, right1) -> match left1 with
                                                                                     | Empty -> Tree(node1, left, right1)
                                                                                     | _ -> let temp = mostLeftNode right
                                                                                            match temp with
                                                                                            | Tree(node2, left3, right3) -> Tree(node2, left, aux node2 right)
                                                                                            | _ -> Empty
            
        if (this.Contains value) then tree <- aux value tree
        else printfn "this value does not exist in tree"

    member this.Contains value =
        let rec aux value node =
            match node with
            | Tree(node, left, right) -> if (value > node) then aux value right
                                             elif (value < node) then aux value left
                                             else true
            | Tip(node) -> (value = node)
            | Empty -> false
        aux value tree

    interface IEnumerable<'a> with
        member this.GetEnumerator() =
            new TreeEnumerator<'a>(tree) :> IEnumerator<'a>
        member this.GetEnumerator() =
           new TreeEnumerator<'a>(tree) :> IEnumerator

let binaryTree = new BinaryTree<int>()
binaryTree.Add 4
binaryTree.Add 1
binaryTree.Add 2
binaryTree.Add 7
for n in binaryTree do 
    printf "%A " n