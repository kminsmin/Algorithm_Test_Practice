using System;

class Solution
{
    public long solution(int price, long money, int count)
    {
        long newPrice = 0;
        for (int i = 1; i <= count; i ++)
        {
            newPrice += price * i;
        }
        if(money - newPrice >= 0)
            return 0;
        return newPrice - money;
    }
}