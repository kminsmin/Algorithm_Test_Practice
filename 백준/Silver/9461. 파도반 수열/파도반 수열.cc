#include <iostream>
using namespace std;

int main()
{
	unsigned long long wave[100] = { 1,1,1 };
	for (int i = 3; i < 100; i++)
		wave[i] = wave[i - 3] + wave[i - 2];

	int count;
	cin >> count;
	unsigned long long* arr = new unsigned long long[count];
	for (int i = 0; i < count; i++)
	{
		int n;
		cin >> n;
		arr[i] = wave[n - 1];
	}
	for (int i = 0; i < count; i++)
	{
		cout << arr[i] << endl;
	}
	delete[] arr;

	return 0;
}