module Program

open System
open System.Collections
open System.Collections.Generic

type TreeEnumerator<'a>(lst : list<'a>) =
    let fullList = if lst.IsEmpty then List.empty else lst.Head :: lst
    let mutable currentList = fullList
        
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
        member this.Reset() = currentList <- fullList
        member this.Dispose() = ()

type BinaryTree<'a when 'a : comparison> = 
    | BinaryTree of 'a * BinaryTree<'a> * BinaryTree<'a>
    | Tip of ('a option)
        with
            member this.Add value =
                match this with 
                | BinaryTree(node, left, right) -> if (value > node) then BinaryTree(node, left, right.Add value)
                                                   elif (value < node) then BinaryTree(node, left.Add value, right)
                                                   else BinaryTree(node, left, right)
                | Tip(node) -> match node with
                               | None -> Tip(Some(value))
                               | Some node -> if (value > node) then BinaryTree(node, Tip(None), Tip(Some(value)))
                                              elif (value < node) then BinaryTree(node, Tip(Some(value)), Tip(None))
                                              else BinaryTree(node, Tip(None), Tip(None))

            member this.IsEmpty =
                match this with
                | BinaryTree(_) -> false
                | Tip(node) -> match node with
                               | Some _ -> false
                               | None -> true 
            
            member this.Remove value =
                let mostLeftNode this =
                    let rec aux tree acc =
                        match tree with
                            | BinaryTree(node, left, right) -> if (node = aux left node)
                                                               then aux right node
                                                               else aux left node
                            | Tip(node) -> match node with
                                           | Some node -> node
                                           | None -> acc
                                                               
                    match this with
                    | BinaryTree(node, left, right) -> Some(aux this node)
                    | Tip(node) -> match node with
                                   | None -> None
                                   | Some value -> Some value
                                    
                match this with
                | BinaryTree(node, left, right) -> if (node < value) then BinaryTree(node, left, right.Remove value)
                                                   elif (node > value) then BinaryTree(node, left.Remove value, right)
                                                   else match mostLeftNode right with
                                                        | None -> left
                                                        | Some value -> BinaryTree(value, left, right.Remove value)   
                | Tip(node) -> match node with
                               | None -> Tip(None)
                               | Some value -> Tip(None)
            
            member this.Contains value =
                match this with
                | BinaryTree(node, left, right) -> if (value > node) then right.Contains value
                                                   elif (value < node) then left.Contains value
                                                   else true
                | Tip(node) -> match node with
                               | None -> false
                               | Some nodeVal -> (nodeVal = value)

            member private this.ConvertToList =
                let rec aux binTree acc =
                    match binTree with
                        | BinaryTree(value, left, right) -> let rightList = aux right List.Empty
                                                            aux left ((value :: rightList) @ acc)            
                        | Tip(node) -> match node with
                                           | None -> acc
                                           | Some value -> value :: acc
                this |> aux <| List.empty

            interface IEnumerable<'a> with
                member this.GetEnumerator() =
                    (new TreeEnumerator<'a>(this.ConvertToList) :> IEnumerator<'a>)
                member this.GetEnumerator() =
                    (new TreeEnumerator<'a>(this.ConvertToList) :> IEnumerator)

let mutable binaryTree = BinaryTree.Tip(Some(3))
binaryTree <- binaryTree.Add 4
binaryTree <- binaryTree.Add 1
binaryTree <- binaryTree.Add 2
binaryTree <- binaryTree.Add 7
for n in binaryTree do 
    printf "%A " n
