using System;
using System.Collections.Generic;

namespace Baekjoon
{
    class Program
    {
        static List<string> words;
        static void Main()
        {
            var n = int.Parse(Console.ReadLine()!);

          var words = new string[n];
          for (int i = 0; i < n; i++)
            words[i] = Console.ReadLine()!;

          words = words
                .Distinct()
                .OrderBy(w => w.Length)
                .ThenBy(w => w)
                .ToArray();

          foreach (var word in words)
            Console.WriteLine(word);
        }
    }
}