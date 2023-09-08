using System;

public class Solution {
    public int solution(int[,] sizes) {
        int answer = 0;
        int maxWidth = int.MinValue;
        int maxHeight = int.MinValue;
        
        for(int i = 0; i < sizes.GetLength(0); i++)
        {
            if (sizes[i,0] < sizes[i,1])
            {
                int temp =sizes[i,1];
                sizes[i,1] = sizes[i,0];
                sizes[i,0] = temp;
            }
            else continue;
        }
        
        for(int i = 0; i < sizes.GetLength(0); i++)
        {
            if (sizes[i,0] > maxWidth)
            {
                maxWidth = sizes[i,0];
            }
            else continue;
        }
        
        for(int i = 0; i < sizes.GetLength(0); i++)
        {
            if (sizes[i,1] > maxHeight)
            {
                maxHeight = sizes[i,1];
            }
            else continue;
        }
        
        answer = maxWidth * maxHeight;
        
        return answer;
    }
}