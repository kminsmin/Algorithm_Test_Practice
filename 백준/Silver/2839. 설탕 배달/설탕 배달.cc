#include <iostream>

using namespace std;

int main()
{
    int target;
    int count = 0;
    cin >> target;
    while(true)
    {
        if (target%5==0)
        {
            count += (target/5);
            break;
        }
        else
        {
            target -= 3;
            count++;
            if (target == 0) break;
            else if (target < 0)
            {
                count = -1;
                break;
            }
        }
    }
    cout << count << endl;
}
