using System;

public class Solution {
    public int solution(int[] number) {
        int answer = 0;
        int checkTrio = 0;
        int numLength = number.Length;
        
        for(int i = 0; i <= numLength - 3; i++)
        {
            for(int j = i+1; j <= numLength - 2; j++)
            {
                for(int k = j+1; k <= numLength -1 ; k++)
                {
                    checkTrio += (number[i] + number[j] + number [k]);
                    answer += (checkTrio == 0) ? 1 : 0;
                    checkTrio = 0;
                }
                
            }
        }
        

        return answer;
    }
}