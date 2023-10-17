using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        List<char> letters = s.ToCharArray().ToList();
        char x;
        int xCount = 0;
        int elseCount = 0;
        int lettersNum = 0;
        
        while(true)
        {
            xCount = 1;
            elseCount = 0;
            x = letters[0];
            letters.RemoveAt(0);
            lettersNum = letters.Count;
            for(int i = 0; i < lettersNum; i++)
            {
                if(letters[0] == x)
                {
                    xCount++;
                }
                else
                {
                    elseCount++;
                }
                letters.RemoveAt(0);

                if(xCount == elseCount && xCount !=0)
                {
                    answer++;
                    break;
                }
            }    
            
            if(letters.Count == 0 && xCount == elseCount)
                break;
            else if(letters.Count == 0 && xCount != elseCount)
            {
                answer++;
                break;
            }
        }
        return answer;
    }
}