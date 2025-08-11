using System;

namespace Baekjoon
{
    class Program
    {   
        static void Main()
        {
            char[] arr = Console.ReadLine().ToCharArray();
            int sum = 0;
            string temp = "";
            bool isBuilding = false;
            foreach (char c in arr)
            {
                switch (c)
                {
                    case '+':
                        if (isBuilding)
                        {
                            sum -= int.Parse(temp);
                        }
                        else
                        {
                            sum += int.Parse(temp);
                        }
                        temp = "";
                        break;
                    case '-':
                        if (isBuilding)
                        {
                            sum -= int.Parse(temp);
                        }
                        else
                        {
                            sum += int.Parse(temp);
                            isBuilding = true;
                        }
                        temp = "";
                        break;
                    default:
                        temp += c.ToString();
                        break;
                }
            }
            sum = (isBuilding)? sum - int.Parse(temp): sum + int.Parse(temp);
            Console.WriteLine(sum);
        }
    }
}