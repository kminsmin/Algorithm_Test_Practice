using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Baekjoon
{
    class Program
    {
        static void Main()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            int n = int.Parse(sr.ReadLine());
            int sum = 0; // 평균 계산을 위한 합 저장 변수
            int mode = 0;
            int maxCount = 0;
            int[] arr = new int[n];
            int[] modeArr = new int[8001]; //0~4000 양수, 4001~8000 음수(n*(-1)+4000 처리). 요소 개수 카운팅용 배열
            for (int i = 0; i < n; i++)
            {
                int temp = int.Parse(sr.ReadLine());
                arr[i] = temp;
                sum+= temp;
                if (temp >= 0)
                {
                    modeArr[temp]++;
                    if (modeArr[temp] >= maxCount)
                    {
                        maxCount = modeArr[temp];
                        mode = temp;
                    }
                }
                else
                {
                    modeArr[4000 - temp]++;
                    if (modeArr[4000 - temp] >= maxCount)
                    {
                        maxCount = modeArr[4000 - temp];
                        mode = temp;
                    }
                } 
            }
            int modeCount = 0;
            List<int> modeList = new List<int>();
            for (int i = 0;i < 8001;i++)
            {
                int num = (i > 4000) ? (-1) * (i - 4000) : i;
                if (modeArr[i]==maxCount) modeList.Add(num);
            }
            modeList.Sort();
            mode = (modeList.Count > 1) ? modeList[1] : modeList[0];
            arr = arr.OrderBy(x => x).ToArray();
            int mid = arr[n / 2];
            int range = arr[n-1]-arr[0];
            float mean = (float)sum/n;
            sw.WriteLine(((int)Math.Round(mean, MidpointRounding.AwayFromZero)).ToString());
            sw.WriteLine(mid.ToString());
            sw.WriteLine(mode.ToString());
            sw.WriteLine(range.ToString());
            sw.Close();
            sr.Close();
        }
    }
}