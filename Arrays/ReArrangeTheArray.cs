class Solution {
    public List<int> solve(List<int> A) {
        var newList = new List<int>(A.Count);
        
        for(int i = 0; i < A.Count; i++){
            newList.Add(-1);
        }
        
        for(int j = 0; j < A.Count; j++){
           newList[A[j]] = j;
        }
        
        return newList;
    }
}
