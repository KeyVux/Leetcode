public class Solution {
    public string[] SortPeople(string[] names, int[] heights) {
        Dictionary<int, string> mapping = new Dictionary<int, string>();
        int n = names.Count();
        for (int mappingIndex = 0; mappingIndex < n; ++mappingIndex)
        {
            mapping[heights[mappingIndex]] = names[mappingIndex];
        }
        
        Array.Sort(heights);
        Array.Reverse(heights);
        
        
        for (int mappingIndex = 0; mappingIndex < n; ++mappingIndex)
        {
            names[mappingIndex] = mapping[heights[mappingIndex]];
        }

        return names;
    }
}