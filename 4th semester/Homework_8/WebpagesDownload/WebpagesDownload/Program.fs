module Program

open System
open System.Threading
open System.Net
open System.IO
open System.Text.RegularExpressions

let downloadPage (url : string) = 
    let request = WebRequest.Create(url)
    use response = request.GetResponse()
    use stream = response.GetResponseStream()
    use reader = new StreamReader(stream)
    reader.ReadToEnd()

let findRefs (text : string) = 
    let pattern = "<a href=\"http://.+?\">"
    let regex = new Regex(pattern, RegexOptions.IgnoreCase)
    let matches = regex.Matches(text)
    seq {
    for x in matches do
        yield x.Value.Substring(9, x.Value.Length - 9 - 2)
    }

let downloadRefPages (url : string) = 
    async {
        try 
            let request = WebRequest.Create(url)
            use! response = request.AsyncGetResponse()
            use stream = response.GetResponseStream()
            use reader = new StreamReader(stream)
            let text = reader.ReadToEnd()
            do printfn "%s URL consists of %d characters" url text.Length
        with
        | :? WebException as e ->
            printfn "Page not found" 
    }

let allRefsInfo url = 
    url |> downloadPage |> findRefs |> Seq.map (fun s -> downloadRefPages s) |> Async.Parallel |> Async.RunSynchronously |> ignore

allRefsInfo "http://hwproj.me/courses/20"