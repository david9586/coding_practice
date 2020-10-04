public class Solution {
    public int NumRabbits(int[] answers) {
        var dic = new Dictionary<int,int>();
        
        foreach(var answer in answers) {
            int value = 1;
            if(dic.ContainsKey(answer)){
                value = dic[answer] + 1;
            }
            dic[answer] = value;
        }
        
        var total = 0;
        foreach(var entry in dic) {
            total += 1+entry.Key;
            int value = entry.Value;
            while(entry.Key + 1 < value) {
                value = value - 1 - entry.Key;
                total += 1+entry.Key;
            }
            
        }
        
        return total;
    }
}