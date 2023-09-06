public class Solution {
    public string solution(string s) {
        string answer = "";
        string[] words = s.Split(" ");
        bool isFirst = true;
        foreach(string word in words)
        {
            if (isFirst == false)
                answer += " ";
            isFirst = false;
            char[] letters = word.ToCharArray();
            for(int i = 0; i < letters.Length; i++)
            {
                answer += i%2 == 0 ? letters[i].ToString().ToUpper() : letters[i].ToString().ToLower() ;
            }
        }
        return answer;
    }
}