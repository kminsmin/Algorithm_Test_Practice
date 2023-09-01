public class Solution {
    public string solution(string s) {
        string answer = "";
        char[] arr = s.ToCharArray();
        if (arr.Length % 2 == 0)
        {
            answer += arr[(arr.Length-2)/2];
            answer += arr[(arr.Length-2)/2 + 1];
        }
        else
        {
            answer += arr[(arr.Length +1)/2 - 1];
        }
        return answer;
    }
}