using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        bool isIn = false;
        for (int i = 0 ; i < 10; i ++)
        {
            isIn = false;
            foreach(int num in numbers)
            {
                if (i == num)
                {
                    isIn = true;
                    break;
                }                   
            }
            if (isIn == false)
                answer += i;
        }
        return answer;
    }
}