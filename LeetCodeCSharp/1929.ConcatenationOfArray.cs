/*description
 * Given an integer array nums of length n, you want to create an array ans of length 2n 
 * where ans[i] == nums[i] and ans[i + n] == nums[i] for 0 <= i < n (0-indexed).
 * Specifically, ans is the concatenation of two nums arrays.
 * Return the array ans.
*/
namespace LeetCodeCSharp
{
    public class ConcatenationOfArraySolution
    {
        public int[] GetConcatenation(int[] nums)
        {
            var answer = new int[nums.Length * 2];
            nums.CopyTo(answer, 0);
            nums.CopyTo(answer, nums.Length);
            return answer;
        }
    }
}
