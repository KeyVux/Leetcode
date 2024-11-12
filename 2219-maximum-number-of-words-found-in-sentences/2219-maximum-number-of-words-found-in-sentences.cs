public class Solution {
    public int MostWordsFound(string[] sentences) {
        int maxWords = 0; 

        foreach (string sentence in sentences) 
        {
            maxWords = Math.Max(maxWords, sentence.Split(' ').Length);
        }

        return maxWords; 
    }
}