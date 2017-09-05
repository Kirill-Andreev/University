module Program

let isCorrect string = 
    let rec aux string position checkList =
        if (position <> String.length string) then
           if (string.[position] = '{' || string.[position] = '(' || string.[position] = '[') then
              let checkList = string.[position] :: checkList;
              let position = position + 1;
              aux string position checkList
           else
              if (string.[position] = ']' && List.head checkList <> '[' || string.[position] = '}' && List.head checkList <> '{' || string.[position] = ')' && List.head checkList <> '(') then
                 false;
              else 
                 let checkList = List.tail checkList;
                 let position = position + 1;
                 if (position >= String.length string && List.length checkList = 0) then 
                    true;
                 else    
                    aux string position checkList
        else 
           if (List.length checkList = 0) then
              true;
            else 
              false;
    aux string 0 [];