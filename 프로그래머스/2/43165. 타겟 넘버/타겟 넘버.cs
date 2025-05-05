using System;

public class Solution {
    public int count = 0;
    public int targetNum = 0;
    public int solution(int[] numbers, int target) {
        targetNum = target; 
        dfs(numbers, 0, 0);
        return count;
    }
    
    public void dfs(int[] numbers, int index, int value)
    {
         if(index==numbers.Length&&value==targetNum)
         {
             count++;
             return;
         }
        else if(index==numbers.Length) return;
        
        dfs(numbers, index+1, value+numbers[index]);
        dfs(numbers, index+1, value-numbers[index]);
    }
}