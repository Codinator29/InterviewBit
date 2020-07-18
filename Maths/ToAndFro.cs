/*

To and Fro
Problem Description

The Guardians of the Galaxy have just landed on Earth.

There are N cities in a row numbered from 1 to N.

The cost of going from a city with number i to a city with number j is the remainder when (i+j) is divided by (n+1).

The Guardians want to visit every city but in the minimum cost. What is the minimum cost that will be incurred?

*/

class Solution {
    public int solve(int A) {
        int n;
	    n=A;
	    int ans;
	    if(n % 2 != 0)
	        ans=(n - 1) / 2;
	    else
	    {
	        ans=(n / 2) - 1;
	    }
	    return ans;

    }
}