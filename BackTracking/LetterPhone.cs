class Solution {
    
    List<string> Map;
    
    public Solution(){
        Map = new List<string>();
            Map.Add("0");
            Map.Add("1");
            Map.Add("abc");
            Map.Add("def");
            Map.Add("ghi");
            Map.Add("jkl");
            Map.Add("mno");
            Map.Add("pqrs");
            Map.Add("tuv");
            Map.Add("wxyz");
    }
    
    public List<string> letterCombinations(string A) {
        List<string> ans = new List<string>();
        string current = string.Empty;
        generateHelper(current, 0, A, ans);
        return ans;
    }
    
    void generateHelper(string current, int index, string digits, List<string> ans){
        if(index == digits.Length){
            ans.Add(current);
            return;
        }
        
        int digit = digits[index] - '0';
        
        for(int i = 0; i < Map[digit].Length; i++){
            current = current + Map[digit][i];
            generateHelper(current, index + 1, digits, ans);
            current = current.Remove(current.Length - 1);
        }
        
        return;
    }
}