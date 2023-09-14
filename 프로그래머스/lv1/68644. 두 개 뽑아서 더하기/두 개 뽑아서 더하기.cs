using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] numbers) {
        int[] answer = new int[] {};
        HashSet<int> answerHash = new HashSet<int>();
        List<int> answerList = new List<int>();

        int sum = 0;
        for(int i = 0; i < numbers.Length-1; i++)
        {
            for(int j = i + 1; j < numbers.Length; j++)
            {
                sum = 0;
                sum = numbers[i] + numbers[j];
                answerHash.Add(sum);
            }
        }
        answerList = answerHash.ToList();
        answerList.Sort();
        answer = answerList.ToArray();
        return answer;
    }
}