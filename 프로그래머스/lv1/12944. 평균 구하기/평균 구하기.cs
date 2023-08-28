public class Solution {
    public double solution(int[] arr) {
        double sum = 0;
        foreach (int num in arr)
        {
            sum += num;
        }
        double answer = 0;
        answer = sum / arr.Length;
        return answer;
    }
}