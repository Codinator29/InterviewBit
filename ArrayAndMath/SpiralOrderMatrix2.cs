    public List<List<int>> generateMatrix(int A) {
        List<List<int>> matrix = new List<List<int>>(A);
        
        for(int x =0; x < A;x++){
            matrix.Add(new List<int>(A));
        }
        
        for(int i = 0; i < A; i++){
            for(int j = 0; j < A; j++){
                matrix[i].Add(0);
            }
        }
        
        int num = 1;
        int top = 0, bottom = A - 1, left = 0, right = A -1;
        int dir = 1;
        
        while(top <= bottom && left <= right){
            if(dir == 1){
                for(int i = left; i <=right; ++i){
                    matrix[top][i] = num++;
                }
                ++top;
                dir = 2;
            }
            
            else if(dir == 2){
                for(int i = top; i <=bottom; i++){
                    matrix[i][right] = num++;
                }
                --right;
                dir = 3;
            }
            
            else if(dir == 3){
                for(int i = right; i >= left; --i){
                    matrix[bottom][i] = num++;
                }
                dir = 4;
                --bottom;
            }
            else if(dir == 4){
                for(int i = bottom; i >= top; --i){
                    matrix[i][left] = num++;
                }
                ++left;
                dir =1;
            }
        }
        return matrix;
    }
    
}
