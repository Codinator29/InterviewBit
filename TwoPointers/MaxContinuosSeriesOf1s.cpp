/*

Max Continuous Series of 1s
Problem Description

Given a binary array A, find the maximum sequence of continuous 1's that can be formed by replacing at-most B ones.

For this problem, return the indices of maximum continuous series of 1s in order.

If there are multiple possible solutions, return the sequence which has the minimum start index.

*/

vector<int> Solution::maxone(vector<int> &Vec, int M) {
    int N = Vec.size();
    int i = 0;
    int j = 0;
    int max_len = 0;
    int cnt = 0;
    vector<int> ans;
	
	int ans_start = 0; 
	int ans_end = 0;

    while(i < N) {
        if(cnt + (Vec[i] == 0) > M) 
        {
            int temp_len = (i - j); // length from j to i - 1. 
            if(temp_len > max_len)
            {
                max_len = temp_len;
                ans_start = j;
	            ans_end = i - 1;
            }

            while(i >= j && cnt + (Vec[i] == 0) > M) 
            {
                cnt -= (Vec[j] == 0);
                j++;
            }
        } 
        cnt += (Vec[i] == 0);
        i++;
    }

    int temp_len = (i - j);
    if(temp_len > max_len)
    {
        temp_len = max_len;
        ans_start = j;
        ans_end = i - 1;
    }

	for (int ele = ans_start; ele <= ans_end; ele++)
	{
		ans.push_back(ele);
	}
	return ans;
}