class Solution {
    public int solve(int A) {
        
        //All the door number which are perfect square will remain open since they have exactly odd no of factors.
        
        int i = 1;
        int count = 0;
        
        while(i*i <= A){
            count++;
            i++;
        }
        return count;
    }
}