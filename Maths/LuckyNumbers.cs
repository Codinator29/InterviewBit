class Solution {
    public int solve(int A) {
        List<bool> isPrime = Enumerable.Repeat(true, 5001).ToList();
        List<int> count = Enumerable.Repeat(0, 5001).ToList();
        
        isPrime[1] = false;
        
        for(int i = 2; i <=5000; i++){
            if(isPrime[i]){
                for(int j = i + i; j <= 5000; j+= i){
                    isPrime[j] = false;
                }
            }
        }
        
        for(int i = 1; i <= 5000; i++){
            for(int j = 1; j <= 5000; j++){
                if(isPrime[j] && i % j == 0){
                    count[i]++;
                }
            }
        }
        int ans = 0;
        
        for(int i = 1; i <= A; i++){
            if(count[i] == 2){
                ans++;
            }
        }
        return ans;
        
    }
}