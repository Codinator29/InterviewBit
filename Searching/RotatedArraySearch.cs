/*
Rotated Sorted Array Search
*/

int BinarySearch(const vector<int> &A, int B, int low, int high)
{
    if(low == high && A[low] != B)
    {
        return -1;
    }
    
    int mid = (low + high) / 2;
    
    if(A[mid] == B)
    {
        return mid;
    }
    
    if(A[low] < A[mid])
    {
        if(A[low] <= B && B <= A[mid])
        {
            return BinarySearch(A, B, low, mid);
        }
        else
        {
            return BinarySearch(A, B, mid, high);
        }
    }
    
    if(A[low] > A[mid])
    {
        if(A[mid] <= B && B <= A[high])
        {
            return BinarySearch(A, B, mid, high);
        }
        else
        {
            return BinarySearch(A, B, low, mid);
        }
    }
    return -1;
}

int Solution::search(const vector<int> &A, int B) {
    return BinarySearch(A, B, 0, A.size() - 1);
}