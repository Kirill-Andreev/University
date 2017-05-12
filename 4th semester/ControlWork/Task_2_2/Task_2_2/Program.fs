module Task_2

let sinAverage list = 
    let rec aux list temp length= 
        match list with
        | [] -> temp / length
        | head :: tail -> aux tail (temp + head) (length + 1.0)
    aux list 0.0 0.0

let list = [sin 1.0; sin 2.0; sin 3.0]
let avg =  sinAverage list
printf "%f\n" avg 
