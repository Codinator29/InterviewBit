/*

Aggressive cows
Problem Description

Farmer John has built a new long barn, with N stalls. Given an array of integers A of size N where each element of the array represents the location of the stall, and an integer B which represent the number of cows.

His cows don't like this barn layout and become aggressive towards each other once put into a stall. To prevent the cows from hurting each other, John wants to assign the cows to the stalls, such that the minimum distance between any two of them is as large as possible. What is the largest minimum distance?

*/

class Solution {
    public int solve(List<int> A, int B) {
        A.Sort();
        int start = 0;
        int last = A.Last();
        int max = -1;
        
        while(start <= last){
            int mid = (start + last)/ 2;
            
            if(check(mid, A, B) == 1){
                if(mid > max){
                    max = mid;
                }
                start = mid + 1;
            }
            else{
                last = mid - 1;
            }
        }

        return max;
    }
    
    public int check(int mid, List<int> stalls, int totalCows){
        int cows = 1, pos = stalls.First();
        
        for(int i = 1; i < stalls.Count; i++){
            if(stalls[i] - pos >= mid){
                pos = stalls[i];
                cows++;
                
                if(cows == totalCows){
                    return 1;
                }
            }
        }
        return 0;
    }
}