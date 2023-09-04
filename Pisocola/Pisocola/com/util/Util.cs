using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pisocola.com.util
{
    class Util
    {

        public static bool ValidateCpfCnpj(string nrCpfCnpj)
        {
            //Formato para CPF deve ser: 000.000.000-00
            //Formato para CNPJ deve ser: 00.000.000/0000-00

            bool formatValid = true;
            bool cpfFormat = true;
            bool cnpjFormat = true;

            if (nrCpfCnpj.Length == 14)
            {
                cpfFormat = nrCpfCnpj.Substring(3, 1) == "."
                          && nrCpfCnpj.Substring(7, 1) == "."
                          && nrCpfCnpj.Substring(11, 1) == "-";

                formatValid = cpfFormat;
            }
            else if (nrCpfCnpj.Length == 18)
            {
                cnpjFormat = nrCpfCnpj.Substring(2, 1) == "."
                            && nrCpfCnpj.Substring(6, 1) == "."
                            && nrCpfCnpj.Substring(10, 1) == "/"
                            && nrCpfCnpj.Substring(15, 1) == "-";

                formatValid = cnpjFormat;
            } else
            {
                return false;
            }

            string noMask = nrCpfCnpj;

            noMask = noMask.Replace(".", "");
            noMask = noMask.Replace("/", "");
            noMask = noMask.Replace("-", "");

            bool onlyNumbers = noMask.All(char.IsDigit);

            if (formatValid && onlyNumbers)
                return true;
            else
                return false;
        }

        public static bool ValidateNrPhone(string nrPhone)
        {
            //Formato para numero de telefone deve ser: 00000-0000

            if (nrPhone.Length != 10)
                return false;

            bool formatValid = nrPhone.Substring(5, 1) == "-";

            string noMask = nrPhone;
            noMask = noMask.Replace("-", "");

            bool onlyNumbers = noMask.All(char.IsDigit);
           
            if (formatValid && onlyNumbers)
                return true;
            else
                return false;
        }

        public static bool ValidateNrInsc(string nrInsc)
        {
            //Formato para numero de inscricao deve ser: 0000000-00

            if (nrInsc.Length != 10)
                return false;

            bool formatValid = nrInsc.Substring(7, 1) == "-";

            string noMask = nrInsc;
            noMask = noMask.Replace("-", "");

            bool onlyNumbers = noMask.All(char.IsDigit);

            if (formatValid && onlyNumbers)
                return true;
            else
                return false;
        }

    }
}
