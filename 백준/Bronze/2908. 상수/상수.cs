using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            string[] numbers = Console.ReadLine().Split(" ");
            char[] aNum = numbers[0].ToCharArray();
            char[] bNum = numbers[1].ToCharArray();
            aNum = Swap(aNum);
            bNum = Swap(bNum);
            int a = MergeNum(aNum);
            int b = MergeNum(bNum);
            if(a>b) Console.WriteLine(a);
            else Console.WriteLine(b);
            
            
        }
        static char[] Swap(char[] num)
        {
            char temp = num[0];
            num[0] = num[2];
            num[2] = temp;
            return num;
        }
        static int MergeNum(char[] numbers)
        {
            string temp = "";
            foreach(char num in numbers)
            {
                temp += num.ToString();
            }
            return int.Parse(temp);
        }
    }
}