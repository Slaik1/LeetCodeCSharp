/*description
 * Given an array nums of n integers where nums[i] is in the range [1, n], 
 * return an array of all the integers in the range [1, n] that do not appear in nums.
*/
namespace LeetCodeCSharp
{
    public class FindDisappearedNumbersSolution
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            var i = 0;
            while (i < nums.Length)
            {
                var pos = nums[i] - 1;
                if (nums[i] != nums[pos])
                {
                    var temporary = nums[i];
                    nums[i] = nums[pos];
                    nums[pos] = temporary;
                }
                else { i++; }
            }

            var list = new List<int>();
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] != j + 1)
                    list.Add(j + 1);
            }
            return list;
        }
    }
}
