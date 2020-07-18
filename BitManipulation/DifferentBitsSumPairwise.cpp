/*

Different Bits Sum Pairwise
Problem Description

We define f(X, Y) as number of different corresponding bits in binary representation of X and Y.
For example, f(2, 7) = 2, since binary representation of 2 and 7 are 010 and 111, respectively. The first and the third bit differ, so f(2, 7) = 2.

You are given an array of N positive integers, A1, A2 ,..., AN. Find sum of f(Ai, Aj) for all pairs (i, j) such that 1 ≤ i, j ≤ N. Return the answer modulo 109+7.

*/

typedef long long LL;
#define MOD 1000000007ll
int Solution::cntBits(vector<int> &A) {
    int ans=0,n=A.size();

    //traverse over all bits
    for(int i=0; i<31; i++){

        //count number of elements with ith bit = 0
        LL cnt=0;
        for(int j=0; j<n; j++)
            if((A[j]&(1<<i)))
                cnt++;

        //add to answer cnt*(n-cnt)*2
        ans += (cnt*((LL)n-cnt)*2)%MOD;
        if(ans>=MOD)
            ans-=MOD;

    }

    return ans;
}