/*

Another Count Rectangles
Problem Description

Given a sorted array of distinct integers A and an integer B, find and return how many rectangles with distinct configurations can be created using elements of this array as length and breadth whose area is lesser than B.

(Note that a rectangle of 2 x 3 is different from 3 x 2 if we take configuration into view)

*/

int Solution::solve(vector<int> &a, int b) {
    long ans = 0, mod = (long)(1e9 + 7);
        int l = 0, r = a.size() - 1;
        while(l < a.size() && r >= 0) {
            if(1L * a[l] * a[r] < b) {
                ans = (ans + r + 1) % mod;
                l++;
            } else  r--;
        }
        return (int)ans;
}