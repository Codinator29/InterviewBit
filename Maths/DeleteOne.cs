class Solution {
    public int solve(List<int> A) {
        List<int> prefixList = new List<int>();
        List<int> postfixList = new List<int>(A.Count);
        List<int> gcdList = new List<int>();
        
        for(int i = 0; i < A.Count; i++){
            postfixList.Add(1);
        }
        prefixList.Add(A[0]);
        for(int i = 1; i < A.Count; i++){
            prefixList.Add(gcd(prefixList[i-1], A[i]));
        }
        
        postfixList[A.Count - 1] = A[A.Count - 1];
        
        for(int i = A.Count - 2; i >= 0 ;i--){
            postfixList[i]= gcd(A[i], postfixList[i + 1]);
        }
        
        for(int i = 0; i < A.Count; i++){
            if(i == 0){
                gcdList.Add(postfixList[i + 1]);
            }
            else if(i == A.Count - 1){
                gcdList.Add(prefixList[i - 1]);
            }
            else{
                gcdList.Add(gcd(prefixList[i - 1], postfixList[i + 1]));
            }
        }

        var max = gcdList[0];
        for(int i = 1; i < gcdList.Count; i++){
            if(gcdList[i] > max){
                max = gcdList[i];
            }
        }
        
        return max;
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
