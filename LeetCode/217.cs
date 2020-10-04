public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var dic = new Dictionary<int,bool>();
        foreach(var num in nums) {
            if(dic.ContainsKey(num)) {
                return true;
            } else {
                dic[num] = true;
            }
        }
        return false;
    }
}