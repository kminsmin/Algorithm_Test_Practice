using System;

public class Solution {
    public int solution(int number, int limit, int power) {
        int answer = 0;
        int factorCount = 0;
        int attack = 0;
        
        for(int i = 1; i <= number; i++)
        {
            for(int j = 1; j <= i/2; j++)
            {
                if(i%j==0)
                {
                    factorCount++;
                }
            }
            factorCount++;
            attack = (factorCount>limit)? power: factorCount;
            answer += attack;
            factorCount = 0;
            
        }
            
        return answer;
    }
}