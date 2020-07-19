class Solution {
    public string getPermutation(int A, int B) {
        List<int> candidateSet = Enumerable.Range(1, A).ToList();

        return GetPermutation(B - 1, candidateSet);
    }
    
    private string GetPermutation(int k, List<int> candidateSet)
    {
        int n = candidateSet.Count;

        if( n == 0)
        {
            return string.Empty;
        }

        // This case should not happen
        if(k > factorial(n))
        {
            return string.Empty;
        }

        int f = factorial(n - 1);
        int pos = k / f;
        k %= f;
        string ch = candidateSet[pos].ToString();
        candidateSet.RemoveAt(pos);
        return ch + GetPermutation(k, candidateSet);
    }

    private int factorial(int n)
    {
        if(n > 12)
        {
            return int.MaxValue;
        }
        int fact = 1;

        for(int i = 2; i <=n; i++)
        {
            fact *= i;
        }
        return fact;
    }

}
