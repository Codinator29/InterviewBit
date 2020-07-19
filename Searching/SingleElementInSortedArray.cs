/*
Single Element in a Sorted Array
Problem Description

Given a sorted array of integers A where every element appears twice except for one element which appears once, find and return this single element that appears only once.

NOTE: Users are expected to solve this in O(log(N)) time.
*/
class Solution {
    public int solve(List<int> A) {
        int low = 0;
        int high = A.Count - 1;
        int mid = 0;
        
        while(low <= high){
            mid = (low + high) / 2;
            
            if(low == high){
                return A[low];
            }
            
            if(mid % 2 == 0){
                if(A[mid] == A[mid + 1]){
                    low = mid + 2;
                }else{
                    high = mid;
                }
                
            }
            else if(mid % 2 == 1){
                if(A[mid] == A[mid - 1]){
                    low = mid + 1;
                }else{
                    high = mid - 1;
                }
            }
            
        }
        return A[mid];
    }
}