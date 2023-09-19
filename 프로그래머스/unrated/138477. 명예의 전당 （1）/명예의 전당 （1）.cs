using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int k, int[] score) {
        int arrLength = score.Length;
        int[] answer = new int[arrLength];
        List<int> hallOfFame = new List<int>();
        int temp = 0;
        try
        {
            for(int i = 0; i < k; i++)
            {
                hallOfFame.Add(score[i]);
                hallOfFame.Sort();
                answer[i] = hallOfFame[0];
            }
            if (k>=arrLength)
                return answer;
            for(int i = k; i < arrLength; i++)
            {
                temp = score[i];
                if(temp>hallOfFame[0])
                {
                    hallOfFame[0] = temp;
                    hallOfFame.Sort();
                }
                answer[i] = hallOfFame[0];
            }
        return answer;
        }
        catch(Exception e)
        {
            return answer;
        }
        
    }
}