/*

Game of Bottles
Problem Description

Given an array of integers A of size N which denotes N cylindrical empty bottles. The radius of the ith bottle is A[i].
You can put the ith bottle into the jth bottle if the following conditions are met:

ith bottle is not put into another bottle.
jth bottle doesn't contain any other bottle.
The radius of bottle i is smaller than bottle j (A[i] < A[j]).
You can put bottles into each other any number of times. You want to MINIMIZE the number of visible bottles. A bottle is called visible if it is not put into any other bottle.

Find and return the minimum number of visible bottles.

*/

class Solution {
    public int solve(List<int> A) {
            int n = A.Count;
            Dictionary<int, int> keyValues = new Dictionary<int, int>();

            foreach(var val in A)
            {
                if (!keyValues.ContainsKey(val))
                {
                    keyValues.Add(val, 0);
                }
            }

            int ans = -1;

            for(int i = 0; i < n; i++)
            {
                keyValues[A[i]]++;
                ans = Math.Max(ans, keyValues[A[i]]);
            }

            return ans;
    }
}