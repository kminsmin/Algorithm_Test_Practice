using System;
using System.Linq;

public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
        int answer = 0;
        bool[] isGood = new bool[n];
        bool[] isRich = new bool[n];

        for(int i = 0; i < n; i++)
        {
            isGood[i] = true;
        }
        for(int i = 0;i < lost.Length; i++)
        {
            isGood[lost[i]-1] = false;
        }
        foreach(int heroNum in reserve)
        {
            if(!isGood[heroNum-1])
            {
                isGood[heroNum-1] = true;
                continue;
            }            
            isRich[heroNum-1] = true;     
        }
        
        lost = lost.OrderBy(x => x).ToArray();
        foreach(int lostStudent in lost)
        {
            if(isGood[lostStudent-1])
                continue;
            else if(lostStudent - 2 >= 0 && isRich[lostStudent-2])
            {
                isGood[lostStudent-1] = true;
                isRich[lostStudent-2] = false;
                continue;
            }  
            else if(lostStudent < n && isRich[lostStudent])
            {
                isGood[lostStudent-1] = true;
                isRich[lostStudent] = false;
                continue;
            }      
        }
        
        foreach(bool studentReady in isGood)
        {
            if(studentReady)
            {
                answer++;
            }
        }
        return answer;
    }
}