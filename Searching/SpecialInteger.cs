/*

Special Integer
Problem Description

Given an array of integers A and an integer B, find and return the maximum value K such that there is no subarray in A of size K with sum of elements greater than B.

*/

class Solution {
    public int solve(List<int> A, int B) {
        int l = 1, r = A.Count;
        
        while(l <= r){
            int m = (l + r) >> 1;
            
            if(check(A, B, m)){
                l = m + 1;
            }else{
                r = m - 1;
            }
        }
        return l - 1;
    }
    
    public bool check(List<int> A, int B, int m){
        long s = 0;
        
        // Left side of Mid
        for(int i = 0; i < m; i++){
            s += A[i];
        }
        
        if(s > B){
            return false;
        }
        
        // Right side of Mid
        for(int i = m; i < A.Count; i++){
            s+= A[i] - A[i - m];
            
            if(s > B){
                return false;
            }
        }
        
        return true;
    }
}