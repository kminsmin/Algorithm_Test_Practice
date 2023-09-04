using System.Linq;

public class Solution {
    public string solution(string s) {
        string answer = "";
        char[] arr = s.ToCharArray();
        arr = arr.OrderByDescending(x => x).ToArray();
        foreach (char letter in arr)
        {
            answer += letter.ToString();
        }
        return answer;
    }
}