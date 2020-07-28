/*

Count Subarrays
Problem Description

Misha likes finding all Subarrays of an Array. Now she gives you an array A of N elements and told you to find the number of subarrays of A, that have unique elements.

Since the number of subarrays could be large, return value % 109 +7.

*/

int Solution::solve(vector<int> &a) {
    int mod = 1e9+7;
    // Initialize left and right pointer
    long long l = 0, r = 0, n = a.size();
    // create a map to store unique elements
    unordered_map<int, bool> ag;
    long long subarrays = 0;
    // stores the previous value of r
    int prev_r = -1;
    while(r < n)
    {
        if(ag[a[r]] == 0) 
        {
            ag[a[r]] = 1;
            r += 1;
        }
        else 
        {
            // all segments in (l to r) will make unique elements 
            
            subarrays += ((r - l) * (r - l + 1)) / 2;
            if(prev_r != -1)
                subarrays -= (prev_r - l) * (prev_r - l + 1)/2;
            prev_r = r;
            while(ag[a[r]]) 
            {
                ag[a[l]] = 0;
                l += 1;
            }
        }
    }
    // add last segement
    subarrays += ((r - l) * (r - l + 1)) / 2;
    if(prev_r != -1)
    {
        subarrays -= (prev_r - l) *(prev_r - l + 1)/2;
    }

    return subarrays%mod;
}