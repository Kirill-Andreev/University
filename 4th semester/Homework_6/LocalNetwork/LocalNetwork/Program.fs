module Program

open System

type OperatingSystem =
    abstract riskOfInfection : int
    abstract name : string

let Windows =
    { 
        new OperatingSystem with
        member this.riskOfInfection = 40
        member this.name = "Windows" 
    }

let Linux =
    { 
        new OperatingSystem with
        member this.riskOfInfection = 30
        member this.name = "Linux" 
    }

let MacOS =
    { 
        new OperatingSystem with
        member this.riskOfInfection = 60
        member this.name = "MacOS" 
    }

let rand = Random()

type Computer(os : OperatingSystem, initialState : bool) =
    let mutable infection : bool = initialState
    member this.operatingSystem = os
    member this.operatingSystemName = os.name
    member this.isInfected = infection
    member this.turn =
        let temp = rand.Next(100)
        if (temp < os.riskOfInfection) then 
            infection <- true

type LocalNetwork(computers : Computer [], adjacencyMatrix : int [] []) =
    member this.computers = computers
    member this.networkStructure = adjacencyMatrix 
    member this.printState =
        for i in 0..computers.Length - 1 do
            if computers.[i].isInfected then
                    printfn  "%A" ("computer " + string i + " with operating system " + string computers.[i].operatingSystemName + " is infected")
            else 
               printfn "%A" ("computer " + string i + " with operating system " + string computers.[i].operatingSystemName + " isn't infected")
        printfn ""
    member this.getInfectState = 
        Array.init computers.Length (fun i -> computers.[i].isInfected)

    member this.updateState =
        let currentInfectState = this.getInfectState
        let length = computers.Length

        for i in 0..length - 1 do
            for j in 0..length - 1 do
                if adjacencyMatrix.[i].[j] = 1 then
                    if currentInfectState.[i] then
                        computers.[j].turn

let adjacencyMatrix = [|[|0; 1; 1; 0|]; 
                        [|1; 0; 0; 1|];
                        [|1; 0; 0; 1|];
                        [|0; 1; 1; 0|];|]

let comp0 = Computer(Linux, true)
let comp1 = Computer(MacOS, false)
let comp2 = Computer(Windows, false)
let comp3 = Computer(Windows, true)

let computers = [|comp0; comp1; comp2; comp3|]
let localNetwork = LocalNetwork(computers, adjacencyMatrix)
let finalState = [|for i in 1 .. computers.Length -> true|]
 
localNetwork.printState

let i = 1
while not (localNetwork.getInfectState = finalState) do
    localNetwork.updateState
    localNetwork.printState