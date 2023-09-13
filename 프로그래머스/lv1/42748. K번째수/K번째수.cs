using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public List<int> solution(int[] array, int[,] commands) {       
        List<int> temp = new List<int>();
        List<int> answerList = new List<int>();
        
        for(int i = 0; i < commands.GetLength(0); i++)
        {
            temp.Clear();
            temp = array.Skip(commands[i,0]-1).Take(commands[i,1] - commands[i,0] + 1).ToList();
            temp.Sort();
            answerList.Add(temp[commands[i,2]-1]);
        }
        return answerList;
    }
}