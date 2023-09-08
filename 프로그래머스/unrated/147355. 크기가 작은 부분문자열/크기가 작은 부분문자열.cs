using System;

public class Solution {
    public int solution(string t, string p) {
        int answer = 0;
        int pLength = p.Length;
        for (int i = 0; i <= t.Length - pLength; i++)
        {
            long checkt = long.Parse(t.Substring(i, pLength));
            if ( checkt <= long.Parse(p))
                answer++;
            else continue;
        }
        return answer;
    }
}