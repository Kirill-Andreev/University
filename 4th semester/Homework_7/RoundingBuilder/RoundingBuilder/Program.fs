module Program

type RoundingBuilder(precision : int) =
    member this.Bind (x : float, result : float -> float) =
        System.Math.Round(result x, precision)

    member this.Return (x : float) = x

let rounding precision = RoundingBuilder precision

let calculate precision =
    rounding precision {
            let! a = 2.0 / 12.0
            let! b = 3.5
            return a / b
        }
