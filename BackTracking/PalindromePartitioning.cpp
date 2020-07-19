/*

Palindrome Partitioning
Problem Description

Given a string A, partition A such that every string of the partition is a palindrome.

Return all possible palindrome partitioning of A.

Ordering the results in the answer : Entry i will come before Entry j if :
len(Entryi[0]) < len(Entryj[0]) OR
(len(Entryi[0]) == len(Entryj[0]) AND len(Entryi[1]) < len(Entryj[1])) OR * * *
(len(Entryi[0]) == len(Entryj[0]) AND ... len(Entryi[k] < len(Entryj[k]))

*/

bool isPalindrome(string &str, int s, int e) {
    while (s < e) {
        if (str[s] != str[e])
                return false;
        s++;
        e--;
    }
    return true;
}

void partitionHelper(int i, vector<string> &current, string &s, vector<vector<string> > &ans) {

    if (i == s.length()) {
        // we reached the end of the string.
        // Valid sequence of strings found.
        ans.push_back(current);
        return;
    }

    for (int j = i; j < s.length(); ++j) {
        if (isPalindrome(s, i, j)) {
            current.push_back(s.substr(i, j - i + 1));
            partitionHelper(j + 1, current, s, ans);
            current.pop_back();
        }
    }
}

vector<vector<string> > Solution::partition(string A) {
    // Do not write main() function.
    // Do not read input, instead use the arguments to the function.
    // Do not print the output, instead return values as specified
    // Still have a doubt. Checkout www.interviewbit.com/pages/sample_codes/ for more details
    vector<vector<string> > ans;
    vector<string> current;
    partitionHelper(0, current, A, ans);
    return ans;
}