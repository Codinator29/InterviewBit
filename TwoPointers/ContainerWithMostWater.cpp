/*

Container With Most Water
Problem Description

Given n non-negative integers A[0], A[1], ..., A[n-1] , where each represents a point at coordinate (i, A[i]).

N vertical lines are drawn such that the two endpoints of line i is at (i, A[i]) and (i, 0).

Find two lines, which together with x-axis forms a container, such that the container contains the most water.

Note: You may not slant the container.

*/

int Solution::maxArea(vector<int> &A) {
    
    int l = 0;
    int r = A.size() - 1;
    int area = 0;
    
    while(l < r){
        area = max(area, min(A[l], A[r]) * (r - l));
        
        if(A[l] < A[r]){
            l++;
        }
        else{
            r--;
        }
        
    }
    return area;
}
