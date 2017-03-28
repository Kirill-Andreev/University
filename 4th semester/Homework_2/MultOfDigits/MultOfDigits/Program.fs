let rec multDigits n =
    if n < 10 then n
    else (n % 10) * multDigits (n/10)

let result = multDigits 1234
printf "%d" result
