class Solution {
    public int solve(List<List<int>> A, int B) {
        int cols = A[0].Count;
        int rows = A.Count;
        
        int [] arr = new int[rows * cols];
        
        int mod = (A[0][0] % B + B) % B;
        
        for(int i = 0; i < rows; i++){
            for(int j = 0; j < cols; j++){
                arr[i * cols + j] = A[i][j];
                
                if((A[i][j]%B + B) % B != mod){
                    return -1;
                }
            }
        }
        
        Array.Sort(arr);
        
        int median = arr[(rows * cols)/ 2];
        
        int minOps = 0;
        
        for(int i = 0; i < rows * cols; i++){
            minOps += Math.Abs(arr[i] - median) / B;
        }
            //if even no of elements in matrix, then there are 2 medians
            
            if((rows * cols) % 2 == 0){
                int median2 = arr[(rows * cols)/2];
                int minOps2 = 0;
                
                for(int i = 0; i < rows * cols; i++){
                    minOps2 += Math.Abs(arr[i] - median2)/ B;
                }
                minOps = Math.Min(minOps, minOps2);
            }
        return minOps;
    }
}