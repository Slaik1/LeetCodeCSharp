/*description
 * Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.
 * You must implement a solution with a linear runtime complexity and use only constant extra space.
*/
namespace LeetCodeCSharp
{
    public class SingleNumberSolution
    {
        public int SingleNumber(int[] nums)
        {
            var x = 0;
            foreach (var item in nums)
                x ^= item;
            return x;
        }
    }
}
