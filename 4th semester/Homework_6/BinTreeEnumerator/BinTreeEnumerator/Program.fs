module Program

open System
open System.Collections
open System.Collections.Generic

type Tree<'a> =
    | Tree of 'a * Tree<'a> * Tree<'a>
    | Tip of 'a
    | Empty

type TreeEnumerator<'a when 'a : comparison>(tree : Tree<'a>) =
    let rec treeToList tree =
       match tree with
        | Empty -> []
        | Tip value -> [value] 
        | Tree(value, left, right) ->  value :: treeToList left @ treeToList right

    let currentList = ref (treeToList tree)
        
    interface IEnumerator with
        member this.get_Current() =
            let current = (!currentList).Head :> obj 
            currentList := (!currentList).Tail
            current
        member this.MoveNext() =
            match !currentList with
                | h :: t -> true
                | [] -> false
        member this.Reset() = currentList := (treeToList tree)

    interface IEnumerator<'a> with
       member v.get_Current() = (!currentList).Head
       member v.Dispose () = ()

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
            | Tip(node) -> false 
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
            | Tree(node, left, right) -> if (node < value) then Tree(node, left, aux value right)
                                         elif (node > value) then Tree(node, aux value left, right)
                                         else match left with
                                              | Empty -> Empty
                                              | _ -> match right with
                                                     | Empty -> left
                                                     | _ -> let temp = mostLeftNode right
                                                            match temp with
                                                            | Tip(node) -> Tree(node, left, aux value right)
                                                            | _ -> Empty
            | Tip(node) -> if (node = value) then Empty
                           else printfn "this value does not exist in tree"
                                tree
            | Empty -> Empty
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

    interface IEnumerable with
        member t.GetEnumerator() = new TreeEnumerator<'a>(tree) :> IEnumerator

let binaryTree = new BinaryTree<int>()
binaryTree.Add 4
binaryTree.Add 1
binaryTree.Add 2
binaryTree.Add 7
for n in binaryTree do 
    printf "%A " n
