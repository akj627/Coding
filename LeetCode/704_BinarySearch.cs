public class Solution {
    public int Search(int[] nums, int target) {

        if (nums.Length == 1 && nums[0] == target)
            return 0;      
        var result = Recur(nums, target, 0, nums.Length - 1);
        return result;
    }

    private int Recur(int[] nums, int target, int startIndex, int endIndex)
    {
        if (startIndex > endIndex)
            return -1;
        var middle = (endIndex + startIndex) / 2;
        if (nums[middle] == target)
            return middle;
        else if (nums[middle] < target)
        {
            return Recur(nums, target, middle + 1, endIndex);
        }
        else
        {
            return Recur(nums, target, startIndex, middle - 1);
        }
    }
}