class Solution {
    public int solve(List<int> A) {
        int val = A[0];
        
        foreach(var num in A){
            val = gcd(num, val);
        }
        return val == 1 ? 1: 0;
    }
    
    public int gcd(int a, int b){
        if(b == 0)
        return a;
        
        return gcd(b, a % b);
    }
}