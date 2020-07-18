/*

Xor queries
Problem Description

You are given an array A (containing only 0 and 1) as element of N length.
Given L and R, you need to determine value of XOR of all elements from L to R (both inclusive) and number of unset bits (0's) in the given range of the array.

*/

class Solution {
    public List<List<int>> solve(List<int> A, List<List<int>> B) {
        //prefix sum array to get the number of 1's
        
        List<int> a = Enumerable.Repeat(0, A.Count + 1).ToList();
        
        for(int i = 1; i <= A.Count; i++){
            a[i] = A[i - 1];
            a[i] += a[i - 1];
        }
        
        List<List<int>> ans = new List<List<int>>();
        
        for(int i = 0; i < B.Count; i++){
            List<int> temp = new List<int>();
            int l, r, xor = 0, ones;
            l = B[i][0];
            r = B[i][1];
            
            ones = a[r] - a[l - 1];
            
            //if no of ones is odd then xor is 1
            if((ones & 1) > 0){
                xor = 1;
            }
            
            temp.Add(xor);
            temp.Add(r - l + 1 - ones);
            ans.Add(temp);
        }
        return ans;
    }
}