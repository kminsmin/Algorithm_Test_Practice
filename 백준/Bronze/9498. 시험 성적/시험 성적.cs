using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            int score = int.Parse(Console.ReadLine());
            int quotient = score / 10;
            if(quotient == 10) quotient--;
            string grade = "N/A";
            
            switch(quotient)
            {
                case 9:
                    grade = "A";
                    break;
                case 8:
                    grade = "B";
                    break;
                case 7:
                    grade = "C";
                    break;
                case 6:
                    grade = "D";
                    break;
                default:
                    grade = "F";
                    break;
            }
            Console.WriteLine(grade);
        }
    }
}