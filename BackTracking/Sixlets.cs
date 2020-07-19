/*

SIXLETS
Problem Description

Given a array of integers A of size N and an integer B.

Return number of non-empty subsequences of A of size B having sum <= 1000.

*/

class Solution {
    int ans;
    public int solve(List<int> A, int B) {
        int n = A.Count;
        ans = 0;
        getAns(A, B, 0, 0, 0);
        return ans;
    }
    
    public void getAns(List<int> A, int B, int size, int sum, int index){
        if(sum > 1000){
            return;
        }
        
        if(size == B){
            if(sum <= 1000){
                ans++;
            }
            return;
        }
        
        if(index == A.Count){
            return;
        }
        for(int i = index; i < A.Count; i++){
            getAns(A, B, size + 1, sum + A[i], i + 1);
        }
    }
}