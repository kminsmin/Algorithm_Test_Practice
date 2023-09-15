using System;
using System.Collections.Generic;

public class Solution {
    public List<int> solution(string s) {
        List<int> answer = new List<int>();
        char[] array = s.ToCharArray();
        HashSet<string> letters = new HashSet<string>();
        List<string> tempList = new List<string>();
        
        for(int i = 0; i < array.Length; i++)
        {
            tempList.Add(array[i].ToString());
            if(letters.Add(array[i].ToString()))
            {
                answer.Add(-1);
            }
            else
            {
                for(int j = i-1; j >=0; j--)
                {
                    if(array[j]==array[i])
                    {
                        answer.Add(i-j);
                        break;
                    }
                }
            }
        }
        return answer;
    }
}