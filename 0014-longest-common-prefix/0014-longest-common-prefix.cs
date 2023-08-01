public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        
        if(strs == null || strs.Length == 0)
            {
                return "";
            }

            string prefix = strs[0];

            for(int i = 0; i< strs.Length; i++)
            {
                string current = strs[i];
                int j = 0;

                while (j < prefix.Length && j < current.Length && prefix[j] == current[j])
                {
                    j++;
                }

                prefix = prefix.Substring(0, j);

                if (prefix.Length == 0)
                {
                    // If prefix becomes empty, there is no common prefix
                    return "";
                }
            }
            return prefix;
        
    }
}