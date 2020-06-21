class Solution {
    public List<int> solve(int A, List<int> B) {
        
        if(A < 1 || A > 100000){
            throw new Exception("Out of Limits");
        }
        int i, j;
        List<int> prime = new List<int>(1000010);
        List<int> count = new List<int>(1000010);
        
        for(i = 0; i < 1000010; i++){
            prime.Add(1);
            count.Add(0);
        }
 
        prime[0] = prime[1] = 0;
        for(i = 2; i < 1000000; i++){
            if(prime[i] == 1){
                int c = 1;
                
                for(j = i + i; j <= 1000000; j+=i){
                    if(prime[j] == 1){
                        c++;
                    }
                    prime[j] = 0;
                }
                count[i] = c;
            }
        }
        
        List<int> ans = new List<int>();
        for(i = 0; i < A; i++){
            ans.Add(count[B[i]]);
        }
        return ans;
    }
}