public class Solution {
    public string solution(string[] seoul) {
        int i = 0;
        foreach (string str in seoul)
        {
            if(str == "Kim")
            {
                break;
            }
            i++;
        }
        string answer = $"김서방은 {i}에 있다";
        return answer;
    }
}