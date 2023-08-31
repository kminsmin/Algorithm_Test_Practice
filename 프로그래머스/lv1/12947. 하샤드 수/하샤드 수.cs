public class Solution {
    public bool solution(int x) {
        bool answer = false;
        int sum = 0;
        string str = x.ToString();
        char[] arr = str.ToCharArray();
        foreach (char digit in arr)
        {
            sum += int.Parse(digit.ToString());
        }
        if (x % sum == 0)
        {
            answer = true;
        }
        return answer;
    }
}