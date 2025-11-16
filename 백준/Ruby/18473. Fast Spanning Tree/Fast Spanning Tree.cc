#include <iostream>
#include <queue>
#include <vector>
using namespace std;

typedef long long ll;

struct poi {
    ll op, all, half, idx;
};

struct com {
    bool operator()(const poi& a, const poi& b) const {
        return a.half > b.half;
    }
};

struct comp {
    bool operator()(const poi& a, const poi& b) const {
        return a.idx > b.idx;
    }
};

ll par[1010101];
ll siz_[1010101];   // 원본에 있던 배열, 로직에서는 안 쓰지만 남겨둠
ll val[1010101];

queue<ll> q;

// pq[정점] : 아직 사용할 수 없는(조건 미충족) 간선 대기열
priority_queue<poi, vector<poi>, com> pq[303030];
// fin : 지금 당장 사용할 수 있는 간선들 (간선 idx 기준 min-heap)
priority_queue<poi, vector<poi>, comp> fin;

ll fi(ll x) {
    if (par[x] == x) return x;
    return par[x] = fi(par[x]);
}

ll mergee(ll a, ll b) {
    a = fi(a);
    b = fi(b);
    if (pq[a].size() <= pq[b].size()) {
        par[a] = b;
        val[b] += val[a];
        while (!pq[a].empty()) {
            auto x = pq[a].top();
            pq[a].pop();
            if (fi(x.op) == b) continue;
            pq[b].push(x);
        }
        return b;
    } else {
        par[b] = a;
        val[a] += val[b];
        while (!pq[b].empty()) {
            auto x = pq[b].top();
            pq[b].pop();
            if (fi(x.op) == a) continue;
            pq[a].push(x);
        }
        return a;
    }
}

int main() {
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    ll n, m;
    cin >> n >> m;

    // 원래 코드엔 n==1이면 while(1); 이 있었는데, 무한 루프라 제거
    for (ll i = 1; i <= n; i++) {
        cin >> val[i];
        par[i] = i;
    }

    for (ll i = 1; i <= m; i++) {
        ll a, b, c;
        cin >> a >> b >> c;
        if (val[a] + val[b] >= c) {
            fin.push({a, b, c, i});
            continue;
        }
        // half 계산 그대로 유지
        pq[a].push({b, c, val[a] + (c - val[a] - val[b] + 1) / 2, i});
        pq[b].push({a, c, val[b] + (c - val[a] - val[b] + 1) / 2, i});
    }

    while (!fin.empty()) {
        auto x = fin.top(); fin.pop();
        ll a = x.op;
        ll b = x.all;
        if (fi(a) == fi(b)) continue;
        q.push(x.idx);

        ll c = mergee(a, b);

        while (!pq[c].empty()) {
            auto k = pq[c].top();
            k.op = fi(k.op);
            if (fi(c) == fi(k.op)) {
                pq[c].pop();
                continue;
            }
            if (val[c] < k.half) break;
            pq[c].pop();

            if (k.all <= val[c] + val[k.op]) {
                fin.push({c, k.op, k.idx, k.idx});
            } else {
                pq[k.op].push({c, k.all,
                               val[k.op] + (k.all - val[k.op] - val[c] + 1) / 2,
                               k.idx});
                pq[c].push({k.op, k.all,
                            val[c] + (k.all - val[k.op] - val[c] + 1) / 2,
                            k.idx});
            }
        }
    }

    cout << q.size() << '\n';
    while (!q.empty()) {
        cout << q.front() << ' ';
        q.pop();
    }
    if (n > 0) cout << '\n';

    return 0;
}
