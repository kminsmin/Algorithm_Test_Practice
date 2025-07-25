#include <iostream>
#include <algorithm>
using namespace std;

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(NULL);

    int n;
    cin >> n;

    int stairs[301];
    int dp[301];

    for (int i = 1; i <= n; i++)
    {
        cin >> stairs[i];
    }

    // 초기값 설정
    dp[0] = 0;
    dp[1] = stairs[1];
    if (n >= 2) {
        dp[2] = stairs[1] + stairs[2];
    }

    // DP 점화식 적용
    for (int i = 3; i <= n; i++)
    {
        dp[i] = max(dp[i - 2] + stairs[i], dp[i - 3] + stairs[i - 1] + stairs[i]);
    }

    cout << dp[n] << endl;

    return 0;
}