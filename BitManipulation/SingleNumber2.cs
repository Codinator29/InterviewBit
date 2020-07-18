/*

Single Number II
Problem Description

Given an array of integers, every element appears thrice except for one which occurs once.

Find that element which does not appear thrice.

NOTE: Your algorithm should have a linear runtime complexity.

Could you implement it without using extra memory?

*/

class Solution {
    public int singleNumber(List<int> A) {
        int num = 0;
        
        for(int i = 0; i < 32; i++){
            int setsum = 0;
            for(int j = 0; j < A.Count; j++){
                if((A[j] & (1 << i)) > 0)
                {
                    setsum++;
                }
            }
            
            if(setsum % 3 != 0){
                num = num | (1 << i);
            }
        }
        return num;
    }
}