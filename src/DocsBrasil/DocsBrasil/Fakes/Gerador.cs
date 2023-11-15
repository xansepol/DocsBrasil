using DocsBrasil.Enums;
using DocsBrasil.Helpers.Pessoa;
using DocsBrasil.Helpers.Veiculo;
namespace DocsBrasil.Fakes
{
    public static class Gerador
    {
        public static string Placa(bool format = false)
        {
            int i = Random.Shared.Next(2);
            return PlateHelper.Generate(format, i == 0 ? true : false);
        }

        public static string PlacaMercosul(bool format = false) => PlateHelper.Generate(format, true);
        public static string PlacaCinza(bool format = false) => PlateHelper.Generate(format, false);

        public static string[] Placas(int quantidade, bool format = false)
        {
            if(quantidade <= 0)
                return Enumerable.Empty<string>().ToArray();

            return Enumerable.Range(1, quantidade).Select((i) => Placa(format)).ToArray();
        }

        public static string[] PlacasMercosul(int quantidade, bool format = false)
        {
            if (quantidade <= 0)
                return Enumerable.Empty<string>().ToArray();

            return Enumerable.Range(1, quantidade).Select((i) => PlacaMercosul(format)).ToArray();
        }

        public static string[] PlacasCinza(int quantidade, bool format = false)
        {
            if (quantidade <= 0)
                return Enumerable.Empty<string>().ToArray();
            return Enumerable.Range(1, quantidade).Select((i) => PlacaCinza(format)).ToArray();
        }


        public static string Renavam() => RenavamHelper.Generate();
        public static string[] Renavams(int quantidade)
        {
            if (quantidade <= 0)
                return Enumerable.Empty<string>().ToArray();

            return Enumerable.Range(1, quantidade).Select((i) => Renavam()).ToArray();
        }

        public static string Cpf(bool format = false) => CpfHelper.Generate(UnidadesFederativas.NI, format);
        public static string Cpf(UnidadesFederativas uf, bool format = false) => CpfHelper.Generate(uf, format);
        public static string[] Cpfs(int quantidade, bool format = false)
        {
            if (quantidade <= 0)
                return Enumerable.Empty<string>().ToArray();

            return Enumerable.Range(1, quantidade).Select((i) => Cpf(format)).ToArray();
        }

        public static string[] Cpfs(int quantidade, UnidadesFederativas uf, bool format = false)
        {
            if (quantidade <= 0)
                return Enumerable.Empty<string>().ToArray();

            return Enumerable.Range(1, quantidade).Select((i) => Cpf(uf, format)).ToArray();
        }

        public static string Cnpj(int sequencia = 1, bool format = false) => CnpjHelper.Generate(sequencia, format);

        public static string[] Cnpjs(int quantidade, int sequencia = 1, bool format = false)
        {
            if (quantidade <= 0)
                return Enumerable.Empty<string>().ToArray();

            return Enumerable.Range(1, quantidade).Select((i) => Cnpj(sequencia, format)).ToArray();
        }
    }
}
