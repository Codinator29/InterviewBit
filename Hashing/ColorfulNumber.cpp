/*

Colorful Number
Problem Description

For Given Number A find if its COLORFUL number or not.

If number A is a COLORFUL number return 1 else return 0.

What is a COLORFUL Number:

A number can be broken into different contiguous sub-subsequence parts. 
Suppose, a number 3245 can be broken into parts like 3 2 4 5 32 24 45 324 245. 
And this number is a COLORFUL number, since product of every digit of a contiguous subsequence is different.

*/

int Solution::colorful(int N) {
    char st[20];
        sprintf(st, "%d", N);
        int len = strlen(st);
        
        map<long long, bool> Hash;

        for(int i = 0; i < len; ++i) {
            long long mul = 1;
            for(int j = i; j < len; ++j) {
                mul *= (long long)(st[j] - '0');
                if(Hash.find(mul) != Hash.end())
                        return 0;
                Hash[mul] = true;
            }
        }

        return 1;
}