module LocalNetwork.Tests

open Program
open NUnit.Framework
open FsUnit

type LANTests() =
        let adjacencyMatrix = [|[|0; 1; 1; 0|]; 
                                [|1; 0; 0; 0|];
                                [|1; 0; 0; 1|];
                                [|0; 0; 1; 0|];|]
        
        let comp0 = Computer(Linux, false)
        let comp1 = Computer(MacOS, false)
        let comp2 = Computer(Windows, false)
        let comp3 = Computer(Windows, true)
      
        let computers = [|comp0; comp1; comp2; comp3|]
        let localNetwork = LocalNetwork(computers, adjacencyMatrix)

        [<Test>]
            member this.```Test of first step with 100% chance of infection`` () =
                let comparedState = [|false; false; true; true|]
                let random = 1
                localNetwork.updateState random
                localNetwork.getInfectState |> should equal comparedState

        [<Test>]
            member this.```Test of second step with 0% chance of infection`` () =
                let comparedState = [|false; false; true; true|]
                let random = 1
                let random1 = 100
                localNetwork.updateState random
                localNetwork.updateState random1
                localNetwork.getInfectState |> should equal comparedState

        [<Test>]
            member this.```Test of second step with 100% chance of infection`` () =
                let comparedState = [|true; false; true; true|]
                let random = 1
                localNetwork.updateState random
                localNetwork.updateState random
                localNetwork.getInfectState |> should equal comparedState

//[<Test>]
//    let ``Test of first step with 100% chance of infection`` () =
//        let adjacencyMatrix = [|[|0; 1; 1; 0|]; 
//                                [|1; 0; 0; 0|];
//                                [|1; 0; 0; 1|];
//                                [|0; 0; 1; 0|];|]
//        
//        let comp0 = Computer(Linux, false)
//        let comp1 = Computer(MacOS, false)
//        let comp2 = Computer(Windows, false)
//        let comp3 = Computer(Windows, true)
//      
//        let computers = [|comp0; comp1; comp2; comp3|]
//        let localNetwork = LocalNetwork(computers, adjacencyMatrix)
//
//        let comparedState = [|false; false; true; true|]
//        let random = 1
//        localNetwork.updateState random
//        localNetwork.getInfectState |> should equal comparedState
//
//[<Test>]
//    let ``Test of second step with 0% chance of infection`` () =
//        let adjacencyMatrix = [|[|0; 1; 1; 0|]; 
//                                [|1; 0; 0; 0|];
//                                [|1; 0; 0; 1|];
//                                [|0; 0; 1; 0|];|]
//        
//        let comp0 = Computer(Linux, false)
//        let comp1 = Computer(MacOS, false)
//        let comp2 = Computer(Windows, false)
//        let comp3 = Computer(Windows, true)
//      
//        let computers = [|comp0; comp1; comp2; comp3|]
//        let localNetwork = LocalNetwork(computers, adjacencyMatrix)
//
//        let comparedState = [|false; false; true; true|]
//        let random = 1
//        let random1 = 100
//        localNetwork.updateState random
//        localNetwork.updateState random1
//        localNetwork.getInfectState |> should equal comparedState

//    [<Test>]
//        let ```Test of second step with 100% chance of infection`` () =
//        let adjacencyMatrix = [|[|0; 1; 1; 0|]; 
//                                [|1; 0; 0; 0|];
//                                [|1; 0; 0; 1|];
//                                [|0; 0; 1; 0|];|]
//        
//        let comp0 = Computer(Linux, false)
//        let comp1 = Computer(MacOS, false)
//        let comp2 = Computer(Windows, false)
//        let comp3 = Computer(Windows, true)
//      
//        let computers = [|comp0; comp1; comp2; comp3|]
//        let localNetwork = LocalNetwork(computers, adjacencyMatrix)
//
//        let comparedState = [|true; false; true; true|]
//        let random = 1
//        localNetwork.updateState random
//        localNetwork.updateState random
//        localNetwork.getInfectState |> should equal comparedState