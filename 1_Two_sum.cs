public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> hashMap = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];
            if (hashMap.ContainsKey(complement))
                    if (hashMap[complement] != i)
                        return new int[]{i, hashMap[complement]}; 

            if(!hashMap.ContainsKey(nums[i])) {
                hashMap.Add(nums[i], i);
            }else {
                hashMap[nums[i]] = i;
            }
        }

        return new int[] {0, 0};
    }
}