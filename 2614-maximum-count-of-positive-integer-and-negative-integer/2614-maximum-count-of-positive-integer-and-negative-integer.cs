public class Solution {
    public int MaximumCount(int[] nums) {
        var pos = 0;
        var neg = 0;
        for (var num = 0; num < nums.Length; num++)
            if (nums[num] < 0)
                neg += 1;
            else if (nums[num] > 0)
                pos += 1;
  
        if (pos > neg)
            return pos;
        else
            return neg;
    }
}