open System
open System.Collections.Generic

exception EmptyStack of string

type Stack<'a>() = 
    let list = new List<'a>()

    member stack.IsEmpty() = 
        list.Count = 0

    member stack.Push(value) = 
        list.Add(value)

    member stack.Pop() = 
        if (stack.IsEmpty()) then
           raise (EmptyStack("Stack is empty!"))
        let value = list.Item (list.Count - 1)
        list.RemoveAt (list.Count - 1)
        value

    member stack.Print() =
        if (stack.IsEmpty()) then
           raise (EmptyStack("Stack is empty!"))
        for i = 1 to list.Count do
            printf "%A; " list.[list.Count - i]
        printf "\n"

let stack = new Stack<int>()
for i = 1 to 10 do
    stack.Push(i)
stack.Print()

try
    for i = 1 to 11 do
        printf "Pop: %A\n" <| stack.Pop()
with
    | EmptyStack(msg) -> printf "%A\n" msg

printf "Is stack empty? %b\n" <| stack.IsEmpty()