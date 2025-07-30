#include <iostream>
using namespace std;

void func(int current, int target,  int* sumCount);


int main()
{
	int count;
	int sums;
	int* sumPtr = &sums;
	cin >> count;
	int num;
	int* arr = new int[count];
	for (int i = 0; i < count; i++)
	{
		sums = 0;
		cin >> num;
		func(0, num, sumPtr);
		arr[i] = *sumPtr;
	}
	for (int i = 0; i < count; i++)
	{
		cout << arr[i] << endl;
	}
	delete[] arr;

	return 0;
}

void func(int current, int target, int* sumCount)
{
	if (current == target)
	{
		(*sumCount)++;
		return;
	}
	else if (current > target)
		return;
	func(current + 1, target, sumCount);
	func(current + 2, target, sumCount);
	func(current + 3, target, sumCount);
}
