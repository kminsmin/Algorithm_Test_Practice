public class Solution {
    public int solution(string s) {
        int answer = 0;
        char[] arr = s.ToCharArray();
        if (char.IsDigit(arr[0]))
        {
            answer = int.Parse(s);
        }
        else
        {
            if (arr[0].ToString() == "+")
            {
                s = s.Substring(1, s.Length-1);
                answer = int.Parse(s);
            }
            else
            {
                s = s.Substring(1, s.Length-1);
                answer = -int.Parse(s);
            }
            
        }
        return answer;
    }
}