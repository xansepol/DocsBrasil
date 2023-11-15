using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DocsBrasil.Utilities
{
    internal static partial class RegexValidation
    {
        [GeneratedRegex(@"^[A-Z]{3}-?\d[\dA-J]\d{2}$", RegexOptions.IgnoreCase)]
        private static partial Regex regexPlate();

        [GeneratedRegex(@"^[A-Z]{3}-?\d{4}$", RegexOptions.IgnoreCase)]
        private static partial Regex regexGrayPlate();
        
        [GeneratedRegex(@"^[A-Z]{3}-?\d[A-J]\d{2}$", RegexOptions.IgnoreCase)]
        private static partial Regex regexMercosulPlate();

        [GeneratedRegex(@"\D")]
        private static partial Regex regexNonNumber();

        internal static bool CheckPlate(string plate) => regexPlate().IsMatch(plate);
        internal static bool CheckGrayPlate(string plate) => regexGrayPlate().IsMatch(plate);
        internal static bool CheckMercosulPlate(string plate) => regexMercosulPlate().IsMatch(plate);
        internal static string ClearNonNumber(string text) => regexNonNumber().Replace(text, "");
    }
}
