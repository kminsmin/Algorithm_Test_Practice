using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            string input;
            char[] digits;
            string answer = "";
            while(true)
            {
                input = Console.ReadLine();
                if(int.Parse(input)==0) break;
                digits = input.ToCharArray();
                
                switch(digits.Length)
                {
                    case 1:
                        answer += "yes\n";
                        break;
                    case 2:
                        if (digits[0] == digits[1]) answer += "yes\n";
                        else answer += "no\n";
                        break;
                    case 3:
                        if(digits[0]==digits[2]) answer += "yes\n";
                        else answer += "no\n";
                        break;
                    case 4:
                        if(digits[0]==digits[3])
                        {
                            if(digits[1]==digits[2]) answer += "yes\n";
                            else answer += "no\n";
                        }
                        else answer += "no\n";
                        break;
                    case 5:
                        if(digits[0]==digits[4])
                        {
                            if(digits[1]==digits[3]) answer += "yes\n";
                            else answer += "no\n";
                        }
                        else answer += "no\n";
                        break;
                }
            }
            Console.WriteLine(answer);
        }
    }
}