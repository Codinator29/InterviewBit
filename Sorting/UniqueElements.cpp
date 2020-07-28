/*

Unique Elements
Problem Description

You are given an array A of N elements. You have to make all elements unique, to do so in one step you can increase any number by one.

Find the minimum number of steps.

*/

int Solution::solve(vector<int> &A) {
    int n = A.size();
    // sort the array
    sort(A.begin(), A.end());
    // initialize variables
    int steps = 0, i = 1, j = 0;
    // loop until you reach the end
    while(j < n) {
        // make current element unique
        if(i >= A[j]) {
            steps += (i - A[j++]);
        }
        i += 1;
    }
    // return the answer
    return steps;
}