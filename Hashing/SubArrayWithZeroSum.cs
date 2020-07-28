/*

Sub-array with 0 sum
Problem Description

Given an array of integers A, find and return whether the given array contains a non-empty subarray with a sum equal to 0.

If the given array contains a sub-array with sum zero return 1 else return 0.

*/

class Solution {
    public int solve(List<int> A) {
        HashSet<long> vals = new HashSet<long>();
        
        int found = 0;
        
        long sum = 0;
        
        for(int i = 0; i < A.Count; i++){
            sum += A[i];
            
            if(vals.Contains(sum) || sum == 0){
                found = 1;
                break;
            }
            vals.Add(sum);
        }
        
        return found;
    }
}