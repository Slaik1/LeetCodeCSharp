/*description
 * Write a function to find the longest common prefix string amongst an array of strings.
 * If there is no common prefix, return an empty string "".
*/
namespace LeetCodeCSharp
{
    public class LongestCommonPrefixSolution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            var prefix = "";
            for (int i = 0; i < strs[0].Length; i++)
            {
                for (int j = 0; j < strs.Length; j++)
                    if (!strs[j].StartsWith(prefix + strs[0][i]))
                        return prefix;

                prefix += strs[0][i];
            }
            return prefix;
        }
    }
}