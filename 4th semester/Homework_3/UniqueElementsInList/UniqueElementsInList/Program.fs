module Program

let isUnique list = 
    let filteredList = List.distinct list
    List.length list = List.length filteredList

isUnique [1 .. 10] |> printfn "%A"
isUnique [1; 1; 3] |> printfn "%A"
