/*

Allocate Books
Problem Description

Given an array of integers A of size N and an integer B.

College library has N books,the ith book has A[i] number of pages.

You have to allocate books to B number of students so that maximum number of pages alloted to a student is minimum.

A book will be allocated to exactly one student.
Each student has to be allocated at least one book.
Allotment should be in contiguous order, for example: A student cannot be allocated book 1 and book 3, skipping book 2.
Calculate and return that minimum possible number.



NOTE: Return -1 if a valid assignment is not possible.

*/

class Solution {
    public int books(List<int> A, int B) 
    {
        var noOfBooks = A.Count;
        
        if(noOfBooks < B)
        {
            return -1;
        }
        

        var start = 0;
        var end = A.Sum();
        int result = int.MaxValue;
        
        while(start <= end)
        {
            int mid = (start + end) >> 1;
            
            if(isPossible(A, B, mid))
            {
                result = Math.Min(result, mid);
                
                end = mid - 1;
            }
            else
            {
                start = mid + 1;
            }
        }
        
        return result;
    }
    
    public static bool isPossible(List<int> A, int B, int mid){
        int studentCount = 1;
        int sum = 0;
        
        for(int i = 0; i < A.Count; i++)
        {
            if(A[i] > mid)
            {
                return false;
            }
            
            if(sum + A[i] > mid)
            {
                studentCount++;
                
                sum = A[i];
                
                if(studentCount > B){
                    return false;
                }
            }
            else
            {
                sum += A[i];
            }
        }
        return true;
    }
}