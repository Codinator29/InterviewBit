class Solution {
    public List<int> solve(List<int> A) {
        List<int> prime = new List<int>(1000005);
        
        for(int i = 0; i <=1000000; i++){
            prime.Add(i);
        }
        
        for(int i = 2; i*i <= 1000000; i++){
            if(prime[i] ==i){
                
                for(int j = i*i; j <= 1000000; j+=i){
                    if(prime[j] == j){
                        prime[j] = i;
                    }
                }
            }
        }
        
        List<int> solution = new List<int>();
        
        for(int i = 0; i < A.Count; i++){
            int temp = A[i];
            int ans = 1;
            
            while(temp != 1){
                int count = 1;
                int d = prime[temp];
                
                while(temp != 1 && temp % d == 0){
                    count++;
                    temp = temp / d;
                }
                ans = ans * count;
            }
            solution.Add(ans);
        }
        return solution;
    }
}