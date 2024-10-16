namespace RomanNumerals
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(RomanToInteger.Convert("III"));       // Output: 3
            Console.WriteLine(RomanToInteger.Convert("IV"));        // Output: 4
            Console.WriteLine(RomanToInteger.Convert("IX"));        // Output: 9
            Console.WriteLine(RomanToInteger.Convert("LVIII"));     // Output: 58
            Console.WriteLine(RomanToInteger.Convert("MCMXCIV"));   // Output: 1994
            Console.WriteLine(RomanToInteger.Convert("MMMCMXCIX")); // Output: 3999
        }
    }

    public class RomanToInteger
    {
        public static int Convert(string value)
        {
             //Todo: Convert Roman Numerals to Integer.
        }
    }
}
