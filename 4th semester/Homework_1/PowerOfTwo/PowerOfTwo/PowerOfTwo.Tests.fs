module PowerOfTwo.Tests

open Program
open NUnit.Framework
open FsUnit

[<Test>]
    let ``standart test`` () =
        powerOfTwo 2 5 |> should equal [4; 8; 16; 32; 64; 128]

[<Test>]
    let ``zero test`` () =
        powerOfTwo 0 0 |> should equal [1]

