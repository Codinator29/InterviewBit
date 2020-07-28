/*

Sort Array in given Order
Problem Description

Given two array of integers A and B, Sort A in such a way that the relative order among the elements will be the same as those are in B. For the elements not present in B, append them at last in sorted order.

Return the array A after sorting from the above method.

NOTE: Elements of B are unique.

*/

vector<int> Solution::solve(vector<int> &A, vector<int> &B) {
    map<int,int> mp;
    
    for(int i=0;i<A.size();i++){
        mp[A[i]] += 1;
    }
    
    A.clear();
    for(int i=0;i<B.size();i++){
        if(mp[B[i]] >= 1){
            while(mp[B[i]]--){
                A.push_back(B[i]);
            }
            mp.erase(B[i]);
        }
    }
    for(auto i:mp){
        if(i.second>0){
            int t = i.second;
            while(t--){
                A.push_back(i.first);
            }
        }
    }
    return A;
}