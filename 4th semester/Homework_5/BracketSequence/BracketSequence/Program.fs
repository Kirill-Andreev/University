module Program

let isBracket symbol =
    match symbol with
    | '(' | '[' | '{' | '}' | ']' | ')' -> true
    | _ -> false

let getOpeningBracket bracket = 
    match bracket with 
    | ')' -> '('
    | ']' -> '['
    | '}' -> '{'
    | _ -> failwith "not a bracket"
         
let isCorrect string =
    let bracketList = List.filter isBracket string 
    let rec aux string  checkList =
        match string with
        | [] -> List.isEmpty checkList
        | head :: tail ->
            match head with
            | ')' | ']' | '}' ->
                match checkList with
                | [] -> false
                | h :: t ->
                    if h = getOpeningBracket head then
                        aux tail t
                    else
                        false
            | _ -> aux tail (head :: checkList)
    aux bracketList []