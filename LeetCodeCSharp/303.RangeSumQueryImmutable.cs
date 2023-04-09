/*description
 * Given an integer array nums, handle multiple queries of the following type:
 * Calculate the sum of the elements of nums between indices left and right inclusive where left <= right.
*/
namespace LeetCodeCSharp
{
    public class RangeSumQuerySolution
    {
        public int[] nums { get; set; }

        public RangeSumQuerySolution(int[] nums)
        {
            this.nums = nums;
        }

        public int SumRange(int left, int right)
        {
            var answer = 0;
            for (int i = left; i <= right; i++)
                answer += nums[i];

            return answer;
        }
    }
}
