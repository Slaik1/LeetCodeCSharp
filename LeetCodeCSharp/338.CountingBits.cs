/*description
 * Given an integer n, return an array ans of length n + 1 such that for each i (0 <= i <= n), 
 * ans[i] is the number of 1's in the binary representation of i.
*/
namespace LeetCodeCSharp
{
    public class CountingBitsSolution
    {
        public int[] CountBits(int n)
        {
            var arr = new int[n + 1];
            for (int i = 0; i <= n; i++)
            {
                var binaryN = Convert.ToString(i, 2);
                arr[i] = binaryN.Count(i => i == '1');
            }
            return arr;
        }
    }
}