/*

Maximum height of staircase
Problem Description

Given an integer A representing the number of square blocks. The height of each square block is 1. The task is to create a staircase of max height using these blocks.

The first stair would require only one block, the second stair would require two blocks and so on.

Find and return the maximum height of the staircase.

*/

int Solution::solve(int A) {
    int stairs = 0;
    
    while(A != 0){
        if((stairs + 1) <= A){
            stairs++;
            A -= stairs;
        }
        else{
            break;
        }
    }
    return stairs;
}