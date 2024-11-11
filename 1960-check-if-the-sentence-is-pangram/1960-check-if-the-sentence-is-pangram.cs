public class Solution {
    public bool CheckIfPangram(string sentence) {
        string englishAlphabet = "abcdefghijklmnopqrstuvwxyz";
        for (int alphabetIndex = 0; alphabetIndex < englishAlphabet.Length; alphabetIndex++)
        {
            if (!sentence.Contains(englishAlphabet[alphabetIndex]))
            {
                return false;
            }
        }
        
        return true;
    }
}