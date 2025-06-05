using System;
using System.Linq;
using System.IO;
using System.Text;

namespace Baekjoon
{
    class Program
    {
        static void Main()
        {
            using (StreamWriter writer = new StreamWriter(Console.OpenStandardOutput()))
            {
                int n = int.Parse(Console.ReadLine());
                int[] deck = Console.ReadLine().Split(' ').Select(int.Parse).OrderBy(x => x).ToArray();
                int m = int.Parse(Console.ReadLine());
                int[] targets = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                var sb = new StringBuilder();
                int count = 0;

                for (int i = 0; i < m; i++)
                {
                    count = BinarySearch(deck, targets[i]);
                    sb.Append(count != -1 ? count.ToString() : "0").Append(' ');
                }

                writer.WriteLine(sb.ToString().TrimEnd());
            }
        }

        static int BinarySearch(int[] deck, int num)
        {
            int low = 0;
            int high = deck.Length - 1;
            int start = -1, end = -1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (deck[mid] == num)
                {
                    start = mid;
                    high = mid - 1;
                }
                else if (num > deck[mid]) low = mid + 1;
                else high = mid - 1;
            }
            low = 0;
            high = deck.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (deck[mid] == num)
                {
                    end = mid;
                    low = mid + 1;
                }
                else if (num > deck[mid]) low = mid + 1;
                else high = mid - 1;
            }

            return (start!=-1&&end!=-1)? end-start+1:-1;
        }
    }
}
