let powerOfTwo x n = 
    [x .. x + n] |> List.map(fun t -> pown 2 t)

let list = powerOfTwo 1 8   
printf "result: %A " list
