using System.Text;

namespace RomanNumbers
{
    public class RomanNumbers
    {

        private readonly SortedDictionary<int, string> _romanNumeralsLookup = new SortedDictionary<int, string>
        {
            {1000, "M"},
            {900, "CM"},
            {500, "D"},
            {400, "CD"},
            {100, "C"},
            {90, "XC"},
            {40, "XL"},
            {50, "L"},
            {10, "X"},
            {9, "IX"},
            {5, "V"},
            {4, "IV"},
            {1, "I"},
        };

        public string Convert(int amount) =>
            (amount <= 0 || amount >= 4000) ? "Invalid number" :
                _romanNumeralsLookup.Keys.Reverse()
                    .Aggregate("", (result, number) =>
                    {
                        while (amount >= number)
                        {
                            result += _romanNumeralsLookup[number];
                            amount -= number;
                        }

                        return result;
                    });

    }
}
