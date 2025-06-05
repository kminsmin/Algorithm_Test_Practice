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

### 3-1 :  이진탐색
딕셔너리로는 충분하지 않은 것 같아 또 코드를 갈아엎었다. 처음 했던 것처럼 카드를 배열로 받아 정렬하고, 이진탐색을 통해 타깃 넘버를 찾고 주위를 검사해 개수를 세어서 리턴한다. 타깃이 없다면 -1을 리턴한다. 그리고 Linq의 Select구문과 OrderBy구문을 혼합하여 한줄만에 배열을 받아오고 int형으로 바꿔 정렬까지 하는 잡기술도 터득했다. 하지만 이 코드도 시간초과를 피할 순 없었다.
```cs
using System;
using System.Linq;

namespace Baekjoon
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] deck = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).OrderBy(x => x).ToArray();
            int m = int.Parse(Console.ReadLine());
            int[] targets = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int count = BinarySearch(deck, targets[0]);
            if (count != -1) Console.Write(count.ToString());
            else Console.Write("0");
            for (int i = 1; i < m; i++)
            {
                Console.Write(" ");
                count = BinarySearch(deck, targets[i]);
                if (count != -1) Console.Write(count.ToString());
                else Console.Write("0");
            }
        }

        static int BinarySearch(int[] deck, int num)
        {
            int low = 0;
            int high = deck.Length-1;
            int idx = -1;

            while(low<=high)
            {
                int mid = (low+high)/2;

                if (deck[mid]==num)
                {
                    int count = 1;
                    idx = mid-1;
                    while (idx>=0&&deck[idx] == deck[mid])
                    {
                        count++;
                        idx--;
                    }
                    idx = mid + 1;
                    while (idx<deck.Length&&deck[idx] == deck[mid])
                    {
                        count++;
                        idx++;
                    }
                    return count;
                }
                else if (num > deck[mid]) low = mid+1;
                else if (num < deck[mid]) high = mid-1;
            }

            return idx;
        }
    }
}
```
### 3-2 : StreamWriter, StringBuilder
문제의 원인은 답을 출력하는 과정에서 무수히 많이 호출되는 Console.Write였다. 이 방식은 매 호출 때마다 Console에 직접 접근하는 방식이라서 성능이 저하된다고 한다. StreamWriter를 사용하여 표준 출력 스트림에 직접 쓰는 것은 버퍼링과 직접적인 스트림 액세스를 통해 효율적인 출력을 제공하기 때문에, StreamWriter를 도입해보았다. 하지만 이 또한 시간초과를 피하지 못해서, StringBuilder 클래스도 사용해보았다. 이는 기존에 '+'연산자를 통해 정답 문자열을 조작하여 새 문자열 객체가 매번 생성되어 메모리 낭비를 초래하던 현상을 막아준다. 하나의 StringBuider 객체에 Append 메서드를 통해 객체를 계속 업데이트 할 수 있기 때문이다. 처음으로 채점 진행률이 63%까지 진행되긴 했다. 하지만!! 이 또한 시간초과를 피하지 못했다.
```cs
using System;
using System.Linq;
using System.IO;
using System.Text;

namespace Baekjoon
{
    class Program
    {
        static void Main()
        {
            using (StreamWriter writer = new StreamWriter(Console.OpenStandardOutput()))
            {
                int n = int.Parse(Console.ReadLine());
                int[] deck = Console.ReadLine().Split(' ').Select(int.Parse).OrderBy(x => x).ToArray();
                int m = int.Parse(Console.ReadLine());
                int[] targets = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                var sb = new StringBuilder();
                int count = 0;

                for (int i = 0; i < m; i++)
                {
                    count = BinarySearch(deck, targets[i]);
                    sb.Append(count != -1 ? count.ToString() : "0").Append(' ');
                }

                writer.WriteLine(sb.ToString().TrimEnd());
            }
        }

        static int BinarySearch(int[] deck, int num)
        {
            int low = 0;
            int high = deck.Length - 1;
            int idx = -1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (deck[mid] == num)
                {
                    int count = 1;
                    idx = mid - 1;
                    while (idx >= 0 && deck[idx] == deck[mid])
                    {
                        count++;
                        idx--;
                    }
                    idx = mid + 1;
                    while (idx < deck.Length && deck[idx] == deck[mid])
                    {
                        count++;
                        idx++;
                    }
                    return count;
                }
                else if (num > deck[mid]) low = mid + 1;
                else high = mid - 1;
            }

            return -1;
        }
    }
}

```

### 3-2 : 이진탐색 업그레이드
타깃넘버를 찾고 좌우를 선형적으로 전부 탐색하던 기존 방식에서, 타깃 넘버의 맨 왼쪽과 맨 오른쪽을 이진탐색으로 구함으로써 개수를 구하는 방식으로 수정하여 시간 복잡도를 줄였다. 드디어 풀었다.
```cs
using System;
using System.Linq;
using System.IO;
using System.Text;

namespace Baekjoon
{
    class Program
    {
        static void Main()
        {
            using (StreamWriter writer = new StreamWriter(Console.OpenStandardOutput()))
            {
                int n = int.Parse(Console.ReadLine());
                int[] deck = Console.ReadLine().Split(' ').Select(int.Parse).OrderBy(x => x).ToArray();
                int m = int.Parse(Console.ReadLine());
                int[] targets = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                var sb = new StringBuilder();
                int count = 0;

                for (int i = 0; i < m; i++)
                {
                    count = BinarySearch(deck, targets[i]);
                    sb.Append(count != -1 ? count.ToString() : "0").Append(' ');
                }

                writer.WriteLine(sb.ToString().TrimEnd());
            }
        }

        static int BinarySearch(int[] deck, int num)
        {
            int low = 0;
            int high = deck.Length - 1;
            int start = -1, end = -1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (deck[mid] == num)
                {
                    start = mid;
                    high = mid - 1;
                }
                else if (num > deck[mid]) low = mid + 1;
                else high = mid - 1;
            }
            low = 0;
            high = deck.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (deck[mid] == num)
                {
                    end = mid;
                    low = mid + 1;
                }
                else if (num > deck[mid]) low = mid + 1;
                else high = mid - 1;
            }

            return (start!=-1&&end!=-1)? end-start+1:-1;
        }
    }
}

```

### 쿠키...(딕셔너리의 한)
2번쨰 풀이법에서 사용했던 딕셔너리 풀이법도 StreamWriter와 StringBuilder를 도입하니 풀리더라...
```cs
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon
{
    class Program
    {
        static void Main()
        {
            using (StreamWriter writer = new StreamWriter(Console.OpenStandardOutput()))
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
                var sb = new StringBuilder();
                if (deckInfo.ContainsKey(temp))
                    sb.Append(deckInfo[temp].ToString());
                else writer.Write("0");
                for (int i = 1; i < m; i++)
                {
                    sb.Append(" ");
                    temp = int.Parse(deck[i]);
                    if (deckInfo.ContainsKey(temp))
                        sb.Append(deckInfo[temp].ToString());
                    else sb.Append("0");
                }
                writer.WriteLine(sb.ToString());
            }
        }
    }
}
```
물론 성능은 이진탐색을 사용한 풀이법이 더 좋다...그래도 억울하다...
