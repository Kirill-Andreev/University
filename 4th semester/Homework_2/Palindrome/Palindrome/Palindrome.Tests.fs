module Palindrome.Tests

open Program
open NUnit.Framework
open FsUnit

[<Test>]
    let ``true palindrome test`` () =
        checkPalindrom "a roza upala na lapu azora" |> should equal true

[<Test>]
    let ``false palindrome test`` () =
        checkPalindrom "ololol" |> should equal false

[<Test>]
    let ``empty string test`` () =
        checkPalindrom "" |> should equal true

[<Test>]
    let ``single-letter string test`` () =
        checkPalindrom "a" |> should equal true

