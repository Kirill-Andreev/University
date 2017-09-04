module Program

type BinaryTree<'a> = 
    | Tree of 'a * BinaryTree<'a> * BinaryTree<'a>
    | Tip of 'a

let rec treeMap tree func =
    match tree with 
    | Tree(x, left, right) -> Tree(func x, treeMap left func, treeMap right func)
    | Tip x -> Tip(func x) 

let testTree = 
    Tree(
        3, 
        Tree(2, Tip(4), Tip(5)),
        Tree(4, Tip(5), Tip(7))
    )

printfn "%A" <| treeMap testTree (fun x -> 2 * x)
