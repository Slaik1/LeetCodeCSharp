/*description
 * You are given a non-negative floating point number rounded to two decimal places celsius, 
 * that denotes the temperature in Celsius.
 * You should convert Celsius into Kelvin and Fahrenheit and return it as an array ans = [kelvin, fahrenheit].
 * Return the array ans. Answers within 10-5 of the actual answer will be accepted.
*/
namespace LeetCodeCSharp
{
    public class ConvertTemperatureSolution
    {
        public double[] ConvertTemperature(double celsius)
        {
            var arr = new double[2];
            arr[0] = celsius + 273.15;
            arr[1] = celsius * 1.8 + 32;

            return arr;
        }
    }
}
