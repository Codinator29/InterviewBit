/*
Matrix Median
Problem Description

Given a matrix of integers A of size N x M in which each row is sorted.

Find and return the overall median of the matrix A.

NOTE: No extra memory is allowed.

NOTE: Rows are numbered from top to bottom and columns are numbered from left to right.
*/

class Solution {
    public int findMedian(List<List<int>> A) {
        int r = A.Count;
        int c = A[0].Count;
        
        int min = int.MaxValue, max = int.MinValue;
        
        for(int i = 0; i < r; i++){
            if(A[i][0] < min){
                min = A[i][0];
            }
            
            if(A[i][c - 1] > max){
                max = A[i][c - 1];
            }
        }
        
        int desired = ( r * c + 1)/ 2;
        
        while(min < max){
            int mid = min + (max - min) / 2;
            int place = 0;
            
            for(int i = 0; i < r; i++){
                place += valCountLowerThanMid(A[i], mid);
            }
            
            if(place < desired){
                min = mid + 1;
            }else{
                max= mid;
            }
        }
        return min;
    }
    
    public int valCountLowerThanMid(List<int> A, int mid){
        return A.Count(x => x <= mid);
    }
}