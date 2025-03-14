public class Solution {
public int MinimumRecolors(string blocks, int k) {
    int minOperations = int.MaxValue;  // Start with a large value

    for (int i = 0; i <= blocks.Length - k; i++) {
        int countW = 0;

        // Count 'W' in the current window of size k
        for (int j = i; j < i + k; j++) {
            if (blocks[j] == 'W') {  
                countW++;
            }
        }

        minOperations = Math.Min(minOperations, countW); // Update with the minimum
    }

    return minOperations;
}

}