/*

Count Rectangles
Problem Description

Given two arrays of integers A and B of size N each, where each pair (A[i], B[i]) for 0 <= i < N represents a unique point (x, y) in 2-D Cartesian plane.

Find and return the number of unordered quadruplet (i, j, k, l) such that (A[i], B[i]), (A[j], B[j]), (A[k], B[k]) and (A[l], B[l]) form a rectangle with the rectangle having all the sides parallel to either x-axis or y-axis.

*/

public class Solution {
    public int solve(int[] a, int[] b) {
        int n = a.length;
        HashMap <Integer, HashSet <Integer>> mpx = new HashMap<>();
    	HashSet <Integer> h;
    	for(int i = 0; i < n; i++) {
    		if(mpx.containsKey(a[i]))	
    		    h = mpx.get(a[i]);
    		else	
    		    h = new HashSet<>();
    		h.add(b[i]);
    		mpx.put(a[i], h);
    	}

    	int ans = 0;
    	for(int i = 0; i < n; i++) {
    		for(int j = i+1; j < n; j++) {
    			if(a[i] == a[j] || b[i] == b[j])	
    			    continue;
    			if(mpx.get(a[i]).contains(b[j]) && mpx.get(a[j]).contains(b[i]))	
    			    ans++;
    		}
    	}
    	return ans >> 1;
    }
}