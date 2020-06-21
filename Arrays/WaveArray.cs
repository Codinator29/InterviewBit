class Solution {
    public List<int> wave(List<int> A) {
        A.Sort();
        
        for(int i = 0; i < A.Count - 1; i = i + 2){
            var temp = A[i];
            A[i] = A[i + 1];
            A[i + 1] = temp;
        }
        return A;
    }
}