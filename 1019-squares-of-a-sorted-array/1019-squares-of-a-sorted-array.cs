public class Solution {
    public int[] SortedSquares(int[] nums) {
        List<int> output = new List<int>{};

        foreach (int num in nums)
        {
            output.Add(num*num);
        }

        output.Sort();

        return output.ToArray();
    }
}