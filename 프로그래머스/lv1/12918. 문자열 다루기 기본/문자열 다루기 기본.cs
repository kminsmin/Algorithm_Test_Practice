public class Solution {
    public bool solution(string s) {
        bool answer = true;
        char[] arr = s.ToCharArray();
        
        if (arr.Length != 4 && arr.Length != 6)
            return false;
        foreach (char item in arr)
        {
            if(char.IsDigit(item) == false)
                return false;
        }
        
        return answer;
    }
}