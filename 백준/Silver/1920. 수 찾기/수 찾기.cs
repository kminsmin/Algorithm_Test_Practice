using System;
using System.Collections.Generic;

namespace Baekjoon
{
    class Program
    {
        static void Main()
        {
            var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            int count = int.Parse(reader.ReadLine());
            string temp = reader.ReadLine();
            string[] a = temp.Split(' ');
            count = int.Parse(reader.ReadLine());
            HashSet<int> numHash = new HashSet<int>();
            for (int i = 0; i < a.Length; i++)
            {
                int num = int.Parse(a[i]);
                numHash.Add(num);
            }

            temp = reader.ReadLine();
            string[] b = temp.Split(' ');
            using (var print = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {

                foreach (string integer in b)
                {
                    int answer = 0;
                    int tempNum = int.Parse(integer);
                    if (numHash.Contains(tempNum)) answer = 1;
                    print.WriteLine(answer);
                }
            }
        }
    }
}
