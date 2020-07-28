/*

Pairs with given sum II
Problem Description

Given a sorted array of integers (not necessarily distinct) A and an integer B, find and return how many pair of integers ( A[i], A[j] ) such that i != j have sum equal to B.

Since the number of such pairs can be very large, return number of such pairs modulo (109 + 7).

*/

const int MOD = 1000000007;

int Solution::solve(vector<int> &A, int B) {
    int n=A.size();
    unordered_map<long long,long long> mp;
    long long ans=0;
    for(int i=0; i<n; ++i){
        int y=B-A[i];
        if(mp.find(y)!=mp.end()){
            ans+=mp[y];
            while(ans>=MOD)
                ans-=MOD;
        }
        ++mp[A[i]];
    }
    assert(ans>=0&&ans<MOD);
    return (int)(ans);
}