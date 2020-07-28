/*

Replicating Substring
Problem Description

Given a string B, find if it is possible to re-order the characters of the string B so that it can be represented as a concatenation of A similar strings.

Eg: B = aabb and A = 2, then it is possible to re-arrange the string as "abab" which is a concatenation of 2 similar strings "ab".

If it is possible, return 1, else return -1.

*/

typedef int ll;
int Solution::solve(int A, string B) {
        ll k=A;
		string s=B;
        //hash array to keep a track of frequency of each character
		ll hash[26];
		memset(hash,0,sizeof(hash));
		for(ll i=0;s[i]!='\0';i++)
		{
			hash[s[i]-'a']++;
		}

		ll flag=0;
		string temp="";
		for(ll i=0;i<26;i++)
		{
		    //if the frequency of a character present in the string isnt divisble by k, set a flag which indicates that 
		    //it will never be possible to represent S as concatenation of K strings
			if(hash[i]%k!=0)
				flag=1;
			else
			{
			    //add to temp the number of times that a particular character will occur
				ll ind=hash[i]/k;
				for(ll j=0;j<ind;j++)
					temp+=i+'a';
			}
		}
        
        //if k is equal to the length of the string, then each character must be same in the string
        //that is, each character must be the same therefore the length of temp must be 1
		if(k==s.length())
		{
			if(temp.length()==1)
				return 1;
			else
				return -1;
		}
        //if the flag is set or the length of the string is not divisble by k then return -1 else return 1
		if(flag or s.length()%k!=0)
		    return -1;
		else
		{
			return 1;
		}
}