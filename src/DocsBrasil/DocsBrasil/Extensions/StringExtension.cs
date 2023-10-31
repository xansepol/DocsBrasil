using DocsBrasil.Helpers.Pessoa;
using DocsBrasil.Helpers.Veiculo;

namespace DocsBrasil.Extensions
{
    public static class StringExtension
    {
        public static bool IsPlaca(this string placa) => PlateHelper.Check(placa);
        public static bool IsPlacaMercosul(this string placa) => PlateHelper.CheckMercosul(placa);
        public static bool IsPlacaCinza(this string placa) => PlateHelper.CheckGray(placa);
        public static bool IsRenavam(this string renavam) => RenavamHelper.Check(renavam);
        public static bool IsCpf(this string cpf) => CpfHelper.Check(cpf);
        public static bool IsCnpj(this string cnpj) => CnpjHelper.Check(cnpj);
    }
}
