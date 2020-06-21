int Solution::solve(vector<int> &A) {
    int gcd = 0;
    for(int i = 0; i < A.size(); i++){
        gcd = __gcd(A[i], gcd);
    }
    
    if(gcd == 1) 
        return 0;
    else 
        return -1;
}