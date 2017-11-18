module LambdaInterpreter.Tests

open Program
open NUnit.Framework
open FsUnit

[<Test>]
    let ``id test``() =
        let term = (Abs ('x', Var 'x'))
        betaReduction term |> should equal term

[<Test>]
    let ``free variables of (((λa.(λb.b b) (λb.b b)) b) ((λc.(c b)) (λa.a))) test``() =
        let term = (App (App (Abs ('a', App (Abs ('b', App (Var 'b', Var 'b')), Abs ('b', App (Var 'b', Var 'b')))), Var 'b'),  App (Abs ('c', App (Var 'c', Var 'b')), Abs ('a', Var 'a'))))
        free term |> should equal ['b'; 'b']

[<Test>]
    let ``SKKI test``() =
        let term = betaReduction (App (App (Abs ('x', Abs ('y', Abs ('z', App (App (Var 'x', Var 'z'), App (Var 'y', Var 'z'))))), Abs ('x', Abs ('y', Var 'x'))),Abs ('x', Abs ('y', Var 'x'))))
        betaReduction term |> should equal (Abs ('z',Var 'z'))
