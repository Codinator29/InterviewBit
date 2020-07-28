/*

Alternate positive and negative elements
Problem Description

Given an array of integers A, arrange them in an alternate fashion such that every non-negative number is followed by negative and vice-versa, starting from a negative number, maintaining the order of appearance. The number of non-negative and negative numbers need not be equal.

If there are more non-negative numbers they appear at the end of the array. If there are more negative numbers, they too appear at the end of the array.

Note: Try solving with O(1) extra space.

*/

void rightRotate(vector<int> &a, int n, int op, int c) { 
    int t = a[c]; 
    for (int i = c; i > op; i--)    
        a[i] = a[i - 1]; 
    a[op] = t; 
} 

void rearrange(vector<int> &a, int n) { 
    int op = -1;
    for (int ind = 0; ind < n; ind++) { 
        if (op >= 0) {
            if ( (a[ind] >= 0 && a[op] < 0) || (a[ind] < 0 && a[op] >= 0)) { 
                rightRotate(a, n, op, ind); 
                if (ind - op > 2)   
                    op = op + 2; 
                else    
                    op = -1; 
            } 
        }  
        if (op == -1) {  
            if ((a[ind] >= 0 && (ind & 1) == 0) || (a[ind] < 0 && (ind & 1) == 1)) 
                op = ind; 
        } 
    } 
}

vector<int> Solution::solve(vector<int> &A) {
    rearrange(A, A.size());
    return A;
}