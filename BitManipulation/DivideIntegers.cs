/*

Divide Integers
Problem Description

Divide two integers without using multiplication, division and mod operator.

Return the floor of the result of the division.

Also, consider if there can be overflow cases i.e output is greater than INT_MAX, return INT_MAX.

NOTE: INT_MAX = 2^31 - 1

*/

class Solution {
    public int divide(int A, int B) {
        long n = A, m = B;
        long sign = ((n < 0) ^ (m < 0)) ?  -1 : 1;
        
        n = Math.Abs(n);
        m = Math.Abs(m);
        
        long q = 0, temp = 0;
        
        for(int i = 31; i >=0; i--){
            if(temp + (m << i) <= n){
                temp += m << i;
                q |= 1LL << i;
            }
        }
        q = sign * q;
        return q >= int.MaxValue || q < int.MinValue ? int.MaxValue : (int)q;
    }
}