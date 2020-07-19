/*

Unique Paths III
Problem Description

Given a matrix of integers A of size N x M . There are 4 types of squares in it:

1. 1 represents the starting square.  There is exactly one starting square.
2. 2 represents the ending square.  There is exactly one ending square.
3. 0 represents empty squares we can walk over.
4. -1 represents obstacles that we cannot walk over.
Find and return the number of 4-directional walks from the starting square to the ending square, that walk over every non-obstacle square exactly once.

Note: Rows are numbered from top to bottom and columns are numbered from left to right.

*/


int n, m, ans;
int xx[4] = {1, 0, 0, -1};
int yy[4] = {0, 1, -1, 0};

bool isV(int u, int v, vector<vector<int> > A) {
    return 0 <= u && u < n && 0 <= v && v < m && A[u][v] != -1;
}

void recur(int x, int y, int cnt, vector<vector<int> > A) {
    if(A[x][y] == 2) {
        if(cnt == 0)    ans++;
        return;
    }
    A[x][y] = -1;
    for(int i = 0; i < 4; i++) {
        int u = x + xx[i];
        int v = y + yy[i];
        if(isV(u, v, A)) {
            recur(u, v, cnt - 1, A);
        }
    }
    A[x][y] = 0;
}

int Solution::solve(vector<vector<int> > &A) {
        n = A.size();   m = A[0].size();
    ans = 0;
    int u = -1, v = -1, cnt = 0;
    for(int i = 0; i < n; i++) {
        for(int j = 0; j < m; j++) {
            if(A[i][j] == 1) {
                u = i;    v = j;
            } else if(A[i][j] == 0)    cnt++;
        }
    }
    assert(u != -1);
    recur(u, v, cnt + 1, A);
    return ans;   
}