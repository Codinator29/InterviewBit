/*

Excel Column Title
Problem Description

Given a positive integer A, return its corresponding column title as appear in an Excel sheet.

For example:

    1 -> A
    2 -> B
    3 -> C
    ...
    26 -> Z
    27 -> AA
    28 -> AB 

*/

class Solution {
    public string convertToTitle(int A) {
        string result = string.Empty;

        while(A > 0){
            var digit = (A - 1)% 26;
            result = Convert.ToChar(65 + digit).ToString() + result;
            A = (A - digit) / 26;
        }
        return result;
    }
}