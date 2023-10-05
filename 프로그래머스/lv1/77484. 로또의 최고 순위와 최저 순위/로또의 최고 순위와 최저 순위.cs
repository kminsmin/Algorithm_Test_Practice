using System;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        int[] answer = new int[2];
        int winCount = 0;
        int unknown = 0;
        for(int i = 0; i < 6; i++)
        {
            if(lottos[i] == 0)
            {
                unknown++;
                continue;
            }
            foreach(int num in win_nums)
            {
                if(num == lottos[i])
                {
                    winCount++;
                    break;
                }
            }
        }
        answer[0] = CheckWin(winCount + unknown);
        answer[1] = CheckWin(winCount);
        return answer;
    }
    
    public int CheckWin(int winCount)
    {
        switch(winCount)
        {
            case 6:
                return 1;
            case 5:
                return 2;
            case 4:
                return 3;
            case 3:
                return 4;
            case 2:
                return 5;
            default:
                return  6;
        }
    }
}