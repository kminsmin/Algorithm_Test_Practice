using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace Baekjoon
{
    class Program
    {
        static void Main()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            
            int caseNum = int.Parse(sr.ReadLine());
            
            for (int i = 0; i < caseNum; i++)
            {
                string[] input = sr.ReadLine().Split(' ');
                int size = int.Parse(input[0]);
                int targetIndex = int.Parse(input[1]);
                
                int[] priorities = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();
                
                // 우선순위별 개수를 카운트 (1~9 범위)
                int[] priorityCount = new int[10];
                for (int j = 0; j < size; j++)
                {
                    priorityCount[priorities[j]]++;
                }
                
                // 큐에 (우선순위, 원래인덱스) 쌍을 저장
                Queue<(int priority, int originalIndex)> queue = new Queue<(int, int)>();
                for (int j = 0; j < size; j++)
                {
                    queue.Enqueue((priorities[j], j));
                }
                
                int currentMaxPriority = 9;
                // 현재 최고 우선순위 찾기
                while (currentMaxPriority > 0 && priorityCount[currentMaxPriority] == 0)
                {
                    currentMaxPriority--;
                }
                
                int printCount = 0;
                
                while (queue.Count > 0)
                {
                    var (priority, originalIndex) = queue.Dequeue();
                    
                    if (priority == currentMaxPriority)
                    {
                        // 인쇄 가능
                        printCount++;
                        priorityCount[priority]--;
                        
                        // 타겟 문서인지 확인
                        if (originalIndex == targetIndex)
                        {
                            sw.WriteLine(printCount);
                            break;
                        }
                        
                        // 현재 우선순위의 문서가 모두 인쇄되었으면 다음 우선순위로 이동
                        if (priorityCount[currentMaxPriority] == 0)
                        {
                            currentMaxPriority--;
                            while (currentMaxPriority > 0 && priorityCount[currentMaxPriority] == 0)
                            {
                                currentMaxPriority--;
                            }
                        }
                    }
                    else
                    {
                        // 큐의 뒤로 이동
                        queue.Enqueue((priority, originalIndex));
                    }
                }
            }
            
            sw.Close();
            sr.Close();
        }
    }
}