public class Solution {
    public IList<int> FindWordsContaining(string[] words, char x) {
        List<int> indexMatch = new List<int>();

        for (int wordIndex = 0; wordIndex < words.Length; wordIndex++)
        {
            if (words[wordIndex].Contains(x))
            {
                indexMatch.Add(wordIndex);
            }
        }

        return indexMatch;
    }
}