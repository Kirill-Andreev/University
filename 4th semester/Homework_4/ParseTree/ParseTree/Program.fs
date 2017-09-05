module Program

type Operation =
    | Add
    | Sub
    | Mult
    | Div

type ParseTree =
    | Node of Operation * ParseTree * ParseTree
    | Tip of int

let rec parse tree =
    match tree with
    | Tip tip -> tip
    | Node (operation, left, right) ->
        match operation with
        | Add -> parse left + parse right
        | Sub -> parse left - parse right
        | Mult -> parse left * parse right
        | Div -> parse left / parse right

let testTree = 
     Node(
         Mult, 
         Node(Add, Tip(4), Tip(5)),
         Node(Sub, Tip(5), Tip(7))
     )

printf "%d" <| parse testTree