using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int n, int m, int[] section) {
        int answer = 0;
        int paintingIndex = 0;
        Dictionary<int, bool> paintedWall = new Dictionary<int,bool>();
        for(int i = 1; i <= n; i++)
        {
            paintedWall.Add(i,true);
        }
        foreach(int erasedWall in section)
        {
            paintedWall[erasedWall] = false;
        }
        int  sectionLength = section[section.Length-1] - section[0] + 1;
        if(m < sectionLength)
        {
            while(paintedWall[section[section.Length-1]]==false)
            {
                if(paintedWall[section[paintingIndex]]==false)
                {
                    for(int i = section[paintingIndex]; i < section[paintingIndex] + m; i++)
                    {
                        paintedWall[i] = true;
                    }
                    answer++;
                }
                paintingIndex++;
            }
        }
        else {answer = 1;}
        return answer;
    }
}