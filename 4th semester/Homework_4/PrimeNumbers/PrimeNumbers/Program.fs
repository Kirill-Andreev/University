let isPrime n = not ((Seq.exists (fun x -> n % x = 0)) (seq {2 .. n / 2}))
let primeNumbers = Seq.filter isPrime (Seq.initInfinite (fun x -> x + 2))
  
printfn "%A" (primeNumbers)
