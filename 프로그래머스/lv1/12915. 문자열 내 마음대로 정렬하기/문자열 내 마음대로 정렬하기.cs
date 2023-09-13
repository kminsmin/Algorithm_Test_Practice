using System.Linq;
public class Solution {
    public string[] solution(string[] strings, int n) {
        string[] answer = new string[] {};
        answer = strings.OrderBy(x => x.Substring(n, 1)).ThenBy(x => x).ToArray();
        return answer;
    }
}