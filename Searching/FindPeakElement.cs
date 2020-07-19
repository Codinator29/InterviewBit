/*
Find a peak element
Problem Description

Given an array of integers A, find and return the peak element in it. An array element is peak if it is NOT smaller than its neighbors.

For corner elements, we need to consider only one neighbor. We ensure that answer will be unique.

NOTE: Users are expected to solve this in O(log(N)) time.
*/

class Solution {
    public int solve(List<int> A) {
        return findPeak(A, 0 , A.Count - 1);
    }
    
    public static int findPeak(List<int> A, int low, int high){

        int mid = low + (high - low) / 2;

        if((mid == 0 || A[mid - 1] <= A[mid]) && (mid == high  || A[mid + 1] <= A[mid])){
            return A[mid];
        }
        
        else if(mid > 0 && A[mid -1] > A[mid]){
            return findPeak(A, low, mid - 1);
        }
        else{
            return findPeak(A, mid + 1, high);
        }
    }
}