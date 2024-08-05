using System;

namespace Baekjoon
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int interval = 0;
            string ans = "";
            for (int i = 1; i <= num; i++)
            {
                ans += i.ToString() + "\n";
                interval++;
                if (interval > 9000)
                {
                    interval = 0;
                    Console.Write(ans);
                    ans = "";
                }
            }
            ans = ans.TrimEnd('\n');
            Console.Write(ans);
        }
    }
}