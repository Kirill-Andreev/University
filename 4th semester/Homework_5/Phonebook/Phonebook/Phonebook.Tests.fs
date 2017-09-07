module Phonebook.Tests

open Program
open NUnit.Framework
open FsUnit

[<Test>]
    let ``add new record in empty phonebook test`` () =
        let inputData = []
        addRecord "Kirill" "1111" inputData |> should equal [("Kirill", "1111")]

[<Test>]
    let ``add new record test`` () =
        let inputData = [("Kirill", "1111")]
        addRecord "Andreev" "2222" inputData |> should equal [("Andreev", "2222"); ("Kirill", "1111")]

[<Test>]
    let ``find number by name test`` () =
        let inputData = [("Andreev", "2222"); ("Kirill", "1111")]
        findNumber "Kirill" inputData |> should equal true