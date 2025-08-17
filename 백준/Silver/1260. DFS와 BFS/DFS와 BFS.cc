#include <bits/stdc++.h>

using namespace std;

int board[1001][1001];
int check[1001];
int n, m, v;

void Input() {
	cin >> n >> m >> v;

	for (int i = 0; i < m; i++) {
		int x, y;

		cin >> x >> y;

		board[x][y] = 1;
		board[y][x] = 1;
	}

}

void DFS(int temp) {
	stack<int> s;

	s.push(temp);

	check[temp] = 1;

	cout << temp << ' ';
	for (int i = 1; i <= n; i++) {
		if (board[temp][i] == 0 || check[i] == 1) continue;

		check[i] = 1;
		DFS(i);
	}
}

void BFS() {
	memset(check, 0, sizeof(check));
	queue<int> q;

	q.push(v);

	check[v] = 1;

	while (!q.empty()) {
		int cur = q.front();
		q.pop();

		cout << cur << ' ';

		for (int i = 1; i <= n; i++) {
			if (board[cur][i] == 0 || check[i] == 1) continue;

			check[i] = 1;
			q.push(i);
		}
	}
}



int main() {
	ios::sync_with_stdio(false);
	cin.tie(NULL);
	cout.tie(NULL);

	Input();
	DFS(v);
	cout << endl;
	BFS();

}