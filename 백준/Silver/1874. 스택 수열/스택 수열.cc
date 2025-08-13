#include <bits/stdc++.h>
using namespace std;
//https://www.acmicpc.net/problem/10773

int main(void) {
	ios::sync_with_stdio(false);
	cin.tie(NULL);
	cout.tie(NULL);

	int n;
	cin >> n;

	stack<int> s;
	int cur = 1;
	bool isImposible = false;
	string result = "";

	while (n--) {
		int a;
		cin >> a;

		while (cur <= a) {
			s.push(cur++);
			result += "+\n";
		}

		if (s.top() != a) {
			isImposible = true;
			break;
		}
		else {
			s.pop();
			result += "-\n";
		}
	}

	if (isImposible)cout << "NO";
	else cout << result;
}
