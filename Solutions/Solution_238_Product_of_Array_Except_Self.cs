namespace Solutions;

public class Solution_238_Product_of_Array_Except_Self
{
    public int[] ProductExceptSelf(int[] nums)
    {
        var leftArr = new int[nums.Length];
        var rightArr = new int[nums.Length];

        var left = 1;
        for (var i = 0; i < nums.Length; i++)
        {
            leftArr[i] = left;
            left *= nums[i];
        }

        var rigth = 1;
        for (var i = nums.Length - 1; i >= 0; i--)
        {
            rightArr[i] = rigth;
            rigth *= nums[i];
        }

        for (var i = 0; i < nums.Length; i++) nums[i] = leftArr[i] * rightArr[i];

        return nums;
    }
}