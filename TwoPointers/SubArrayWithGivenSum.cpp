/*

Sub-array with given sum
Problem Description

Given an array of positive integers A and an integer B, find and return first continuous subarray which adds to B.

If the answer does not exist return an array with a single element "-1".

First sub-array means the sub-array for which starting index in minimum.

*/

vector<int> Solution::solve(vector<int> &a, int b) {
    long sum = 0;
    int l = 0;
    for(int r = 0; r < a.size(); r++) {
        sum += a[r];
        while(sum > b)  
            sum -= a[l++];
        if(sum == b) {
            vector<int> ans;
            for(int j = l; j <= r; j++) 
                ans.push_back(a[j]);
            return ans;
        }
    }
    vector<int> notfound;
    notfound.push_back(-1);
    return notfound;
}