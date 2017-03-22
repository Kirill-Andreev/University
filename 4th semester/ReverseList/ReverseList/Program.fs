let reverseList list = 
     let rec reverse list acc =
        match list with
        | head :: tail -> reverse tail (head :: acc)
        | [] -> acc
     reverse list []

let list = [1; 2; 3; 4; 5]
printf "reverse list: %A" <| reverseList list