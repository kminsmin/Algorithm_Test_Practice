#include <iostream>

using namespace std;


int main() 
{
    ios_base::sync_with_stdio(false);
    cin.tie(NULL);
	int n = 0;
	cin >> n;
	static int maxHeap[100001] = {};
	int heapSize = 0;
	for (int i = 0; i < n; i++)
	{
		int input;
		cin >> input;
		if (input == 0)
		{
			if (heapSize > 0)
			{
				cout << maxHeap[1] << '\n';
				maxHeap[1] = maxHeap[heapSize];
				maxHeap[heapSize] = 0;
				heapSize--;
				int j = 1;
				while (2 * j <= heapSize)
				{
					int maxNode = 2 * j;
					if (maxNode + 1 <= heapSize)
						maxNode = (maxHeap[maxNode] > maxHeap[maxNode + 1]) ? maxNode : maxNode + 1;

					if (maxHeap[maxNode] > maxHeap[j])
					{
						int temp = maxHeap[j];
						maxHeap[j] = maxHeap[maxNode];
						maxHeap[maxNode] = temp;
					}
					else break;
					j = maxNode;
				}
			}
			else
			{
				cout << 0 << '\n';
			}
		}
		else
		{
			heapSize++;
			maxHeap[heapSize] = input;
			int j = heapSize;
			while ((j > 1)&&maxHeap[j/2]<maxHeap[j])
			{
				int temp = maxHeap[j];
				maxHeap[j] = maxHeap[j / 2];
				maxHeap[j / 2] = temp;
				j /= 2;
			}
		}
	}
	return 0;
};

