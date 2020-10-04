public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var dic = new Dictionary<string,int>();
        var currentIndex = 0;
        var res = new List<IList<string>>();
        foreach(var word in strs) {
            var charArray = word.ToCharArray();
            Array.Sort(charArray);
            var sortedWord = new string(charArray);
            if(dic.ContainsKey(sortedWord)){
                res[dic[sortedWord]].Add(word);   
            } else {
                dic.Add(sortedWord,currentIndex++);
                var temp = new List<string>();
                temp.Add(word);
                res.Add(temp);
            }
        }
        
        
        return res;
    }
}