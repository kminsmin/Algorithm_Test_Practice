public class Solution {
    public long solution(long n) {
        long answer = 0;
        long root = 0;
        for (long i = 1; i <= n; i++)
             {
                 if (i*i == n)
                 {
                     root = i+1;
                     break;
                 }
             }
        if (root > 0)
        {
            answer = root * root;
            return answer;
        }
        return -1;
    }
}