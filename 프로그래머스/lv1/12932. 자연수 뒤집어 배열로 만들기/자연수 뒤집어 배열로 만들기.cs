public class Solution {
    public int[] solution(long n) {
        string str = n.ToString();
        int[] answer = new int[str.Length];
        int[] arr = new int[str.Length];
        for (int i = 0; i < str.Length; i++)
        {
            arr[i] = int.Parse(str.Substring(i,1));
        }
        for (int j = 0; j < arr.Length; j++)
        {
            answer[j] = arr[arr.Length - j-1];
        }

        return answer;
    }
}