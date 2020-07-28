/*

Longest Consecutive Sequence
Problem Description

Given an unsorted integer array A of size N.

Find the length of the longest set of consecutive elements from the array A.

*/

class Solution {
    public int longestConsecutive(List<int> A) {
        HashSet<int> set = new HashSet<int>();
        
        for(int i = 0; i < A.Count; i++){
            set.Add(A[i]);
        }
        
        int count = 0;
        
        for(int i = 0; i < A.Count; i++){
             int innerCount = 1;
            if(!set.Contains(A[i] - 1)){
                while(set.Contains(++A[i])){
                    innerCount++;
                }
            }
            
            count = Math.Max(count, innerCount);
        }
        
        return count;
    }
}