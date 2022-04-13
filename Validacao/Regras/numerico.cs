using System;

namespace INSS.Validacao.Regras
{
    public class numerico
    {

        public static bool IsDecimal(string value)
        {

            return Decimal.TryParse(value, out decimal number);

        }

        public static bool IsNumeric(string input)
        {
            return int.TryParse(input, out int test);
        }

        public static bool IsNumericPositive(string input)
        {
            if (int.TryParse(input, out int test) && int.Parse(input) > 0)
            { return true; }
            else
            {
                return false;
            }

        }

        public static bool IsDate(string input)
        {
            return DateTime.TryParse(input, out DateTime test);
        }

        public static bool IsZeroNegativo(string input)
        {
            if (Decimal.TryParse(input, out decimal number))
            {
                return Decimal.Parse(input) <= 0 ? true : false;
            }
            return false;
        }

        public numerico() { }
    }
}
