/*

MAXIMUM AND MINIMUM MAGIC
Problem Description

Given an array of integers A of size N where N is even.

Divide the array into two subsets such that

1.Length of both subset is equal.
2.Each element of A occurs in exactly one of these subset.
Magic number = sum of absolute difference of corresponding elements of subset.

Note: You can reorder the position of elements within the subset to find the value of magic number.

For Ex:- 
subset 1 = {1, 5, 1}, 
subset 2 = {1, 7, 11}
Magic number = abs(1 - 1) + abs(5 - 7) + abs(1 - 11) = 12
Return an array B of size 2, where B[0] = maximum possible value of Magic number modulo 109 + 7, B[1] = minimum possible value of a Magic number modulo 109 + 7.

*/

#define ll long long
#define mod 1000000007
vector<int> Solution::solve(vector<int> &A) {
    int n = A.size();
    sort(A.begin(),A.end());
    ll mins=0,maxs=0;
    for(int i=1;i<n;i+=2)
        mins+=(ll)(A[i]-A[i-1]);
    for(int i=0;i<n/2;i++)
        maxs+=(ll)(A[n-1-i]-A[i]);
    vector <int> ans(2);
    ans[0] = maxs % mod;
    ans[1] = mins % mod;
    return ans;
}