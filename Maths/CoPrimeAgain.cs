class Solution {
    public int solve(List<int> A, List<int> B, int C) {
        int n = A.Count;
        int m = B.Count;
        
        int count_a = 0, count_b = 0;
        
        for(int i = 0; i < n; i++){
            if(gcd(A[i], C) == 1){
                count_a++;
            }
        }
        
        for(int i = 0; i < m; i++){
            if(gcd(B[i], C) == 1){
                count_b++;
            }
        }
        
        int totalpairs = n * m;
        int coprimepairs = count_a * count_b;
        
        return (totalpairs - coprimepairs);
    }
    
    public int gcd(int A, int B){
        if(A == 0 && B == 0){
            throw new Exception("Invalid");
        }
        
        if(B == 0){
            return A;
        }
        
        return gcd(B, A % B);
    }
}