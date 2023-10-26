using DocsBrasil.Enums;
using System.Text.RegularExpressions;

namespace DocsBrasil.Helpers.Pessoa
{
    internal static class CpfHelper
    {
        private static readonly int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        private static readonly int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        internal static bool Check(string cpf)
        {
            if (string.IsNullOrWhiteSpace(cpf))
                return false;

            if (!Regex.IsMatch(cpf, "^[\\d\\.-]+$"))
                return false;

            cpf = Regex.Replace(cpf, "\\D", "");
            cpf = cpf.PadLeft(11, '0');
            if (cpf.Length > 11)
                return false;

            if (String.Equals(cpf ,new string(cpf[0], 11)))
                return false;

            string tempCpf = cpf.Substring(0, 9);
            return cpf.EndsWith(GetDigistosVerificadores(tempCpf));
        }

        internal static string Generate(UnidadesFederativas uf)
        {
            int[] numbers = { };
            if (uf == UnidadesFederativas.NI)
                numbers = Enumerable.Range(1, 9)
                                          .Select(i => Random.Shared.Next(0, 10))
                                          .ToArray();
            else
                numbers = Enumerable.Range(1, 8)
                                          .Select(i => Random.Shared.Next(0, 10))
                                          .Append(GetNumberByUF(uf))
                                          .ToArray();

            List<char> charsCpf = new List<char>();
            foreach (int n in numbers)
                charsCpf.AddRange(n.ToString());

            string cpf = new string(charsCpf.ToArray());

            return $"{cpf}{GetDigistosVerificadores(cpf)}";
        }

        private static string GetDigistosVerificadores(string cpf)
        {
            int soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(cpf[i].ToString()) * multiplicador1[i];

            int resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();

            cpf = cpf + digito;

            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(cpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();
            return digito;
        }

        internal static int GetNumberByUF(UnidadesFederativas uf)
        {
            switch (uf)
            {
                case UnidadesFederativas.DF:
                case UnidadesFederativas.GO:
                case UnidadesFederativas.MS:
                case UnidadesFederativas.MT:
                case UnidadesFederativas.TO:
                    return 1;
                case UnidadesFederativas.AC:
                case UnidadesFederativas.PA:
                case UnidadesFederativas.AM:
                case UnidadesFederativas.RR:
                case UnidadesFederativas.RO:
                case UnidadesFederativas.AP:
                    return 2;
                case UnidadesFederativas.CE:
                case UnidadesFederativas.MA:
                case UnidadesFederativas.PI:
                    return 3;
                case UnidadesFederativas.PE:
                case UnidadesFederativas.RN:
                case UnidadesFederativas.PB:
                case UnidadesFederativas.AL:
                    return 4;
                case UnidadesFederativas.BA:
                case UnidadesFederativas.SE:
                    return 5;
                case UnidadesFederativas.MG:
                    return 6;
                case UnidadesFederativas.RJ:
                case UnidadesFederativas.ES:
                    return 7;
                case UnidadesFederativas.SP:
                    return 8;
                case UnidadesFederativas.PR:
                case UnidadesFederativas.SC:
                    return 9;
                case UnidadesFederativas.RS:
                    return 0;
                default:
                    return 0;
            }
        }

    }
}
