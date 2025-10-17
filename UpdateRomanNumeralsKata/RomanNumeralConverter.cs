namespace UpdateRomanNumeralsKata;

public class RomanNumeralConverter
{
    public Dictionary<int,string> RomanNumerals = new()
        {
            { 1000, "M" },
            { 900, "CM" },
            { 500, "D" },
            { 400, "CD" },
            { 100, "C" },
            { 90, "XC" },
            { 50, "L" },
            { 40, "XL" },
            { 10, "X" },
            { 9, "IX" },
            { 6, "VI" },
            { 5, "V" },
            { 4, "IV" },
            { 1, "I" }
        };
        public string ConvertToRomanNumerals(int arabic)
        {
            
            if (arabic <= 0 || arabic >= 4000)
            {
                throw new ArgumentOutOfRangeException("Value must be between 1 and 3999");
            }

            var roman = string.Empty;
            foreach (int value in RomanNumerals.Keys)
            {
                while (arabic >= value)
                {
                    roman += RomanNumerals[value];
                    arabic -= value;
                }
            }

            return roman;
        }

}
