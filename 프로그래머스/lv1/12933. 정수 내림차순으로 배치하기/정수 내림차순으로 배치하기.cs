using System.Linq;

public class Solution {
    public long solution(long n) {
        long answer = 0;
        string str = n.ToString();
        int[] arr = new int[str.Length];
        for (int i = 0; i < str.Length; i++)
        {
            arr[i] = int.Parse(str.Substring(i,1));
        }
        arr = arr.OrderByDescending(x => x).ToArray();
        string answerString = "";
        foreach(int num in arr)
        {
            answerString += num.ToString();
        }
        answer = long.Parse(answerString);
        return answer;
    }
}