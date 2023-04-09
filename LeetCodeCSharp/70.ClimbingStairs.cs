/*description
 * You are climbing a staircase. It takes n steps to reach the top.
 * Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?
*/
namespace LeetCodeCSharp
{
    public class ClimbingStairsSolution
    {
        public int ClimbStairs(int n)
        {
            if (n == 1) return 1;
            var n1 = 1;
            var n2 = 2;
            for (var i = 2; i < n; i++)
            {
                var temp = n1;
                n1 = n2;
                n2 = temp + n2;
            }
            return n2;
        }
    }
}