using System;

public class Solution {
    public int[] solution(string[] keymap, string[] targets) {
        int[] answer = new int[targets.Length];
        int minPress = 100;
        int count = 0;
        int targetIndex = 0;
        foreach(string word in targets)
        {
            char[] letters = word.ToCharArray();
            count = 0;
            foreach(char letter in letters)
            {
                minPress = 100;
                for(int i = 0; i < keymap.Length; i++)
                {
                    int index = keymap[i].IndexOf(letter);
                    if(index != -1 && index+1 < minPress)
                    {
                        minPress = index + 1;
                    }
                }
                 if(minPress == 100)
                {
                    count = -1;
                    break;
                }
                else
                {
                    count += minPress;
                }
            }
            answer[targetIndex] = count;
            targetIndex++;
        }
        return answer;
    }
}