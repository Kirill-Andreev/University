let pointFreeFunction : int -> int list -> int list  = 
   List.map << (*)

printf("Result: %A \n") <| pointFreeFunction 5 [1 .. 10]
