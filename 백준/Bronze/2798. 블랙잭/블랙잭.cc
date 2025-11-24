#include <iostream>
#include <sstream>
#include <string>
#include <vector>

using namespace std;

int main()
{
	int n, m;
	string input;
	getline(cin, input);
	stringstream ss(input);
	ss >> n >> m;
	vector<int> cards;
	string input2;
	getline(cin, input2);
    stringstream ss2(input2);
	while (getline(ss2, input2, ' '))
	{
		cards.push_back(stoi(input2));
	}
	int max = 0;
	int temp;
	for (int i = 0; i < n-2; i++)
	{
		for (int j = i+1; j < n - 1; j++)
		{
			for (int k = j+1; k < n; k++)
			{
				temp = cards[i] + cards[j] + cards[k];
				if ((temp > max) && (temp <= m)) max = temp;
			}
		}
	}
	cout << max << endl;
}