module Tests
open Palindrome
open NUnit.Framework
open FsUnit

[<Test>]
maxPalindrome |> should equal 906609

