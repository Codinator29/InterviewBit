class Solution {
    public int solve(int A) {
        int i = 1;
        double powerVal = 2;
        
        while(A >= powerVal){
            i++;
            powerVal = Math.Pow(2, i);
        }
        return Convert.ToInt32(Math.Pow(2,i-1));
    }
}