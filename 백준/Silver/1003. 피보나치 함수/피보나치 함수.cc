#include <iostream>
#include <string>
using namespace std;


int zeroCount = 0;
int oneCount = 0;
int arr[41];

int main()
{
    string str = "";
    int count;
    int temp;
    cin >> count;
    arr[0] = 0;
    arr[1] = 1;
    arr[2] = 1;
    for (int i = 3; i <= 40; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
    }
    for (int i = 0; i < count; i++)
    {
        cin >> temp;
        if (temp == 0)
        {
            zeroCount = 1;
            oneCount = 0;
        }
        else
        {
            zeroCount = arr[temp - 1];
            oneCount = arr[temp];
        }
        str.append(to_string(zeroCount) + " " + to_string(oneCount) + "\n");
    }
        
    cout << str << endl;
}


