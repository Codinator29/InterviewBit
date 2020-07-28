/*

Points on same line
Problem Description

Given two array of integers A and B describing a pair of (A[i], B[i]) coordinates in 2D plane. A[i] describe x coordinates of the ith point in 2D plane whereas B[i] describes the y-coordinate of the ith point in 2D plane.

Find and return the maximum number of points which lie on the same line.

*/

int gcd (int a, int b)
{
    if (a == 0) 
        return b;
    if (b == 0) 
        return a;
    if (a < 0) 
        return gcd(a*-1, b);
    if (b < 0) 
        return gcd(a, b*-1);
    if (a > b) 
        return gcd(b, a);
    return gcd(b%a, a);
}

int Solution::solve(vector<int> &A, vector<int> &B) {
    int ans = 0;
    map<pair<int, int>, int> M;
    
    for (auto i = 0; i<A.size(); ++i)
    {
        M.clear();
        int same = 1, currMax = 0; //same = 1 to handle case when there is only 1 point (X,Y).
        for (auto j = i+1; j<A.size(); ++j)
        {
            auto diffX = A[i] - A[j];
            auto diffY = B[i] - B[j];
            
            if (diffX == 0 && diffY == 0)
            {
                ++same;
                continue;
            }
            
            if (diffX < 0)
            {
                diffX *= -1;
                diffY *= -1;
            }
            
            int g = gcd(diffX, diffY);
            M[make_pair(diffX/g, diffY/g)]++;
            currMax = max(currMax, M[make_pair(diffX/g, diffY/g)]);
        }
        currMax += same;
        ans = max(currMax, ans);
    }
    return ans;
}
