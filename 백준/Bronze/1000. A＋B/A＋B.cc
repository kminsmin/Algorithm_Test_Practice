#include <sstream>
#include<iostream>
#include <string>
using namespace std;
int main()
{
	int a, b;
	string input;
	getline(cin, input);
	stringstream ss(input);
	ss >> a >> b;
	cout << a + b << endl;
}