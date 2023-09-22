using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public long solution(int k, int m, int[] score) {
        long answer = 0;
        List<int> scoreList = score.ToList();
        scoreList.Sort();
        scoreList.Reverse();
        int appleIndex = m-1;
        int worstApple = 0;
        try
        {
           worstApple = scoreList[appleIndex]; 
        }
        catch(Exception e)
        {
            return answer;
        }
        
        while(appleIndex < score.Length)
        {
            worstApple = scoreList[appleIndex];
            answer += worstApple * m;
            appleIndex += m;     
        }
        
        return answer;
    }
}