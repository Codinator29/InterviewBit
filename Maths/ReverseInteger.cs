/*

Reverse integer
Problem Description

You are given an integer N and the task is to reverse the digits of the given integer. Return 0 if the result overflows and does not fit in a 32 bit signed integer

*/


class Solution {
    public int reverse(int A) {
        int num = 0;
        bool isNegative = false;
        
        if(A < 0){
            isNegative = true;
            A *= -1;
        }
        
        while(A > 0){
            if(num > int.MaxValue / 10 || num > (int.MaxValue - (A % 10))){
                return 0;
            }
            var digit = A % 10;
            num = num * 10 + digit;
            A /= 10;
        }
        
        return isNegative ? num * -1 : num;
    }
}
