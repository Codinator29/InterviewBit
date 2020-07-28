/*

Shaggy and distances
Problem Description

Shaggy has an array A consisting of N elements. We call a pair of distinct indices in that array as a special pair if elements at that index in the array are equal.

Shaggy wants you to find a special pair such that distance between that pair is minimum. Distance between two indices is defined as |i-j|. If there is no special pair in the array then return -1.

*/

class Solution {
    public int solve(List<int> A) {
        Dictionary<int, int> vals = new Dictionary<int, int>();
        int mindist = -1;
        
        for(int i = 0; i < A.Count; i++){
            if(!vals.ContainsKey(A[i])){
                vals.Add(A[i], i);
                continue;
            }
            
            if(mindist == -1){
                mindist = Math.Abs(vals[A[i]] - i);
            }
            else{
                mindist = Math.Min(mindist, Math.Abs(vals[A[i]] - i));
            }
            //vals[A[i]] = i;
        }
        
        return mindist;
    }
}