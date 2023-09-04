using System;

public class Solution {
    public int solution(int left, int right) {
        int answer = 0;
        int fact = 0;
        for (int i = left; i <= right; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                {
                    fact++;
                }
            }
            if (fact % 2 == 0)
            {
                answer += i;
            }
            else
            {
                answer -= i;
            }
            fact = 0;
        }
        return answer;
    }
}