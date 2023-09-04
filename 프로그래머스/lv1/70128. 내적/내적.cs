using System;

public class Solution {
    public int solution(int[] a, int[] b) {
        int answer = 0;
        int i = 0;
        foreach (int num in a)
        {
            answer += num * b[i];
            i++;
        }
        return answer;
    }
}