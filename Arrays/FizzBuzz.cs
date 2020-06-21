class Solution {
    public List<string> fizzBuzz(int A) {
        var stringList = new List<string>();
        
        for(int i = 1; i <= A; i++){
            if(i % 3 == 0 && i % 5 == 0){
                stringList.Add("FizzBuzz");
            }
            else if(i % 3 == 0){
                stringList.Add("Fizz");
            }
            else if(i % 5 == 0){
                stringList.Add("Buzz");
            }
            else{
                stringList.Add(i.ToString());
            }
        }
        return stringList;
    }
}