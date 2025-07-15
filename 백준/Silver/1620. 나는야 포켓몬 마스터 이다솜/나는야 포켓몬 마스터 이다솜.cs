using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Baekjoon
{
    class Program
    {
        static void Main()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            int[] input = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int dexCount = input[0];
            int count = input[1];
            List<string> pokedex = new List<string>();
            Dictionary<string, int> pokeIndex = new Dictionary<string, int>();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < dexCount; i++)
            {
                string pokemon = sr.ReadLine();
                pokedex.Add(pokemon);
                pokeIndex.Add(pokemon, i+1);
            } 
            for (int i = 0;i < count; i++)
            {
                string temp = sr.ReadLine();
                int num = 0;
                if (int.TryParse(temp, out num))
                    sb.AppendLine(pokedex[num - 1]);
                else sb.AppendLine((pokeIndex[temp]).ToString());
            }
            sw.WriteLine(sb.ToString());
            sr.Close();
            sw.Close();
        }
    }
}