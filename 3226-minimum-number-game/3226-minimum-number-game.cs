public class Solution {
    public int[] NumberGame(int[] nums) {
        int[] output = new int[nums.Length];
        Array.Sort(nums);
        for (int numsIndex = 0; numsIndex < nums.Length-1; numsIndex+=2)
        {
            output[numsIndex] = nums[numsIndex+1];
            output[numsIndex+1] = nums[numsIndex];
        }
        return output;
    }
}