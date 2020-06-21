class Solution {
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