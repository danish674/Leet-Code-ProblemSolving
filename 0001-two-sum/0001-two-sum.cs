public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> numMap = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            int num = nums[i];
            int complement = target - num;
            if (numMap.ContainsKey(complement)) {
                return new int[] { numMap[complement], i };
            }
            numMap[num] = i;
        }
        return new int[0];

        static void Main() {
        Solution solution = new Solution();
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;
        int[] result = solution.TwoSum(nums, target);
        Console.WriteLine(string.Join(", ", result)); // Output: 0, 1
    }
    }
}


