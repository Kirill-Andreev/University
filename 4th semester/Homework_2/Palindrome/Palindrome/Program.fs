module Program

let rec checkPalindrom (str : string) =
    let size = str.Length
    match size with
    | 0 |  1 -> true
    | _ -> if (str.[0] = ' ') then checkPalindrom str.[1 .. size - 1]
           else if (str.[size - 1] = ' ') then checkPalindrom str.[0 .. size - 2]
           else if (str.[0] <> str.[size - 1] ) then false
           else checkPalindrom str.[1 .. size - 2]

let str = "a roza upala na lapu azora"
printf "str is palindrome: %b \n" <| checkPalindrom str

let str1 = "mama mila ramu"
printf "str1 is palindrome: %b \n" <| checkPalindrom str1