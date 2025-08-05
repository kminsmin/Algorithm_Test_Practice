#include <iostream>
using namespace std;

int dp[1001] = {0,1,3};
int n = 0;
int mult = 1;

int main()
{
	cin >> n;
	for (int i = 2; i <= n; i++)
	{
		dp[i] = (2 * dp[i - 1] + mult)%10007;
		mult *= (-1);
	}
	cout << dp[n] << endl;
	return 0;
}