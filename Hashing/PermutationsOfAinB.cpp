/*

Permutations of A in B
Problem Description

You are given two strings A and B of size N and M respectively.

You have to find the count of all permutations of A present in B as a substring. You can assume a string will have only lowercase letters.

*/

int same(int *hash1, int *hash2) {
    for(int i = 0; i < 26; i += 1) {
        if(hash1[i] != hash2[i])
            return 0;               // not a permutation of A
    }
    return 1;                       // got a permutation of A in G
}

int Solution::solve(string a, string g) {
    int n = a.size();
    int m = g.size();
    int hash1[26], hash2[26];
    int count = 0;
    
    // Reset hash maps
    for(int i = 0; i < 26; i += 1) {
        hash1[i] = hash2[i] = 0;
    }
    // count frequency of each char in A 
    for(int i = 0; i < n; i += 1) {
        hash1[a[i] - 'a'] += 1;
    }
    // count frequency of each char in first window of size n in G
    for(int i = 0; i < n; i += 1) {
        hash2[g[i] - 'a'] += 1;
    }
    
    count += same(hash1, hash2);
    
    // move current window 1 step ahead
    for(int i = n, j = 0; i < m; i += 1, j += 1) {
        hash2[g[j] - 'a'] -= 1;
        hash2[g[i] - 'a'] += 1;
        count += same(hash1, hash2);
    }
    
    return count;
}