#include <iostream>
#include <vector>
using namespace std;

int main() {
    int n;
    cin >> n;

    // dp[i] = i를 완전제곱수의 합으로 나타낼 때 필요한 최소 개수
    vector<int> dp(n + 1, 4); // 최대 4개면 모든 수 표현 가능 (라그랑주 정리)

    dp[0] = 0;

    for (int i = 1; i <= n; i++) {
        for (int j = 1; j * j <= i; j++) {
            dp[i] = min(dp[i], dp[i - j * j] + 1);
        }
    }

    cout << dp[n] << endl;

    return 0;
}