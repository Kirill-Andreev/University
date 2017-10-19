module Program

let amountOfEven list = 
   let evenList = List.filter (fun x -> x % 2 = 0) list
   List.length evenList

let result1 = amountOfEven [1; 2; 3; 4; 5]

let amountOfEven2 list = 
   let amount = List.fold (fun res x -> if x % 2 = 0 then (res + 1) else res) 0 list
   amount

let result2 = amountOfEven2 [1; 2; 3; 4; 5]

let amountOfEven3 list = 
   let newList = List.map (fun x -> (x + 1) % 2) list
   List.sum newList

let result3 = amountOfEven3 [1; 2; 3; 4; 5]

printf "Amount of even numbers in list with filter: %d \n" result1 
printf "Amount of even numbers in list with fold: %d \n" result2
printf "Amount of even numbers in list with map: %d \n" result3