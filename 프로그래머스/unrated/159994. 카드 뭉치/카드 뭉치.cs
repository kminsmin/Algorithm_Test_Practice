using System;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
        string answer = "";
        int goalIndex = 0;
        int firstIndex = 0;
        int secondIndex = 0;
        int tryNum = 0;
        string[] trial = new string[goal.Length];

        while(goalIndex < goal.Length)
        {
            try
            {
                for(int i = firstIndex; i < cards1.Length; i++)
                {
                    if(cards1[firstIndex]==goal[goalIndex])
                    {
                        trial[goalIndex] = cards1[firstIndex];
                        goalIndex++;
                        firstIndex++;
                    }
                }
                for(int i = secondIndex; i < cards2.Length; i++)
                {
                    if(cards2[secondIndex]==goal[goalIndex])
                    {
                        trial[goalIndex] = cards2[secondIndex];
                        goalIndex++;
                        secondIndex++;
                    }
                }

                if(tryNum > 5)
                {
                    return "No";
                }
                tryNum++;
            }
            catch(Exception e)
            {
                return "Yes";
            }
            
        }
        answer = "Yes";
        return answer;
    }
}