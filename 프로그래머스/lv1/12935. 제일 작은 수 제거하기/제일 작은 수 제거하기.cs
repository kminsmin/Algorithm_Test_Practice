using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(int[] arr) {
        List<int> answer = arr.ToList();
        int minNum = 0;
        for (int i = 0; i < answer.Count; i++)
        {
            if (i == 0)
                minNum = answer[i];
            else
            {
                if(answer[i]<minNum)
                   minNum = answer[i];
                else continue;
            }
        }
        answer.Remove(minNum);
        if (answer.Count == 0)
        {
            answer.Add(-1);
        }
        return answer.ToArray();
    }
}