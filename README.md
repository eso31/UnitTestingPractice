# UnitTestingPractice


### Implement the hash defined by the following pseudo-code and validate it by checking that the hash for  “leepadg” is 680131659347

    function Hash( s : string) : int64
    begin

        h : int64;
        letters : string;
        i : int;
        index : int;
        inc : int; 
        h = 7;
        letters = “acdegilmnoprstuw”;
            
        for ( i from 0 to length(s) )
        begin
            inc = h * 37;
            index = indexOf s[i] in letters;
            h = inc + index;
        end
        return h;
    
    end
    
