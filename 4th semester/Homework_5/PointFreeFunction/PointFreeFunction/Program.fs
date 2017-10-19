module Program

let pointFreeFunction x list = List.map (fun a -> a * x) list

let pointFreeFunction1 x : int list -> int list =
    List.map (fun a -> a * x) 

let pointFreeFunction2 x : int list -> int list =
    List.map (fun a -> (*) x a)

let pointFreeFunction3 x : int list -> int list  =
    List.map ((*) x)

let pointFreeFunction4 : int -> int list -> int list  = 
   List.map << (*)

printf("Result: %A \n") <| pointFreeFunction 5 [1 .. 10]
