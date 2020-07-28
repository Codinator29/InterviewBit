/*

Sum the Difference
Problem Description

Given an integer array A of size N.
You have to find all possible non-empty subsequence of the array of numbers and then, for each subsequence, find the difference between the largest and smallest numbers in that subsequence Then add up all the differences to get the number.

As the number may be large, output the number modulo 1e9 + 7 (1000000007).

NOTE: Subsequence can be non-contiguous.

*/

class Solution {
    public long solve(List<int> A) {
        long max = 0;
        long min = 0;
        long mod = 1000000007;
        
        int n = A.Count;
        A.Sort();
        
        for(int i = 0; i < n; i++){
            min = (min * 2) % mod;
            min = (min + A[i]) % mod;
        }
        
        for(int i = n - 1; i >=0; i--){
            max = (max * 2) % mod;
            max = (max + A[i]) % mod;
        }
        
        return (max - min + mod) % mod;
    }
}