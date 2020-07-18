/*

Reverse Bits
Problem Description

Reverse the bits of an 32 bit unsigned integer A.

*/

unsigned int Solution::reverse(unsigned int A) {
   unsigned int Bits = sizeof(A) * 8;
   unsigned reverse = 0, i , temp;
   
   for(i = 0; i < Bits; i++){
       temp = (A & (1 << i));
       
       if(temp){
           reverse |= (1 << ((Bits - 1) - i));
       }
   }
   
   return reverse;
}