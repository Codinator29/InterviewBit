class Solution {
    public int trap(List<int> A) {
            int left = 0;
            int right = A.Count - 1;
            int ans = 0;
            int leftMax = 0;
            int rightMax = 0;
            while (left < right)
            {
                if (A[left] < A[right])
                {
                    //if A left < left max that means we can trap water
                    if (A[left] < leftMax)
                    {
                        ans += leftMax - A[left];
                    }
                    else // otherwise left max needs to be updated
                    {
                        leftMax = A[left];
                    }
                    left++;
                }
                else
                {
                    if (A[right] < rightMax)
                    {
                        ans += rightMax - A[right];
                    }
                    else
                    {
                        rightMax = A[right];
                    }

                    right--;
                }
            }
            return ans;
    }
}