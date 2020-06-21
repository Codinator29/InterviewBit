class Solution {
    public List<int> primesum(int A) {
        //int maxNum = 20000001;
        List<bool> isPrime = Enumerable.Repeat(true, A).ToList();
        isPrime[0] = isPrime[1] = false;
        
        for(int i = 2; i * i < A; i++){
            if(isPrime[i]){
                for(int j = i * i; j < A; j += i){
                    isPrime[j] = false;
                }
            }
        }
        
        List<int> primeSum = new List<int>();
        for(int i = 0; i < A; i++){
            if(isPrime[i] && isPrime[A - i]){
                primeSum.Add(i);
                primeSum.Add(A - i);
                break;
            }
        }
        
        return primeSum;
    }
}