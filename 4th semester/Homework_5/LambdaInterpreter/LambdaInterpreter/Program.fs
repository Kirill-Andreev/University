module Program

let alphabet = ['a' .. 'z']

type Term =
    | Var of char
    | App of Term * Term
    | Abs of char * Term

let free term =
    let rec aux term acc =
        match term with
        | Var x -> x::acc
        | App (t1, t2) -> let fst = aux t1 acc
                          let snd = aux t2 acc
                          List.append fst snd
        | Abs (x, t) -> let y = aux t acc
                        List.filter (fun n -> n <> x) y
    aux term []

let rec substitute whereSubs insteadSubs whatSubs = 
    match whereSubs with
    | Var x when (x = insteadSubs) -> whatSubs
    | Var x -> whereSubs
    | App (t1, t2) -> App (substitute t1 insteadSubs whatSubs, substitute t2 insteadSubs whatSubs)
    | Abs (x, t) -> 
        match whatSubs with
        | Var y when (x = insteadSubs) -> whereSubs
        | _ when (not(List.contains x <| free whatSubs)) || (not(List.contains insteadSubs <| free t)) -> Abs(x, substitute t insteadSubs whatSubs)
        | _ -> let y = List.head <| List.filter(fun n -> not(List.contains n <| List.append (free t) (free whatSubs))) alphabet
               let fst = substitute t x <| Var y
               let snd = substitute fst insteadSubs whatSubs
               Abs (y, snd)

let rec betaReduction term =
    match term with
    | Var x -> Var x
    | App (Abs (x, t1), t2) -> betaReduction <| substitute t1 x t2
    | App (t1, t2) -> App (betaReduction t1, betaReduction t2)
    | Abs (x, t) -> Abs (x, betaReduction t)
