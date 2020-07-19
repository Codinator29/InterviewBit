/*

Square Root of Integer
Problem Description

Given an integer A.

Compute and return the square root of A.

If A is not a perfect square, return floor(sqrt(A)).

DO NOT USE SQRT FUNCTION FROM STANDARD LIBRARY.

NOTE: Do not use sort function from standard library. Users are expected to solve this in O(log(A)) time.

*/

class Solution {
    public int sqrt(int A) {
        if(A == 0 || A == 1){
            return A;
        }
        
        long start = 1, end = A, root = 0;
        
        while(start <= end)
        {

            var mid = (start + end) >> 1;
            
            if(mid * mid == A){
                return (int)mid;
            }
            
            if(mid * mid < A){
                start = mid + 1;
                root = mid;
            }else{
                end = mid - 1;
            }
        }
        return (int)root;
    }
}