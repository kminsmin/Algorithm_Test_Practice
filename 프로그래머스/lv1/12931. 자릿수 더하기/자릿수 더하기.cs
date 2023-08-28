using System;

public class Solution {
    public int solution(int n) {
        string numString = n.ToString();
        string[] stringList = new string[numString.Length];
        for (int i = 0; i < numString.Length; i ++)
        {
            stringList[i] = numString.Substring(i,1);
        }
        int[] numList = new int[stringList.Length];
        for (int i = 0; i < stringList.Length; i++)
        {
            numList[i] = int.Parse(stringList[i]);
        }
        int sum= 0;
        foreach (int num in numList)
        {
            sum += num;
        }
        int answer = sum;
        return answer;
    }
}