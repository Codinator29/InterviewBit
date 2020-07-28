/*

Max Chunks To Make Sorted
Problem Description

Given an array of integers A of size N that is a permutation of [0, 1, 2, ..., (N-1)], if we split the array into some number of "chunks" (partitions), and individually sort each chunk. After concatenating them, the result equals the sorted array.

What is the most number of chunks we could have made?

*/

int Solution::solve(vector<int> &A) {
    int n = A.size();
    
    int ans = 0, maxsofar = 0;
    
    for(int i = 0; i < n; i++){
        maxsofar = max(maxsofar, A[i]);
        
        if(maxsofar == i){
            ans++;
        }
    }
    return ans;
}