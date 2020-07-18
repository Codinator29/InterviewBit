// Grid Unique Paths
class Solution {
    public int uniquePaths(int A, int B) {
    int path = 1;
      
     for(int i = Math.Max(A, B); i < (A + B - 1); i++){
          path *= i;
          path /= (i - Math.Max(A, B) + 1);
     }
      
      return path;
    }
}