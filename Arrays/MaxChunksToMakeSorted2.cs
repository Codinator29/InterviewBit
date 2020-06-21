class Solution {
    public int solve(List<int> A) {

       List<int> min = new List<int>(A.Count);
       int max = int.MinValue;
       int count = 0;
       
       for(int i = 0; i < A.Count; i++)
       {
           min.Add(0);
       }
       
       for(int i = A.Count - 1; i >= 0; i--)
       {
           min[i]= i==A.Count - 1 ? A[i] :Math.Min(A[i],min[i+1]);
       }
       
       for(int i = 0; i < A.Count ; i++)
       {
           max= i==0 ? A[i]: Math.Max(max,A[i-1]);
           int realmax = i == 0? int.MinValue : max;
           
           if(min[i] >= realmax) 
           {
               count++;
           }
       }
       return count;
    }
}
