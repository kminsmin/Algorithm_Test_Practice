using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            char[] word = Console.ReadLine().ToCharArray();
            int count = 0;
            char temp = '*';
            for(int i = 0; i < word.Length; i++)
            {
                switch(temp)
                {
                    case 'c':
                        if(word[i] == '='||word[i] == '-')
                        {
                            break;
                        }
                        else
                        {
                            count++;
                            break;
                        }
                    case 'd':
                        if(word[i] == 'z')
                        {
                            try
                            {
                                if(word[i+1]=='=')
                                {
                                    temp = '*';
                                    i++;
                                    continue;    
                                }
                                else count++;
                            }
                            catch
                            {
                                count++;
                            }
                            
                            break;
                        }
                        else if(word[i] == '-') break;
                        else
                        {
                            count++;
                            break;
                        }
                    case 'l':
                        if(word[i] == 'j') break;
                        else
                        {
                            count++;
                            break;
                        }
                    case 'n':
                        if(word[i] == 'j') break;
                        else
                        {
                            count++;
                            break;
                        }
                    case 's':
                        if(word[i] == '=') break;
                        else
                        {
                            count++;
                            break;
                        }
                    case 'z':
                        if(word[i] == '=') break;
                        else
                        {
                            count++;
                            break;
                        }
                    default:
                        count++;
                        break;
                }
                temp = word[i];
            }
            Console.WriteLine(count);
        }
    }
}