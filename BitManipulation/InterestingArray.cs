/*

Interesting Array
Problem Description

You have an array A with N elements. We have 2 types of operation available on this array :
We can split a element B into 2 elements C and D such that B = C + D.
We can merge 2 elements P and Q as one element R such that R = P^Q i.e XOR of P and Q.
You have to determine whether it is possible to make array A containing only 1 element i.e. 0 after several splits and/or merge?

*/

class Solution {
    public string solve(List<int> A) {
        int count = 0;
        
        for(int i = 0; i < A.Count; i++){
            if(A[i] % 2 == 1){
                count++;
            }
        }
        
        return count % 2 == 1 ? "No" : "Yes";
    }
}