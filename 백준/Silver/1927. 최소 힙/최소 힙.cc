#include <iostream>
using namespace std;

int main() {
    ios_base::sync_with_stdio(false);
    cin.tie(NULL);
    
    int count;
    cin >> count;
    
    static unsigned int minHeap[100001];
    static unsigned int answers[100001];
    int answerCount = 0;
    int heapSize = 0;
    
    for (int i = 0; i < count; i++) {
        unsigned int input;
        cin >> input;
        
        if (input == 0) {
            if (heapSize == 0) {
                answers[answerCount] = 0;
            } else {
                answers[answerCount] = minHeap[1];
                minHeap[1] = minHeap[heapSize];
                heapSize--;
                
                int j = 1;
                while (j * 2 <= heapSize) {
                    int child = j * 2;
                    
                    // 오른쪽 자식이 존재하고 더 작으면 선택
                    if (child + 1 <= heapSize && minHeap[child + 1] < minHeap[child]) {
                        child = child + 1;
                    }
                    
                    // 자식이 부모보다 작으면 교환
                    if (minHeap[child] < minHeap[j]) {
                        unsigned int temp = minHeap[child];
                        minHeap[child] = minHeap[j];
                        minHeap[j] = temp;
                        j = child;
                    } else {
                        break;
                    }
                }
            }
            answerCount++;
        } else {
            heapSize++;
            minHeap[heapSize] = input;
            
            int j = heapSize;
            while (j > 1 && minHeap[j / 2] > minHeap[j]) {
                unsigned int temp = minHeap[j / 2];
                minHeap[j / 2] = minHeap[j];
                minHeap[j] = temp;
                j /= 2;
            }
        }
    }
    
    for (int i = 0; i < answerCount; i++) {
        cout << answers[i] << '\n';
    }
    
    return 0;
}