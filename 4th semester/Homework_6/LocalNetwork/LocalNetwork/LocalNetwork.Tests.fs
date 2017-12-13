module LocalNetwork.Tests

open Program
open NUnit.Framework
open FsUnit

[<TestFixture>]
    type LANTests() =
        member this.Init () =
            let adjacencyMatrix = [|[|0; 1; 1; 0|]; 
                                    [|1; 0; 0; 0|];
                                    [|1; 0; 0; 1|];
                                    [|0; 0; 1; 0|];|]
        
            let comp0 = Computer(Linux, false)
            let comp1 = Computer(MacOS, false)
            let comp2 = Computer(Windows, false)
            let comp3 = Computer(Windows, true)
      
            let computers = [|comp0; comp1; comp2; comp3|]
            LocalNetwork(computers, adjacencyMatrix)

        [<Test>]
            member this.```Test of first step with 100% chance of infection`` () =
                let localNetwork = this.Init()
                let comparedState = [|false; false; true; true|]
                let random = 1
                localNetwork.UpdateState random
                localNetwork.GetInfectState |> should equal comparedState

        [<Test>]
            member this.```Test of second step with 0% chance of infection`` () =
                let localNetwork = this.Init()
                let comparedState = [|false; false; true; true|]
                let random = 1
                let random1 = 100
                localNetwork.UpdateState random
                localNetwork.UpdateState random1
                localNetwork.GetInfectState |> should equal comparedState

        [<Test>]
            member this.```Test of second step with 100% chance of infection`` () =
                let localNetwork = this.Init()
                let comparedState = [|true; false; true; true|]
                let random = 1
                localNetwork.UpdateState random
                localNetwork.UpdateState random
                localNetwork.GetInfectState |> should equal comparedState
