public class Solution {
    public int RomanToInt(string s) {
        Dictionary<string, int> romanDict = new Dictionary<string, int>();
        Dictionary<string, int> romanSpecDict = new Dictionary<string, int>();

        romanDict.Add("I", 1);
        romanDict.Add("V", 5);
        romanDict.Add("X", 10);
        romanDict.Add("L", 50);
        romanDict.Add("C", 100);
        romanDict.Add("D", 500);
        romanDict.Add("M", 1000);
        romanDict.Add("IV", 4);
        romanDict.Add("IX", 9);
        romanDict.Add("XL", 40);
        romanDict.Add("XC", 90);
        romanDict.Add("CD", 400);
        romanDict.Add("CM", 900);

        int result = 0;
        int i = 0;
        for (i = 0; i < s.Length - 1; i++) {
            string combi = s[i].ToString() + s[i+1].ToString();
            if (romanDict.ContainsKey(combi)) {
                result += romanDict[combi];
                i++;
            } else {
                result += romanDict[s[i].ToString()];
            } 
        }

        if (i == s.Length - 1)
            result += romanDict[s[i].ToString()];

        return result;
    }
}