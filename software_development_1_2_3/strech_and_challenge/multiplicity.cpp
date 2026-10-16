#include <bits/stdc++.h>
using namespace std;

vector<int> dp(1e6, -1);

int get_m(int n) {
    int a = 1;
    while (n > 0) {
        a *= (n % 10);
        n /= 10;
    }

    return a;
}

int memo(int n) {
    if (dp[n] == -1) {
        int v = get_m(n);
        dp[n] = memo(v) + 1;
    }
    
    return dp[n];
}


void solve() {
    int n; cin >> n;

    memo(n);

    cout << dp[n] << endl;    
}

int main() {
    ios_base::sync_with_stdio(false);
    cin.tie(nullptr);

    for (int i = 0; i < 10; i++) {
        dp[i] = 1;
    }

    int t; cin >> t; while (t--) 
    solve();

    return 0;
}