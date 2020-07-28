/*

Window String
Problem Description

Given a string A and a string B, find the window with minimum length in A which will contain all the characters in B in linear time complexity.
Note that when the count of a character c in B is x, then the count of c in minimum window in A should be at least x.

Note:

If there is no such window in A that covers all characters in B, return the empty string.
If there are multiple such windows, return the first occurring minimum window ( with minimum start index )

*/

class Solution {
    static int no_of_chars = 256;
    public string minWindow(string str, string pat) {
        int len1 = str.Length; 
        int len2 = pat.Length; 
      
        // check if string's length is less than pattern's 
        // length. If yes then no such window can exist 
        if (len1 < len2) 
        { 
            return string.Empty; 
        } 
      
        int []hash_pat = new int[no_of_chars]; 
        int []hash_str = new int[no_of_chars]; 
      
        // store occurrence ofs characters of pattern 
        for (int i = 0; i < len2; i++) 
            hash_pat[pat[i]]++; 
      
        int start = 0, start_index = -1, min_len = int.MaxValue; 
      
        // start traversing the string 
        int count = 0; // count of characters 
        for (int j = 0; j < len1 ; j++) 
        { 
            // count occurrence of characters of string 
            hash_str[str[j]]++; 
      
            // If string's char matches with pattern's char 
            // then increment count 
            if (hash_pat[str[j]] != 0 && 
                hash_str[str[j]] <= hash_pat[str[j]] ) 
                count++; 
      
            // if all the characters are matched 
            if (count == len2) 
            { 
                // Try to minimize the window i.e., check if 
                // any character is occurring more no. of times 
                // than its occurrence in pattern, if yes 
                // then remove it from starting and also remove 
                // the useless characters. 
                while ( hash_str[str[start]] > hash_pat[str[start]] 
                    || hash_pat[str[start]] == 0) 
                { 
      
                    if (hash_str[str[start]] > hash_pat[str[start]]) 
                        hash_str[str[start]]--; 
                    start++; 
                } 
      
                // update window size 
                int len_window = j - start + 1; 
                if (min_len > len_window) 
                { 
                    min_len = len_window; 
                    start_index = start; 
                } 
            } 
        } 
      
        // If no window found 
        if (start_index == -1) 
        { 
            return string.Empty; 
        } 
      
        // Return substring starting from start_index 
        // and length min_len 
        return str.Substring(start_index, min_len); 
    }
}
