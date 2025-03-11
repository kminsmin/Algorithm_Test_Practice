using System;

namespace Baekjoon{
    class Program{
        static void Main()
        {
            string input;
            string[] arr;
            int[] digits;
            while(true)
            {
                input = Console.ReadLine();
                arr = input.Split(" ");
                digits = ParseArr(arr);
                digits = Sort(digits);
                if(digits[2]==0) break;
                
                if(IsRight(digits)) Console.WriteLine("right");
                else Console.WriteLine("wrong");
            }
        }
        
        static int[] Sort(int[] intArr)
        {
            int temp = 0;
            int[] digits = intArr;
            bool isSorted = false;
            while(!isSorted)
            {
                for(int i = 0; i < digits.Length-1; i++)
                {
                    if(digits[i]>digits[i+1])
                    {
                        temp = digits[i];
                        digits[i] = digits[i+1];
                        digits[i+1] = temp;
                        continue;
                    }
                    isSorted = true;
                }
            }
            return digits;
        }
        
        static int[] ParseArr(string[] stringArr)
        {
            int count = stringArr.Length;
            int[] intArr = new int[count];
            for(int i = 0; i < count; i++)
            {
                intArr[i] = int.Parse(stringArr[i]);
            }
            return intArr;
        }
        
        static bool IsRight(int[] intArr)
        {
            if(intArr[0]*intArr[0] + intArr[1]*intArr[1] == intArr[2]*intArr[2])
            {
                return true;
            }
            else return false;
        }
    }
}