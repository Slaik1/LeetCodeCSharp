/*description
 * Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.
 * For example, 2 is written as II in Roman numeral, just two ones added together. 
 * 12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.
 * I can be placed before V (5) and X (10) to make 4 and 9. 
 * X can be placed before L (50) and C (100) to make 40 and 90.
 * C can be placed before D (500) and M (1000) to make 400 and 900.
*/
namespace LeetCodeCSharp
{
    public class RomanToIntegerSolution
    {
        public int RomanToInt(string s)
        {
            var dict = new Dictionary<char, int>() { { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, 
                                                     { 'C', 100 }, { 'D', 500 }, { 'M', 1000 } };
            var sum = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (i < s.Length - 1 && dict[s[i]] < dict[s[i + 1]])
                {
                    sum += dict[s[i + 1]] - dict[s[i]];
                    i++;
                }
                else sum += dict[s[i]];
            }
            return sum;
        }
    }
}