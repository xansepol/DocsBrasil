using DocsBrasil.Utilities;
using System.Text.RegularExpressions;

namespace DocsBrasil.Helpers.Pessoa
{
    internal static class CnpjHelper
    {
        private static int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
        private static int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
        internal static bool Check(string cnpj)
        {
            if (string.IsNullOrWhiteSpace(cnpj))
                return false;

            if (!Regex.IsMatch(cnpj, "^[\\d\\./-]+$"))
                return false;

            cnpj = RegexValidation.ClearNonNumber(cnpj);
            cnpj = cnpj.PadLeft(14, '0');
            if (cnpj.Length > 14)
                return false;

            if (String.Equals(cnpj, new string(cnpj[0], 14)))
                return false;

            string tempCnpj = cnpj.Substring(0, 12);
            return cnpj.EndsWith(GetDigitoVerificadores(tempCnpj));
        }

        private static string GetDigitoVerificadores(string cnpj)
        {
            int soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(cnpj[i].ToString()) * multiplicador1[i];

            int resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();
            cnpj = cnpj + digito;
            soma = 0;
            
            for (int i = 0; i < 13; i++)
                soma += int.Parse(cnpj[i].ToString()) * multiplicador2[i];

            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

         return digito + resto.ToString();
        }

        internal static string Generate(int sequence, bool format)
        {
            if (sequence <= 0 || sequence > 9999)
                new ArgumentException("Número da sequência inválido");

            string numsSequence = sequence.ToString().PadLeft(4, '0');

            int[] numbers = Enumerable.Range(1, 8)
                                          .Select(i => Random.Shared.Next(0, 10))
                                          .Append(Int32.Parse(numsSequence[0].ToString()))
                                          .Append(Int32.Parse(numsSequence[1].ToString()))
                                          .Append(Int32.Parse(numsSequence[2].ToString()))
                                          .Append(Int32.Parse(numsSequence[3].ToString()))
                                          .ToArray();

            List<char> charsCnpj = new List<char>();
            foreach (int n in numbers)
                charsCnpj.AddRange(n.ToString());

            string partialCnpj = new string(charsCnpj.ToArray());
            string cnpj = $"{partialCnpj}{GetDigitoVerificadores(partialCnpj)}";

            return format ? Format(cnpj) : cnpj;
        }

        internal static string Format(string cnpj)
        {
            cnpj = RegexValidation.ClearNonNumber(cnpj);
            if (string.IsNullOrWhiteSpace(cnpj))
                return String.Empty;

            cnpj = cnpj.PadLeft(14, '0');

            if (cnpj.Length > 14)
                return cnpj;

            return cnpj.Insert(2, ".").Insert(6, ".").Insert(10, "/").Insert(15, "-");
        }
    }
}
