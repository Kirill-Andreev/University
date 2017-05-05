module Palindrome

let isPalindrome (str : string) =
    let strArray = str.ToCharArray()
    let reversedStrArr = Array.rev strArray
    strArray = reversedStrArr

let maxPalindrome =
    let rec find value1 value2 max =
        if value1 > 999 then max
        else
            let rec find2 value3 value4 max2 =
                if value4 > 999 then
                    max2
                else
                    let mul = value3 * value4
                    if isPalindrome(string mul) then
                        if mul > max then 
                            let max2 = mul
                            find2 value3 (value4 + 1) max2
                        else 
                            find2 value3 (value4 + 1) max2
                    else find2 value3 (value4 + 1) max2      
            let max = find2 value1 value2 max
            find (value1 + 1) value2 max
    find 100 100 0

printfn "%A" maxPalindrome