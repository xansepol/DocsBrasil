using DocsBrasil.Enums;
using DocsBrasil.Helpers.Pessoa;
using DocsBrasil.Helpers.Veiculo;
namespace DocsBrasil.Fakes
{
    public static class Gerador
    {
        public static string Placa()
        {
            int i = Random.Shared.Next(2);
            return PlateHelper.Generate(i == 0 ? true : false);
        }

        public static string PlacaMercosul() => PlateHelper.Generate(true);
        public static string PlacaCinza() => PlateHelper.Generate();

        public static string[] Placas(int quantidade)
        {
            if(quantidade <= 0)
                return Enumerable.Empty<string>().ToArray();

            return Enumerable.Range(1, quantidade).Select((i) => Placa()).ToArray();
        }

        public static string[] PlacasMercosul(int quantidade)
        {
            if (quantidade <= 0)
                return Enumerable.Empty<string>().ToArray();

            return Enumerable.Range(1, quantidade).Select((i) => PlacaMercosul()).ToArray();
        }

        public static string[] PlacasCinza(int quantidade)
        {
            if (quantidade <= 0)
                return Enumerable.Empty<string>().ToArray();

            return Enumerable.Range(1, quantidade).Select((i) => PlacaCinza()).ToArray();
        }


        public static string Renavam() => RenavamHelper.Generate();
        public static string[] Renavams(int quantidade)
        {
            if (quantidade <= 0)
                return Enumerable.Empty<string>().ToArray();

            return Enumerable.Range(1, quantidade).Select((i) => Renavam()).ToArray();
        }

        public static string Cpf() => CpfHelper.Generate(UnidadesFederativas.NI);
        public static string Cpf(UnidadesFederativas uf) => CpfHelper.Generate(uf);
        public static string[] Cpfs(int quantidade)
        {
            if (quantidade <= 0)
                return Enumerable.Empty<string>().ToArray();

            return Enumerable.Range(1, quantidade).Select((i) => Cpf()).ToArray();
        }

        public static string[] Cpfs(int quantidade, UnidadesFederativas uf)
        {
            if (quantidade <= 0)
                return Enumerable.Empty<string>().ToArray();

            return Enumerable.Range(1, quantidade).Select((i) => Cpf(uf)).ToArray();
        }

        public static string Cnpj(int sequencia = 1) => CnpjHelper.Generate(sequencia);

        public static string[] Cnpjs(int quantidade, int sequencia = 1)
        {
            if (quantidade <= 0)
                return Enumerable.Empty<string>().ToArray();

            return Enumerable.Range(1, quantidade).Select((i) => Cnpj(sequencia)).ToArray();
        }
    }
}
