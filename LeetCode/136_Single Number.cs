public class Solution {
    public int SingleNumber(int[] nums) {
        var lstNums = new List<int>();            
        for (var i = 0; i < nums.Length; i++)
        {
            if (lstNums.Contains(nums[i]))
                lstNums.Remove(nums[i]);
            else
                lstNums.Add(nums[i]);            
        }
        return lstNums[0];
    }
}