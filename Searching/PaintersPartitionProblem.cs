/*

Painter's Partition Problem
Problem Description

Given 2 integers A and B and an array of integers C of size N. Element C[i] represents length of ith board.
You have to paint all N boards [C0, C1, C2, C3 … CN-1]. There are A painters available and each of them takes B units of time to paint 1 unit of board.

Calculate and return minimum time required to paint all boards under the constraints that any painter will only paint contiguous sections of board.
NOTE:
1. 2 painters cannot share a board to paint. That is to say, a board cannot be painted partially by one painter, and partially by another.
2. A painter will only paint contiguous boards. Which means a configuration where painter 1 paints board 1 and 3 but not 2 is invalid.

Return the ans % 10000003.


*/

class Solution {
    public long paint(int A, int B, List<int> C) {
        int max = C.Max();
        int sum = C.Sum();
        
        long low = max;
        long high = sum;
        
        while(low <= high){
            var mid = (low + high) >> 1;
            
            var requiredPainters = numberOfPainters(C , mid);
            
            if(requiredPainters <= A){
                high = mid - 1;
            }
            else{
                low = mid + 1;
            }
        }
        return ((low % 10000003) * (B % 10000003)) % 10000003;
    }
    
    public int numberOfPainters(List<int> A, long mid){
        int total = 0, painters = 1;
        
        for(int i = 0; i < A.Count; i++){
            total += A[i];
            
            if(total > mid){
                total = A[i];
                painters++;
            }
        }
        return painters;
    }
}