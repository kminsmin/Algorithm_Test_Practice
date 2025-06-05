# [Silver IV] 숫자 카드 2 - 10816 

[문제 링크](https://www.acmicpc.net/problem/10816) 

### 성능 요약

메모리: 106940 KB, 시간: 772 ms

### 분류

자료 구조, 정렬, 이분 탐색, 해시를 사용한 집합과 맵

### 제출 일자

2025년 6월 5일 11:49:24

### 문제 설명

<p>숫자 카드는 정수 하나가 적혀져 있는 카드이다. 상근이는 숫자 카드 N개를 가지고 있다. 정수 M개가 주어졌을 때, 이 수가 적혀있는 숫자 카드를 상근이가 몇 개 가지고 있는지 구하는 프로그램을 작성하시오.</p>

### 입력 

 <p>첫째 줄에 상근이가 가지고 있는 숫자 카드의 개수 N(1 ≤ N ≤ 500,000)이 주어진다. 둘째 줄에는 숫자 카드에 적혀있는 정수가 주어진다. 숫자 카드에 적혀있는 수는 -10,000,000보다 크거나 같고, 10,000,000보다 작거나 같다.</p>

<p>셋째 줄에는 M(1 ≤ M ≤ 500,000)이 주어진다. 넷째 줄에는 상근이가 몇 개 가지고 있는 숫자 카드인지 구해야 할 M개의 정수가 주어지며, 이 수는 공백으로 구분되어져 있다. 이 수도 -10,000,000보다 크거나 같고, 10,000,000보다 작거나 같다.</p>

### 출력 

 <p>첫째 줄에 입력으로 주어진 M개의 수에 대해서, 각 수가 적힌 숫자 카드를 상근이가 몇 개 가지고 있는지를 공백으로 구분해 출력한다.</p>

--------------------------------------------------------------------------------------------------------------
# 풀이
### 1차 풀이 및 난관
처음엔 문제의 풀이 흐름을 직관적으로 구현했다. 카드의 배열을 만들고 Linq로 정렬하고, 타깃 넘버의 배열을 받고, 타깃 넘버의 배열의 모든 요소를 검사하며 2중 for문을 통해 해당 요소가 deck 배열에 있는지 확인하고, 있다면 개수를 저장해두는 count배열에 반영한다. 역시 시간 제한이 빡센 문제에 2중 for문을 사용하는건 어림도 없다는 걸 다시 한번 깨달았다.
```cs
using System;
using System.Linq;

namespace Baekjoon{
    class Program{
        static void Main(){
            int n = int.Parse(Console.ReadLine());
            string[] deck = Console.ReadLine().Split(' ');
            deck = deck.OrderBy(x => x).ToArray();
            int m = int.Parse(Console.ReadLine());
            string[] targets = Console.ReadLine().Split(' ');
            int[] counts = new int[m];
            int index = 0;
            for(int i = 0; i < m; i++)
            {
                for(int j = index; j < n; j++)
                {
                    if(deck[j]==targets[i])counts[i]++;
                    else if(int.Parse(deck[j])>int.Parse(targets[i]))
                    {
                        index = j;
                        break;
                    }
                }
            }
            string answer = "";
            foreach(int num in counts)
            {
                answer += num.ToString()+ " ";
            }
            answer.TrimEnd();
            Console.WriteLine(answer);    
        }
    }
}
```

### 2-1 : 딕셔너리
이후 새로운 풀이 방법을 생각해봤는데, 딕셔너리를 통해 카드를 저장하는 방법을 구현해보았다. 이렇게 하면 굳이 카드를 정렬할 필요가 없고, 개수를 저장하는 별도의 배열을 만들 필요도 없기 때문이다. 하지만 메모리 초과 오류가 났다.
```cs
using System;
using System.Linq;
using System.Collections.Generic;

namespace Baekjoon
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] deck = Console.ReadLine().Split(' ');
            deck = deck.OrderBy(x => x).ToArray();
            Dictionary<string, int> deckInfo = new Dictionary<string, int>();
            foreach (string num in deck)
            {
                if (!deckInfo.ContainsKey(num)) deckInfo.Add(num, 1);
                else deckInfo[num] = deckInfo[num] + 1;
            }
            int m = int.Parse(Console.ReadLine());
            string[] targets = Console.ReadLine().Split(' ');
            string answer = "";
            for (int i = 0; i < m; i++)
            {
                if (deckInfo.ContainsKey(targets[i]))
                    answer += deckInfo[targets[i]].ToString() + " ";
                else answer += "0 ";
            }

            answer.TrimEnd();
            Console.WriteLine(answer);
        }
    }
}
```

### 2-2 : answer에 저장하지 말고, 바로 write
구글링해보니 문자열을 연산자 '+'를 통해 조합하면 '+'를 사용할 때마다 새로운 string 인스턴스가 생성된다고 한다. 이렇게 가비지가 쌓여서 메모리 초과가 발생하는 것 같아서 answer 문자열에 답을 계속 담아두는 형식이 아닌, 그때 그때 바로 출력하는 형식으로 수정했다. 하지만 시간초과 문제는 여전히 해결되지 않았다.
```cs
using System;
using System.Linq;
using System.Collections.Generic;

namespace Baekjoon
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] deck = Console.ReadLine().Split(' ');
            deck = deck.OrderBy(x => x).ToArray();
            Dictionary<int, int> deckInfo = new Dictionary<int, int>();
            int temp = 0;
            foreach (string num in deck)
            {
                temp = int.Parse(num);
                if (!deckInfo.ContainsKey(temp)) deckInfo.Add(temp, 1);
                else deckInfo[temp] = deckInfo[temp] + 1;
            }
            int m = int.Parse(Console.ReadLine());
            deck = Console.ReadLine().Split(' ');
            temp = int.Parse(deck[0]);
            if (deckInfo.ContainsKey(temp))
                Console.Write(deckInfo[temp].ToString());
            else Console.Write("0");
            for (int i = 1; i < m; i++)
            {
                Console.Write(" ");
                temp = int.Parse(deck[i]);
                if (deckInfo.ContainsKey(temp))
                    Console.Write(deckInfo[temp].ToString());
                else Console.Write("0");
            }
        }
    }
}
```
