#include <bits/stdc++.h>
using namespace std;

string A, B;
string ans;

void solve_lcs(int ax, int ay, int bx, int by) {
    if (ax > ay || bx > by) return;

    // 길이 1인 구간 처리 (직접 비교)
    if (ax == ay) {
        for (int j = bx; j <= by; ++j) {
            if (A[ax] == B[j]) {
                ans.push_back(A[ax]);
                break;
            }
        }
        return;
    }
    if (bx == by) {
        for (int i = ax; i <= ay; ++i) {
            if (A[i] == B[bx]) {
                ans.push_back(B[bx]);
                break;
            }
        }
        return;
    }

    int amid = (ax + ay) / 2;
    int m = by - bx + 1;

    vector<int> L(m + 1), R(m + 1);
    vector<int> prev(m + 1), cur(m + 1);

    // 앞에서부터: A[ax..amid], B[bx..by]
    fill(prev.begin(), prev.end(), 0);
    for (int i = ax; i <= amid; ++i) {
        cur[0] = 0;
        for (int j = 1; j <= m; ++j) {
            if (A[i] == B[bx + j - 1]) {
                cur[j] = prev[j - 1] + 1;
            } else {
                cur[j] = max(prev[j], cur[j - 1]);
            }
        }
        prev.swap(cur);
    }
    for (int j = 0; j <= m; ++j) L[j] = prev[j];

    // 뒤에서부터: A[amid+1..ay], B[bx..by]
    fill(prev.begin(), prev.end(), 0);
    for (int i = ay; i >= amid + 1; --i) {
        cur[0] = 0;
        for (int j = 1; j <= m; ++j) {
            if (A[i] == B[by - j + 1]) {
                cur[j] = prev[j - 1] + 1;
            } else {
                cur[j] = max(prev[j], cur[j - 1]);
            }
        }
        prev.swap(cur);
    }
    for (int j = 0; j <= m; ++j) R[j] = prev[j];

    // 분할 지점 k 선택: B를 [bx..bx+k-1], [bx+k..by] 로 나눔
    int bestK = 0;
    int bestVal = -1;
    for (int k = 0; k <= m; ++k) {
        int val = L[k] + R[m - k];
        if (val > bestVal) {
            bestVal = val;
            bestK = k;
        }
    }

    // 재귀 호출 (순서 중요: 앞쪽 먼저)
    solve_lcs(ax, amid, bx, bx + bestK - 1);
    solve_lcs(amid + 1, ay, bx + bestK, by);
}

int main() {
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    if (!(cin >> A >> B)) return 0;

    // 0-based → 0-based 그대로 쓰지만 구간 인덱스를 포함형으로 넘김
    int n = (int)A.size();
    int m = (int)B.size();

    solve_lcs(0, n - 1, 0, m - 1);

    cout << ans.size() << '\n';
    cout << ans << '\n';

    return 0;
}
