module AmountOfEvenNumbersInList.Tests

open Program
open NUnit.Framework
open FsUnit

[<Test>]
    let ``test function with filter`` () =
        amountOfEven [1; 2; 3; 4; 5] |> should equal 2

[<Test>]
    let ``test function with fold`` () =
        amountOfEven2 [1; 2; 3; 4; 5] |> should equal 2

[<Test>]
    let ``test function with map`` () =
        amountOfEven3 [1; 2; 3; 4; 5] |> should equal 2