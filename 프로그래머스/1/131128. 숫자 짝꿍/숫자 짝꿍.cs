using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string solution(string X, string Y) {
        string answer = "";
        char[] xDigits = X.ToCharArray();
        int[] xIntDigits = new int[10];
        char[] yDigits = Y.ToCharArray();
        int[] yIntDigits = new int[10];
        List<int> coupleDigits = new List<int>();
        
        //효율적으로 바꾸기
        for(int i = 0; i < xDigits.Length; i++)
        {
            xIntDigits[int.Parse(xDigits[i].ToString())]++;
        }
        for(int i = 0; i < yDigits.Length; i++)
        {
            yIntDigits[int.Parse(yDigits[i].ToString())]++;
        }
        
        for(int i = 0; i < 10; i++)
        {
            int digitCount = Math.Min(xIntDigits[i],yIntDigits[i]);
            for(int j = 0; j < digitCount; j++)
            {
                coupleDigits.Add(i);
            }
        }
        
        coupleDigits.Sort();
        coupleDigits.Reverse();
        if(coupleDigits.Count == 0)
        {
            answer = "-1";
        }
        else if(coupleDigits[0].ToString() == "0")
        {
            answer = "0";
        }
        else
        {
            answer = String.Join("", coupleDigits.ToArray());
        }
        return answer;
    }
}