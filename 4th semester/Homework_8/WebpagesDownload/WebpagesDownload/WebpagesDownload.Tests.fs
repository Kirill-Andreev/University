module WebpagesDownload.Tests

open Program
open NUnit.Framework
open FsUnit

[<Test>]
    let ``number of refs test``() =
        let refs = "http://hwproj.me/courses/20" |> downloadPage |> findRefs
        Seq.length(refs) |> should equal 6

