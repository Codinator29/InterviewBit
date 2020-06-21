class Solution {
    public int solve(List<List<int>> A) {
        int sum = 0;
        int len = A[0].Count;
        
        for(int i = 0; i < len; i++){
            for(int j = 0; j < len; j++){
                int topLeft = (i + 1) * (j + 1);
                int bottomRight = (len - i) * (len - j);
                
                sum += topLeft * bottomRight * A[i][j];
            }
        }
        return sum;
    }
}
