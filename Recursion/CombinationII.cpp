/*

Combination Sum II
Problem Description

Given an array of size N of candidate numbers A and a target number B. Return all unique combinations in A where the candidate numbers sums to B.

Each number in A may only be used once in the combination.

Note:

All numbers (including target) will be positive integers.
Elements in a combination (a1, a2, … , ak) must be in non-descending order. (ie, a1 ≤ a2 ≤ … ≤ ak).
The solution set must not contain duplicate combinations.
Warning:

DO NOT USE LIBRARY FUNCTION FOR GENERATING COMBINATIONS.

*/

void recur(vector<int> &A, int B,vector<int> v, vector<vector<int>> &ans, int sum, int index){
    if(sum > B)
        return;
    if(sum == B)
    {
        ans.push_back(v);
        return;
    }
    for(int i = index; i < A.size(); ++i)
    {
        v.push_back(A[i]);
        recur(A, B, v, ans, sum + A[i], i+1);
        v.pop_back();
    }
    return;
}

vector<vector<int> > Solution::combinationSum(vector<int> &A, int B) {
    // Do not write main() function.
    // Do not read input, instead use the arguments to the function.
    // Do not print the output, instead return values as specified
    // Still have a doubt. Checkout www.interviewbit.com/pages/sample_codes/ for more details
    vector<int> v;
    vector<vector<int>> ans;
    sort(A.begin(), A.end());
    recur(A, B, v, ans, 0, 0);
    for(auto &x: ans)
    {
        sort(x.begin(), x.end());
    }
    set<vector<int>> s(ans.begin(), ans.end());
    vector<vector<int>> temp(s.begin(), s.end());
    
    return temp;
}