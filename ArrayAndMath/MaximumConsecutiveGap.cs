class Solution {
    public int maximumGap(List<int> A) {
        if(A.Count < 2){
            return 0;
        }
        A.Sort();
        int max = 0;
        
        for(int i = 0; i < A.Count - 1; i++){
            int diff = A[i + 1] - A[i];
            
            if(diff > max){
                max = diff;
            }
        }
        
        return max;
    }
}