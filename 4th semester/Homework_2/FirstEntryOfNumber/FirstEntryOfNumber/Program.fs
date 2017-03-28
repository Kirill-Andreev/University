let firstEntryOfNumber list number = 
    let rec firstEntry list number position = 
        match list with 
        | [] -> -1
        | head :: tail -> 
            if (number = head) then position
            else firstEntry tail number (position + 1)
    firstEntry list number 0

let list = [1 .. 10]
printf "First entry of number 6: %d" <| firstEntryOfNumber list 6