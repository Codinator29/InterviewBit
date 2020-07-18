/*

Single Number
Problem Description

Given an array of integers A, every element appears twice except for one. Find that single one.

NOTE: Your algorithm should have a linear runtime complexity. Could you implement it without using extra memory?

*/

class Solution {
    public int singleNumber(List<int> A) {
        int num = 0;
        
        for(int i = 0; i < A.Count; i++){
            num = num ^ A[i];
        }
        
        return num;
    }
}