module TestsOfProgram
open Task_2
open NUnit.Framework
open FsUnit

[<Test>]
let test1 () =
    let list = [sin 1.0; sin 1.0; sin 1.0]
    let sinOf1 = sin 1.0
    sinAverage list |> should (equalWithin 0.000001) sinOf1

