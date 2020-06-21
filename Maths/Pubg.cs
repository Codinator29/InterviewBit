class Solution {
    public int solve(List<int> A) {
        if(A.Count == 1){
            return A[0];
        }

        int temp = A[0];
        
        for(int i = 1; i < A.Count; i++){
            temp = gcd(temp, A[i]);
        }
        
        return temp;
    }
    
    public int gcd(int A, int B) {
        if(A==0 && B==0){
            throw new Exception("GCD doesn't exist for 0 & 0");
        }
        if(B==0){
            return A;
        }
        return gcd(B, A%B);
    }
}