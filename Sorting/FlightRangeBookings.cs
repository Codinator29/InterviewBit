/*

Flight Range Bookings
Problem Description

There is a company CorpFly which only takes booking from corporates. They have A flights and they are numbered from 1 to A.

Corporate bookings are of the following form (i, j, K). This implies book K seats each on every flight numbered between i and j (inclusive).

Given a 2-D array B of size M * 3 denoting a sequence of these bookings from corporates, your job is to tell the number of seats booked on each of the A flights.

NOTE: Assume the number of seats in every flight is infinite.

*/

class Solution {
    public List<int> solve(int A, List<List<int>> B) {
        var booking = Enumerable.Repeat(0, A).ToList();

        for(int i = 0; i < B.Count; i++){
            int leftIndex = B[i][0] - 1;
            int rightIndex = B[i][1] - 1;
            
            int numberOfBookings = B[i][2];
            
            booking[leftIndex] += numberOfBookings;
            
            if((rightIndex + 1) < A){
                booking[rightIndex + 1] -= numberOfBookings;
            }
        }
        
        for(int i = 1; i < A; i++){
            booking[i] += booking[i  - 1];
        }
        
        return booking;

    }
}