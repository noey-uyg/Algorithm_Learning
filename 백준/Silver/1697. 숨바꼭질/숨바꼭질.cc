#include <bits/stdc++.h>
using namespace std;
//https://www.acmicpc.net/problem/1697

int point[100001];

int main(void) {
	ios::sync_with_stdio(false);
	cin.tie(NULL);
	cout.tie(NULL);

	fill(point, point + 100001, -1);

	int n, k;
	cin >> n >> k;

	point[n] = 0;

	queue<int> q;
	q.push(n);

	while (point[k] == -1) {
		int cur = q.front();
		q.pop();

		if (cur - 1 >= 0 && point[cur - 1] == -1) {
			point[cur - 1] = point[cur] + 1;
			q.push(cur - 1);
		}
		if (cur + 1 < 100001 && point[cur + 1] == -1) {
			point[cur + 1] = point[cur] + 1;
			q.push(cur + 1);
		}
		if (cur * 2 < 100001 && point[cur * 2] == -1) {
			point[cur * 2] = point[cur] + 1;
			q.push(cur * 2);
		}
	}

	cout << point[k];
}