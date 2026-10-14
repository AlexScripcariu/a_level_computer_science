#include <bits/stdc++.h>
using namespace std;

void solve() {
    int n; cin >> n;

    int cnt = 0;
    set<int> vals;
    while (!vals.count(n)) {
        vals.insert(n)
        int a = 0;
        while (n > 0) {
            a += (n % 10) * (n % 10);
            n /= 10;
        }
        
        n = a;
        cnt++;
    }

    cout << "found" << n << " in loop after " << cnt << " iterations" << '\n';
}


int main() {
    
    ios_base::sync_with_stdio(false);
    cin.tie(nullptr);

    int t; cin >> t; while (t--)
    solve();
}