using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Baekjoon
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int n = arr[0];
            int k = arr[1]-1;
            StringBuilder sb = new StringBuilder("<");
            List<int> numList = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                numList.Add(i);
            }
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                if(i>0)sb.Append(", ");
                index += k;
                index = (index >= numList.Count) ? GetIndex(index, numList.Count) : index;
                sb.Append(numList[index].ToString());
                numList.RemoveAt(index);
            }
            sb.Append(">");
            Console.WriteLine(sb.ToString());
        }
        static int GetIndex(int idx, int max)
        {
            while(idx>=max)
            {
                idx -= max;
            }
            return idx;
        }
    }
}