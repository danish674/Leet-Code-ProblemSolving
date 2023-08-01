public class Solution {
    public bool IsValid(string s) {
        if (s == null)
        {
            throw new ArgumentNullException(nameof(s));
        }

        Stack<char> stack = new Stack<char>();

        foreach (char c in s)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                stack.Push(c);
            }
            else if (c == ')' || c == '}' || c == ']')
            {
                if (stack.Count == 0)
                {
                    return false;
                }

                char top = stack.Pop();

                if ((c == ')' && top != '(') || (c == '}' && top != '{') || (c == ']' && top != '['))
                {
                    return false;
                }
            }
            // Ignore other characters (if any) in the input string
        }

        return stack.Count == 0;
    }
}