class Solution {
    public int solve(int A, List<int> B) {
        int noOfDays = 0;

    while(A >= 0){   
        noOfDays = 0;
            foreach(var dayLine in B){
                A -= dayLine;
                if(A > 0){
                    noOfDays++;
                }
                else{
                    return ++noOfDays;
                }
            }
        
        }
            return noOfDays;
    }
}