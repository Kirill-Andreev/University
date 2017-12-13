module Program

open System

type OperatingSystem =
    abstract RiskOfInfection : int
    abstract Name : string

let Windows =
    { 
        new OperatingSystem with
        member this.RiskOfInfection = 40
        member this.Name = "Windows" 
    }

let Linux =
    { 
        new OperatingSystem with
        member this.RiskOfInfection = 30
        member this.Name = "Linux" 
    }

let MacOS =
    { 
        new OperatingSystem with
        member this.RiskOfInfection = 60
        member this.Name = "MacOS" 
    }

let rand = Random()

type Computer(os : OperatingSystem, initialState : bool) =
    let mutable infection : bool = initialState
    member this.OperatingSystem = os
    member this.OperatingSystemName = os.Name
    member this.IsInfected = infection
    member this.Turn rand =
        if (rand < os.RiskOfInfection) then 
            infection <- true

type LocalNetwork(computers : Computer [], adjacencyMatrix : int [] []) =
    member this.Computers = computers
    member this.NetworkStructure = adjacencyMatrix 
    member this.PrintState =
        for i in 0..computers.Length - 1 do
            if computers.[i].IsInfected then
                    printfn  "%A" ("computer " + string i + " with operating system " + string computers.[i].OperatingSystemName + " is infected")
            else 
               printfn "%A" ("computer " + string i + " with operating system " + string computers.[i].OperatingSystemName + " isn't infected")
        printfn ""
    member this.GetInfectState = 
        Array.init computers.Length (fun i -> computers.[i].IsInfected)

    member this.UpdateState rand =
        let currentInfectState = this.GetInfectState
        let length = computers.Length

        for i in 0..length - 1 do
            for j in 0..length - 1 do
                if adjacencyMatrix.[i].[j] = 1 then
                    if currentInfectState.[i] then
                        computers.[j].Turn rand
