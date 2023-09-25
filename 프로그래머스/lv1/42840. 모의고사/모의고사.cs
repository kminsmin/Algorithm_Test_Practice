using System;
using System.Collections.Generic;

public class Solution {
    public List<int> solution(int[] answers) {
        int[] answer1 = new int[] { 1, 2, 3, 4, 5};
        int[] answer2 = new int[] {2, 1, 2, 3, 2, 4, 2, 5};
        int[] answer3= new int[] {3, 3, 1, 1, 2, 2, 4, 4, 5, 5};
        Dictionary<int, int> scores = new Dictionary<int, int>();
        scores.Add(1, 0);
        scores.Add(2, 0);
        scores.Add(3, 0);
        List<int> answer = new List<int>();
        
        for (int i = 0; i < answers.Length; i++)
        {
            if (answers[i]==answer1[i%5])
                scores[1]++;
            if (answers[i]==answer2[i%8])
                scores[2]++;
            if (answers[i]==answer3[i%10])
                scores[3]++;
        }
        
        int max = 0;
        foreach(KeyValuePair<int,int> score in scores)
        {
            if (score.Value > max)
            {
                max = score.Value;
                answer.Clear();
                answer.Add(score.Key);
            }
            else if (score.Value == max)
            {
                max = score.Value;
                answer.Add(score.Key);
            }
        }

        return answer;
    }
}