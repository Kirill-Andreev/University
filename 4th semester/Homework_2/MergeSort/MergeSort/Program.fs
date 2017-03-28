let split list =
    let rec aux l acc1 acc2 =
        match l with
            | [] -> (acc1, acc2)
            | [x] -> (x :: acc1, acc2)
            | x :: y :: tail ->
                aux tail (x :: acc1) (y :: acc2)
    aux list [] []

let merge list1 list2 = 
    let rec aux list1 list2 acc =
        match list1, list2 with
        | [], [] -> acc
        | [], head :: tail | head :: tail, [] -> aux [] tail (head :: acc)
        | head1 :: tail1, head2 :: tail2 ->
            if head1 < head2 then aux tail1 list2 (head1 :: acc)
            else aux list1 tail2 (head2 :: acc)
    List.rev (aux list1 list2 [])

let mergeSort list =
    let rec aux l acc=  
        match l with
        | [] -> acc
        | [x] -> (x :: acc)
        | l -> let (first, second) = split l
               merge <| aux first [] <| aux second []
    aux list []

let list = [1; 3; 2; 10; 5; 4; 92; 32; 13; 8]
let sortedList = mergeSort list
printf "result: %A" sortedList