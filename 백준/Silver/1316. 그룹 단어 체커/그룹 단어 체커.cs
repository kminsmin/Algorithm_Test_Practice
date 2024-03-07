using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            int count = int.Parse(Console.ReadLine());
            int groupCount = 0;
            bool isGroup = false;
            for(int i = 0; i < count; i++)
            {
                char[] word = Console.ReadLine().ToCharArray();
                List<char> letterList = new List<char>();
                char temp = '*';
                isGroup = true;
                foreach(char letter in word)
                {
                    if(letter != temp)
                    {
                        if(!letterList.Contains(letter))
                        {
                            letterList.Add(letter);
                            temp = letter;
                        }
                        else
                        {
                            isGroup = false;
                            break;
                        }
                    }
                    else continue;
                }
                if(isGroup) groupCount++;
            }
            Console.WriteLine(groupCount);
        }
    }
}