/*

ALL GCD PAIR
Problem Description

Given an array of integers A of size N containing GCD of every possible pair of elements of another array.

Find and return the original numbers which are used to calculate the GCD array in any order. For example, if original numbers are {2, 8, 10} then the given array will be {2, 2, 2, 2, 8, 2, 2, 2, 10}.

*/

class Solution {
    public List<int> solve(List<int> A) {
            A.Sort();
            A.Reverse();

            Dictionary<int, int> cnt = new Dictionary<int, int>();
            List<int> vec = new List<int>();
            for(int i = 0; i <= A.Max(); i++){
                cnt.Add(i, 0);
            }

            for (int i = 0; i < A.Count; i++)
            {

                if (cnt[A[i]] > 0)
                {
                    cnt[A[i]]--;
                }
                else
                {
                    for (int j = 0; j < vec.Count; j++)
                    {
                        int gcdVal = gcd(vec[j], A[i]);
                        cnt[gcdVal] += 2;
                    }
                    vec.Add(A[i]);
                }
            }

            return vec;

    }
    public static int gcd(int A, int B)
    {
        if (A == 0 && B == 0)
        {
            throw new Exception("Invalid");
        }

        if (B == 0)
        {
            return A;
        }

        return gcd(B, A % B);
    }
}