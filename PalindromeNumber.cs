// Time Complexity : O(n)
// Space Complexity : O(1)
// n is the number of digits in x

public class Solution {
    public bool IsPalindrome(int x) {
        int og = x;
        if (x < 0)
            return false;

        int reversedDigit = 0;
        
        while(x > 0) {
            int lastDigit = x % 10;
            reversedDigit = reversedDigit * 10 + lastDigit;
            x /= 10;
        }

        if (reversedDigit == og)
            return true;
        
        return false;
    }
}