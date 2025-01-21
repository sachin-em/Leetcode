public class Solution {
    public bool IsValid(string s) {
        bool isValid = true;
        Stack<char> stack = new Stack<char>();
        Dictionary<char, char> bracketPair = new Dictionary<char, char>();
        bracketPair.Add('(', ')');
        bracketPair.Add('[', ']');
        bracketPair.Add('{', '}');
   
        foreach (char bracket in s) {
            if (bracketPair.ContainsKey(bracket)) {
                stack.Push(bracket);
            } else if (stack.Count < 1 || bracketPair[stack.Pop()] != bracket) {
                isValid = false;
                break;
            }
        }

        if (stack.Count > 0)
            isValid = false;

        return isValid;
    }
}