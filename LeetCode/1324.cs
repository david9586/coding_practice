public class Solution {
    public IList<string> PrintVertically(string s) {
        var words = s.Split(' ');
        var longest = 0;
        foreach(var word in words) {
            if(word.Length > longest) {
                longest = word.Length;
            }
        }
        var res = new String[longest];
        Array.Fill(res, "");
        for(var i = 0; i < words.Length; i++) {
            for(var j = 0; j < words[i].Length; j++){
                while(res[j].Length < i) {
                    res[j] += ' ';
                }
                res[j] += words[i][j];
            } 
        }
        
        return new List<string>(res);
    }
}