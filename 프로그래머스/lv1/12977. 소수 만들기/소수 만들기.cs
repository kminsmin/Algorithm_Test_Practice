using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    public int solution(int[] nums)
    {
        int answer = 0;
        int checkPrime = 0;
        bool isPrime = true;
        HashSet<int> primeNums = new HashSet<int>();

        for(int i = 0; i <= nums.Length-3; i++)
        {
            for(int j = i+1; j <= nums.Length-2; j++)
            {
                for(int k = j+1; k <= nums.Length-1; k++)
                {
                    checkPrime = nums[i] + nums[j] + nums[k];
                    for(int l = 2; l < checkPrime; l++)
                    {
                        if (checkPrime%l==0) 
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if(isPrime && primeNums.Add(checkPrime))
                    {
                        answer++;
                    }
                    else if((isPrime && !primeNums.Add(checkPrime)))
                    {
                        answer++;
                    }
                    else
                    {
                        isPrime = true;
                        continue;
                    }
                }
            }
        }

        return answer;
    }
}