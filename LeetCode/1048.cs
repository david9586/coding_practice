public class Solution {
    public int LongestStrChain(string[] words) {
        var dic = new Dictionary<string,string>();
        
        foreach(var word in words){
            if(!dic.ContainsKey(word)){
                dic.Add(word,null);
            }
        }
        
        for(int i = 0; i < dic.Keys.Count(); i++){
            var word = dic.Keys.ElementAt(i);
            string parent = null;
            for(var j = 0; j < word.Length; j++){
                var s = "";
                if(j > 0){
                    s += word.Substring(0,j);
                }
                s+= word.Substring(j+1);
                
                if(dic.ContainsKey(s)) {
                    parent = s;
                    break;
                }
            }
            dic[word] = parent;
        }
        var longest = 0;
        foreach(var entry in dic) {
            var current = 1;
            var parent = entry.Value;
            while(parent != null) {
                current++;
                parent = dic[parent];
            }
            if(current > longest) {
                longest = current;
            }
        }
                
        return longest;
    }
}