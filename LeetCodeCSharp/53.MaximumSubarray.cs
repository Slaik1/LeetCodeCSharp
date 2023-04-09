/*description
 * Given an integer array nums, find the subarray
 * with the largest sum, and return its sum.
*/
namespace LeetCodeCSharp
{
    public class MaximumSubarraySolution
    {
        public int MaxSubArray(int[] nums)
        {
            var maxSum = nums[0];
            var currentSum = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                currentSum = Math.Max(currentSum + nums[i], nums[i]);
                maxSum = Math.Max(maxSum, currentSum);
            }
            return maxSum;
        }
    }
}
