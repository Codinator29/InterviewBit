/*

Matrix Search
Problem Description

Given a matrix of integers A of size N x M and an integer B. Write an efficient algorithm that searches for integar B in matrix A.

This matrix A has the following properties:

Integers in each row are sorted from left to right.
The first integer of each row is greater than or equal to the last integer of the previous row.
Return 1 if B is present in A, else return 0.

NOTE: Rows are numbered from top to bottom and columns are numbered from left to right.

*/

class Solution {
    public int searchMatrix(List<List<int>> A, int B) {
        int rows = A.Count;
        int cols = A[0].Count;
        
        int l = 0, r = rows * cols - 1;
        
        while(l != r){
            int mid = (l + r - 1) >> 1; // Divide by 2
            
            if(A[mid/cols][mid % cols] < B){
                l = mid + 1;
            }
            else{
                r = mid;
            }
        }
        
        return A[r/cols][r%cols] == B ? 1 : 0;
        
        
    }
}