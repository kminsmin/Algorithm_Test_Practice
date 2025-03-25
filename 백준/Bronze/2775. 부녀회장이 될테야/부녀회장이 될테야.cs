using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            int[ , ] apt = new int[15,15];
            for(int i = 0; i < 15 ; i++)
            {
                for(int j = 1; j < 15; j++)
                {
                    if(i == 0) apt[i,j] = j;
                    else
                    {
                        int sum = 0;
                        for(int k = 1; k <= j; k++)
                        {
                            sum += apt[i-1,k];
                        }
                        apt[i,j] = sum;
                    }
                }
            }
            
            int caseCount = int.Parse(Console.ReadLine());
            string answer = "";
            int temp = 0;
            
            for(int i = 0; i < caseCount; i++)
            {
                int k = int.Parse(Console.ReadLine());
                int n = int.Parse(Console.ReadLine());
                temp = apt[k,n];
                answer += temp.ToString();
                if(i<caseCount-1) answer += "\n";
            }
            Console.WriteLine(answer);
        }
    }
}