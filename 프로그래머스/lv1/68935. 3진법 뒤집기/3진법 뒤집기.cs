using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        List<int> remainders = new List<int>();
        while(n>0)
        {
            remainders.Add(n%3);
            n /= 3;
        }
        for(int i = 1; i <= remainders.Count; i++)
        {
            answer += remainders[i-1] * (int)Math.Pow(3, remainders.Count - i);
        }
        return answer;
    }
}