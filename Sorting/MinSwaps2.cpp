/*

Minimum Swaps 2
Problem Description

Given an array of integers A of size N that is a permutation of [0, 1, 2, ..., (N-1)]. It is allowed to swap any two elements (not necessarily consecutive).

Find the minimum number of swaps required to sort the array in ascending order.

*/

int Solution::solve(vector<int> &A) {
    int ans = 0;
    
    for(int i = 0; i < A.size(); i++){
        while(A[i] != i){
            ans++;
            swap(A[i], A[A[i]]);
        }
    }
    return ans;
}