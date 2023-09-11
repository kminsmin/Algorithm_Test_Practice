public class Solution {
    public string solution(string s, int n) {
        string answer = "";
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        char[] alphabets = alphabet.ToCharArray();
        char[] letters = s.ToCharArray();
        bool isCapital = false;
        
        for(int i = 0; i < letters.Length; i++)
        {
            if(char.IsLetter(letters[i])==false)
            {
                answer += " ";
                continue;
            }
            if (char.IsLower(letters[i]) == false)
            {
                letters[i] = char.ToLower(letters[i]); 
                isCapital = true;
            }
            

            for(int j = 0; j < 26; j++)
            {         
                if (alphabets[j] == letters[i])
                {
                    letters[i] = (j+n<=25)? alphabets[j+n] : alphabets[j+n-26];
                    if (isCapital)
                        letters[i] = char.ToUpper(letters[i]);
                    answer += letters[i].ToString();
                    break;
                }
                else continue;
            }
            isCapital = false;
        }
        return answer;
    }
}