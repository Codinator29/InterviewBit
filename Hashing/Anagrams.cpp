/*

Anagrams
Problem Description

Given an array A of N strings, return all groups of strings that are anagrams.

Represent a group by a list of integers representing the index(1-based) in the original list. Look at the sample case for clarification.

NOTE: Anagram : a word, phrase, or name formed by rearranging the letters of another, such as 'spar', formed from 'rasp'.

*/

vector<vector<int> > Solution::anagrams(const vector<string> &strs) {
        vector<vector<int> > ans;
        map<string, vector<int> > groups;
        for (int i = 0; i < strs.size(); i++) {
            //sort every string and store groups of strings that are anagrams in a map
            string copyString = strs[i];
            sort(copyString.begin(), copyString.end());
            groups[copyString].push_back(i + 1);
        }

        for(map<string, vector<int> >::iterator it = groups.begin(); it != groups.end(); it++) {
            ans.push_back(it->second);
        }
        return ans;
}