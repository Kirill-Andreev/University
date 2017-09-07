module Task_2

let sinAverage list = 
    let rec aux list temp length= 
        match list with
        | [] -> temp / length
        | head :: tail -> aux tail (temp + sin head) (length + 1.0)
    aux list 0.0 0.0

let list = [1.0; 2.0; 3.0]
let avg =  sinAverage list
printf "%f\n" avg 
