/*

Closest pair from sorted arrays
Problem Description

Given two sorted arrays of distinct integers, A and B, and an integer C, find and return the pair whose sum is closest to C and the pair has one element from each array.

More formally, find A[i] and B[j] such that abs((A[i] + B[j]) - C) has minimum value.

If there are multiple solutions find the one with minimum i and even if there are multiple values of j for the same i then return the one with minimum j.

Return an array with two elements {A[i], B[j]}.

*/

vector<int> Solution::solve(vector<int> &ar1, vector<int> &ar2, int x) 
{
    // Initialize the diff between pair sum and x. 
    int diff = INT_MAX; 
    
    int m = ar1.size();
    
    int n = ar2.size();
  
    // res_l and res_r are result indexes from ar1[] and ar2[] 
    // respectively 
    int res_l, res_r; 
  
    // Start from left side of ar1[] and right side of ar2[] 
    int l = 0, r = n-1; 
    while (l < m && r >= 0) 
    { 
       // If this pair is closer to x than the previously 
       // found closest, then update res_l, res_r and diff 
       if (abs(ar1[l] + ar2[r] - x) < diff) 
       { 
           res_l = l; 
           res_r = r; 
           diff = abs(ar1[l] + ar2[r] - x); 
       } 
       
       else if(abs(ar1[l] + ar2[r] - x) == diff)
       {
           
           if(l < res_l)
           {
               res_l = l; 
               res_r = r;
           }
           
           else if(l == res_l)
           {
               if(r < res_r)
               {
                   res_r = r; 
               }
               
           }
           
       }
  
       // If sum of this pair is more than x, move to smaller 
       // side 
       if (ar1[l] + ar2[r] > x) 
           r--; 
       else  // move to the greater side 
           l++; 
    } 
  
    vector<int> ans;
    
    ans.push_back(ar1[res_l]);
    
    ans.push_back(ar2[res_r]);
    
    return ans;
}
