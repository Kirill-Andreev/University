module MultOfDigits.Tests

open Program
open NUnit.Framework
open FsUnit

[<Test>]
    let ``standart test`` () =
        multDigits 1234 |> should equal 24

[<Test>]
    let ``zero test`` () = 
        multDigits 0 |> should equal 0

[<Test>]
    let ``zero in number test`` () =
        multDigits 99099 |> should equal 0

