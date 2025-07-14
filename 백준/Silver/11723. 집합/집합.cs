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
            int count = int.Parse(sr.ReadLine());
            StringBuilder sb = new StringBuilder();
            Int32 setBit = 0;
            for (int i = 0; i < count; i++)
            {
                string command = sr.ReadLine();
                Int32 x = 0;
                string func = "";
                switch (command)
                {
                    case "all":
                        setBit = 2097150;
                        break;
                    case "empty":
                        setBit = 0;
                        break;
                    default:
                        string[] arr = command.Split(' ');
                        func = arr[0];
                        x = Int32.Parse(arr[1]);
                        switch(func)
                        {
                            case "add":
                                setBit |= (1 << x);
                                break;
                            case "remove":
                                setBit &= ~(1 << x);
                                break;
                            case "check":
                                if ((setBit&(1<<x))>0) sb.AppendLine("1");
                                else sb.AppendLine("0");
                                break;
                            case "toggle":
                                if ((setBit & (1 << x)) > 0) setBit &= ~(1 << x);
                                else setBit |= (1 << x);
                                break;
                        }
                        break;
                }
            }
            sw.WriteLine(sb.ToString());
            sr.Close();
            sw.Close();
        }
    }
}