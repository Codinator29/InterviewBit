/*

All Unique Permutations
Problem Description

Given an array A of size N denoting collection of numbers that might contain duplicates, return all possible unique permutations.

NOTE: No 2 entries in the permutation sequence should be the same.

WARNING: DO NOT USE LIBRARY FUNCTION FOR GENERATING PERMUTATIONS.

*/

class Solution {
    public List<List<int>> permute(List<int> A) {
        List<List<int>> result = new List<List<int>>();
        
        if(A == null || !A.Any()){
            return result;
        }
        
        permute(result, A, 0);
        return result;
    }
    
    public void permute(List<List<int>> result, List<int> A, int index){
        if(index == A.Count){
            List<int> temp = new List<int>(A);
            result.Add(temp);
            return;
        }
        var exists = new HashSet<int>();
        
        for(int i = index; i < A.Count; i++){
            if(exists.Add(A[i])){
                swap(A, index, i);
                permute(result, A, index + 1);
                swap(A, index, i);
            }
        }
    }
         public static void swap(List<int> A, int i, int k)
        {
            int temp = A[i];
            A[i] = A[k];
            A[k] = temp;
        }
    
}