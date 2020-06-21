class Solution {
    public int solve(List<List<int>> A, int B) {
        int rows = A.Count;
        int cols = A[0].Count;
        int i = 0;
        int j = cols - 1;
        
        while(i < rows){
            while(j >= 0){
                
                if(i >= rows || j < 0){
                    return -1;
                }
                if(A[i][j] == B){
                    return (i + 1)*1009 + (j + 1);
                }
                
                if(A[i][j] < B){
                    i++;
                    continue;
                }
                
                if(A[i][j] > B){
                    j--;
                    continue;
                }
                
            }
        }
        return -1;
    }
}
