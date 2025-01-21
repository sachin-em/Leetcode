// Time Complexity : O(m * n)
// Space Complexity : O(1)
// n is the number of strings in strs array
// m is the length of smallest string in strs array

public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string smallestStr = strs[0], prefix = string.Empty;
        int charIdx = -1, minLength = strs[0].Length;

        for (int i = 0; i < strs.Length; i++) {
            string currentStr = strs[i];
            if (currentStr.Length < minLength){
                minLength = currentStr.Length;
                smallestStr = currentStr;
            }
        }

        foreach (char letter in smallestStr) {
            charIdx++;
            bool isLetterMatched = true;
            for (int i = 0; i < strs.Length; i++) {
                string currentStr = strs[i];

                if (currentStr[charIdx] != letter) {
                    isLetterMatched = false;
                    break;
                }
            }

            if (isLetterMatched){
                prefix += letter.ToString();
            } else {
                break;
            }
        }

        return prefix;
    }
}