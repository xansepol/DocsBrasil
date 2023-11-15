using DocsBrasil.Utilities;
using System.Text.RegularExpressions;

namespace DocsBrasil.Helpers.Veiculo
{
    internal static class PlateHelper
    {
        internal static bool Check(string plate) => RegexValidation.CheckPlate(plate);

        internal static bool CheckMercosul(string plate) => RegexValidation.CheckMercosulPlate(plate);

        internal static bool CheckGray(string plate) => RegexValidation.CheckGrayPlate(plate);

        internal static string Generate(bool format, bool mercosul)
        {
            Random r = new Random();
            char[] charsPlate =
            {
                Convert.ToChar(r.Next(65, 84)),
                Convert.ToChar(r.Next(65, 91)),
                Convert.ToChar(r.Next(65, 91)),
                Convert.ToChar(r.Next(48, 58)),
                mercosul ? Convert.ToChar(r.Next(65, 75)) : Convert.ToChar(r.Next(48, 58)),
                Convert.ToChar(r.Next(48, 58)),
                Convert.ToChar(r.Next(48, 58))
            };
            return format ? Format(new string(charsPlate)) : new string(charsPlate);
        }

        internal static string Format(string plate)
        {
            if (string.IsNullOrWhiteSpace(plate))
                return String.Empty;

            if (plate.Length != 7)
                return plate;

            return plate.Insert(3, "-");
        }
    }
}
