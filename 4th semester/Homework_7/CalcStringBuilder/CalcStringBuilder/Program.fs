module Program

open System

let parse str = 
    let number = ref 0.0 
    let resOfParse = Double.TryParse(str, number)
    match resOfParse with
    | true -> Some !number
    | false -> None

type CalcStringBuilder() = 
    member this.Bind(x, f) = 
        match parse x with
        | Some number -> f number
        | None -> None

    member this.Return(x) = Some x
         
let stringExpr = CalcStringBuilder()