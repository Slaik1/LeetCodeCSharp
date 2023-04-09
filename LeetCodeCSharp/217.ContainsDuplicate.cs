/*description
 * Given an integer array nums, return true if any value appears at 
 * least twice in the array, and return false if every element is distinct.
*/
namespace LeetCodeCSharp
{
    public class ContainsDuplicateSolution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            var set = new HashSet<int>();
            foreach (var item in nums)
                if (!set.Add(item))
                    return true;
            return false;
        }
    }
}
