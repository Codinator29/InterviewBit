class Solution {
    public List<int> nextPermutation(List<int> num) {
        
         int len = num.Count;
            int i, j;
            for (i = len - 2; i >= 0; i--)
                if (num[i] < num[i + 1]) break;

            if (i == -1)
            {
                num.Reverse();
                return num;
            }

            for (j = len - 1; j > i; j--)
                if (num[j] > num[i]) break;

            Swap(num, i, j);
            num.Reverse(i + 1, num.Count - i - 1);
            return num;
    }
        public static void Swap(List<int> num, int i, int j)
        {
            int temp = num[i];
            num[i] = num[j];
            num[j] = temp;
        }
}