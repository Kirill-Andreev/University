module PrimeNumbers.Tests

open Program
open NUnit.Framework
open FsUnit

[<Test>]
    let ``test isPrime function`` () =
        isPrime 4 |> should equal false
        isPrime 5 |> should equal true