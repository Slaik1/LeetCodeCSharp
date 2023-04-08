/*description
 * Given an integer x, return true if x is a palindrome, and false otherwise.
*/
namespace LeetCodeCSharp
{
    public class PalindromeNumberSolution
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;
            var strX = x.ToString();
            for (int i = 0; i < strX.Length / 2; i++)
                if (strX[i] != strX[strX.Length - i - 1])
                    return false;
            return true;
        }
    }
}
