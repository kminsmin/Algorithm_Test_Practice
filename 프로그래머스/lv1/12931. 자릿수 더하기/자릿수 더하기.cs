using System;

public class Solution {
    public int solution(int n) {
        string numString = n.ToString();
        string[] stringList = new string[numString.Length];
        for (int i = 0; i < numString.Length; i ++)
        {
            stringList[i] = numString.Substring(i,1);
        }
        /*
        n을 스트링으로 변환하고 String.Substring 메서드를 활용하여 스트링 배열에 한 글자씩 넣어주는 방식을 사용했는데,  
        String.ToCharArray 메서드를 활용했다면 더 깔끔했을 것 같다.
        */
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
