/*

Min XOR value
Problem Description

Given an integer array A of N integers, find the pair of integers in the array which have minimum XOR value. Report the minimum XOR value.

*/

class Solution {
    public int findMinXor(List<int> A) {
        A.Sort();
        
        int minXor = A[0] ^ A[1];
        
        for(int i = 1; i < A.Count - 1; i++){
            var xor = A[i] ^ A[i + 1];
            
            if(xor < minXor){
                minXor = xor;
            }
        }
        
        return minXor;
    }
}