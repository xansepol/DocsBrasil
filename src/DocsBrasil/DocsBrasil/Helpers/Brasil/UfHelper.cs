using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocsBrasil.Helpers.Brasil
{
    internal static class UfHelper
    {
        internal static bool Check(string uf)
        {
            if(string.IsNullOrWhiteSpace(uf))
                return false;

            switch (uf.ToUpper())
            {
                case "AC":
                case "AM":
                case "AP":
                case "BA":
                case "CE":
                case "DF":
                case "ES":
                case "MG":
                case "MS":
                case "MT":
                case "GO":
                case "MA":
                case "PE":
                case "PB":
                case "PR":
                case "RS":
                case "RN":
                case "RJ":
                case "RO":
                case "RR":
                case "PI":
                case "PA":
                case "SE":
                case "AL":
                case "SC":
                case "SP":
                case "TO":
                    return true;
                default:
                    return false;
            }
        }
    }
}
