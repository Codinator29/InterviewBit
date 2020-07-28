/*

Count Right Triangles
Problem Description

Given two arrays of integers A and B of size N each, where each pair (A[i], B[i]) for 0 <= i < N represents a unique point (x, y) in 2D Cartesian plane.

Find and return the number of unordered triplets (i, j, k) such that (A[i], B[i]), (A[j], B[j]) and (A[k], B[k]) form a right angled triangle with the triangle having one side parallel to the x-axis and one side parallel to the y-axis.

NOTE: The answer may be large so return the answer modulo (109 + 7).

*/

map<int, int> mp[2];

int Solution::solve(vector<int> &a, vector<int> &b) {
    int n = a.size();
    mp[0].clear();  mp[1].clear();
	for(int i = 0; i < n; i++) {
	    mp[0][a[i]]++;
	    mp[1][b[i]]++;
	}

	long ans = 0, mod = (long)(1e9 + 7);
	for(int i = 0; i < n; i++) {
		ans = (ans + 1L * (mp[0][a[i]] - 1L) * (mp[1][b[i]] - 1L) ) % mod;
	}
	return (int)ans;
}