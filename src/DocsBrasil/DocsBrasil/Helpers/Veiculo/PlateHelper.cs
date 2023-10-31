using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DocsBrasil.Helpers.Veiculo
{
    internal static class PlateHelper
    {
        internal static bool Check(string plate)
        {
            return Regex.IsMatch(plate, @"^[A-Z]{3}-?\d[\dA-J]\d{2}$", RegexOptions.IgnoreCase);
        }

        internal static bool CheckMercosul(string plate)
        {
            return Regex.IsMatch(plate, @"^[A-Z]{3}-?\d[A-J]\d{2}$", RegexOptions.IgnoreCase);
        }

        internal static bool CheckGray(string plate)
        {
            return Regex.IsMatch(plate, @"^[A-Z]{3}-?\d{4}$", RegexOptions.IgnoreCase);
        }

        internal static string Generate(bool mercosul = false)
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
            return new string(charsPlate);
        }
    }
}
