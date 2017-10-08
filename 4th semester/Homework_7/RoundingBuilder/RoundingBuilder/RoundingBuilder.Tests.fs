module RoundingBuilder.Tests

open Program
open NUnit.Framework
open FsUnit

[<Test>]
    let ``result rounded to thousandth`` () =
        calculate 3 |> should equal 0.048

[<Test>]
    let ``result rounded to hundredths`` () =
        calculate 2 |> should equal 0.05
