using System;
using System.Linq;

public class Solution {
    public string solution(int[] food) {
        string answer = "";
        for(int i = 1; i < food.Length; i++)
        {
            for(int j = 0; j < food[i]/2; j++)
            {
                answer += i.ToString();
            }
        }
        char[] array = answer.ToCharArray();
        array = array.OrderByDescending(x => x).ToArray();
        answer += "0";
        foreach (char num in array)
        {
            answer += num.ToString();
        }
        return answer;
    }
}