/*

Count of pairs with the given sum
Given a sorted array of distinct integers A and an integer B, find and return how many pair of integers ( A[i], A[j] ) such that i != j have sum equal to B.

*/

int Solution::solve(vector<int> &A, int B) {
    int ans = 0;
    int sum = 0;
    int l = 0;
    int r = A.size() - 1;
    
    while(l < r){
        sum = A[l] + A[r];
        
        if(sum == B){
            ans++;
            l++;
            r--;
        }
        
        else if(sum > B){
            r--;
        }
        else{
            l++;
        }
    }
    return ans;
}