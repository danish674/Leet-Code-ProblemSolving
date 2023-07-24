public class Solution {
    public bool IsPalindrome(int x) {
        string y = x.ToString();
        string z = new string(y.Reverse().ToArray());
        if (z == y)
            {
                return true;
            }
            else
            return false;
    }
}