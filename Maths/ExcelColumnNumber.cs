/*

Excel Column Number
Problem Description

Given a column title as appears in an Excel sheet, return its corresponding column number.

*/

class Solution {
    public int titleToNumber(string A) {
        int result = 0;
        
        for(int i = 0; i < A.Length; i++){
            result *= 26;
            result += A[i] - 'A' + 1;
        }
        return result;
    }
}
