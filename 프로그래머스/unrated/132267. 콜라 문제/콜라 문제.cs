using System;

public class Solution {
    public int solution(int a, int b, int n) {
        int answer = 0;
        
        while(true)
        {
            answer += (n/a * b);
            n = n/a*b + ((n>a)? n%a : 0);
            if (n<a)
                break;
        }
        return answer;
              }        
}