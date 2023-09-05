public class Solution {
    public int[] solution(int n, int m) {
        int max = (n > m) ? n : m;
        int min = (n < m) ? n : m;
        int gcd = 0;
        int lcm = 0;

        for (int i = 1; i <= min; i++)
        {
            gcd = (n%i==0&&m%i==0) ? i : gcd;
        }
        for (int j = n*m; j>=max; j--)
        {
            lcm = (j%n==0&&j%m==0) ? j : lcm;
        }
        int[] answer = new int[] {gcd, lcm};

        return answer;
    }
}