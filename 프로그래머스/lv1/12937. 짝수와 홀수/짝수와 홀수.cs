public class Solution {
    public string solution(int num) {
        int remainder = num % 2;
        string answer = "";
        if (remainder == 0)
        {
            answer = "Even";
        }
        else
        {
            answer = "Odd";
        }
        
        return answer;
    }
}