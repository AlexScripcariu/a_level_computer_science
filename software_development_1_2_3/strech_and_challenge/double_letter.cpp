#include <bits/stdc++.h>
using namespace std;
// (O(n) TIME COMPLEXITY)

void solve() {
    string s; cin >> s;
    int n = s.size();

    cout << "start: " << s;
    string cur = "";
    
    for (int i = 0; i < n; i++) {
        cur += s[i];
        //cout << *(cur.end() - 1) << ' ' <<  *(cur.end() - 2) << '\n';
        while (cur.size() >= 2 && *(cur.end() - 1) == *(cur.end() - 2)) {
            cur = cur.substr(0, cur.size() - 2);
        }
    }
    cout << " | final string: " << cur << '\n'; 
}

int main() {
    ios_base::sync_with_stdio(false);
    cin.tie(nullptr);

    int t; cin >> t; while(t--)
    solve();

    return 0;
}