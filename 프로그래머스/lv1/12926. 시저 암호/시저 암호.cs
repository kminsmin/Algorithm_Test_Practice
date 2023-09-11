public class Solution {
    public string solution(string s, int n) {
        char[] temp = s.ToCharArray();
        
        for(int i = 0; i < temp.Length; i++)
        {
            if(char.IsLetter(temp[i]))
            {
                if (char.IsLower(temp[i]))
                {
                    temp[i] = (char)((temp[i] + n - 'a')%26 + 'a');
                    
                }
                else
                {
                   temp[i] = (char)((temp[i] + n - 'A')%26 + 'A');
                }
            }
        }
        return new string(temp);
    }
}