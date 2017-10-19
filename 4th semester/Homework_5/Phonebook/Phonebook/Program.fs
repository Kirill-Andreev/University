module Program

open System.IO

let menu() = 
    printfn "\nEnter the command:
            0 - Exit
            1 - Add new record
            2 - Find number
            3 - Find name
            4 - Print all data
            5 - Save data to file
            6 - Read data from file"

let addRecord name number data =
    (name, number) :: data
    
let findNumber name data =
    let data = List.filter (fun x -> fst x = name) data
    let res = false
    if data.IsEmpty then
        printfn "\nPhone not found\n"
    else
        List.iter (fun x -> printfn "%s\n" (snd x)) data |> ignore

let findName number data =
    let data = List.filter (fun x -> snd x = number) data
    if data.IsEmpty then
        printfn "\nName not found\n"
    else
        List.iter (fun x -> printfn "%s\n" (fst x)) data |> ignore

let printData data =
    List.iter (fun x -> printfn "%s %s\n" <|| x) data
    
let writeToFile path (str : string) =
    try
        use file = File.CreateText path
        file.WriteLine str
    with
    | exc -> printfn "Error %s" exc.Message

let saveData (path : string) data =
    writeToFile path (data.ToString())

let getNumber str = 
    let number = String.filter (fun x -> (x >= '0') && (x <= '9')) str
    number

let getName str = 
    let name = String.filter (fun x -> (x <= 'z') && (x >= 'a') || (x <= 'Z') && (x >= 'A')) str
    name

let readData path data = 
    try
        use reader = File.OpenText path
        let output = reader.ReadLine()
        let outputToArray = output.Split(';')
        let data = Array.toList <| Array.map (fun x -> (getName x, getNumber x)) outputToArray
        printf "%A" data
    with
    | exc -> printfn "Error %s" exc.Message

let rec start data = 
    menu()
    let command = System.Console.ReadLine()
        
    match command with
    | "0" -> exit 0
    | "1" ->
        printfn "%s" "\nEnter name"
        let name = System.Console.ReadLine()
        printfn "%s" "\nEnter phone number"
        let number = System.Console.ReadLine()
        start (addRecord name number data)
    | "2" ->
        printfn "%s" "\nEnter name to find"
        findNumber(System.Console.ReadLine()) data
        start data
    | "3" ->
        printfn "%s" "\nEnter number to find"
        findName(System.Console.ReadLine()) data
        start data
    | "4" ->
        printfn "%s" "\nAll phonebook data: "
        printData data
        start data
    | "5" ->
        printfn "%s" "\nData has been saved" 
        saveData "phoneBook.txt" data
        start data
    | "6" ->
        printfn "%s" "\nOpening file"  
        readData "phoneBook.txt" data
        start data
    | _ -> 
        printfn "%s" "\nInvalid input. Please try again"
        start data

let inputData = []
start inputData
