let positionOfMaxSum list =
    let tupleList = List.zip (0 :: list) (list @ [0]) 
    let listSumTuple = List.map (fun (x, y) -> x + y) tupleList
    let listMax = List.max listSumTuple

    List.findIndex ( (=) listMax ) listSumTuple

printfn "Position: %d \n" <| positionOfMaxSum [1; 5; 6; 2] 
