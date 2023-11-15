using System.Text.RegularExpressions;

namespace DocsBrasil.Helpers.Veiculo
{
    internal static class RenavamHelper
    {
        internal static bool Check(string renavam)
        {
            if (String.IsNullOrWhiteSpace(renavam) || renavam.Length > 11)
                return false;

            if (Regex.IsMatch(renavam, "\\D"))
                return false;

            renavam = renavam.PadLeft(11, '0');

            int dv = (int)char.GetNumericValue(renavam[renavam.Length - 1]);
            string resto = renavam.Substring(0, 10);
            return GetDigitoVerificador(resto) == dv;
        }

        private static int GetDigitoVerificador(string dados)
        {
            int soma = 0;
            int digitoMultiplicador = 2;
            for (int i = dados.Length - 1; i >= 0; i--)
            {
                if (digitoMultiplicador > 9)
                    digitoMultiplicador = 2;
                soma += ((int)char.GetNumericValue(dados[i])) * digitoMultiplicador;
                digitoMultiplicador++;
            }

            int calc = 11 - (soma % 11);
            if (calc > 9)
                calc = 0;

            return calc;
        }

        internal static string Generate()
        {
            int[] numbers = Enumerable.Range(1, 10)
                                          .Select(i => Random.Shared.Next(0, 10))
                                          .ToArray();

            List<char> charRenavam = new List<char>();
            foreach (int n in numbers)
                charRenavam.AddRange(n.ToString());

            string partialRenavam = new string(charRenavam.ToArray());
            return $"{partialRenavam}{GetDigitoVerificador(partialRenavam)}";
        }
    }
}
