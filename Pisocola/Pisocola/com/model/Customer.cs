using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pisocola.com.model
{
    public class Customer
    {

        private int idCustomer;
        private string nmCustomer;
        private string nmSocial;
        private string nrCpfCnpj;
        private string nrInsc;
        private string dsAddress;
        private string nrPhone;
        private DateTime dtInsert;
        private DateTime dtLastSell;

        public int GetIdCustomer()
        {
            return idCustomer;
        }

        public void SetIdCustomer(int idCustomer)
        {
            this.idCustomer = idCustomer;
        }

        public string GetNmCustomer()
        {
            return nmCustomer;
        }

        public void SetNmCustomer(string nmCustomer)
        {
            this.nmCustomer = nmCustomer;
        }

        public string GetNmSocial()
        {
            return nmSocial;
        }

        public void SetNmSocial(string nmSocial)
        {
            this.nmSocial = nmSocial;
        }

        public string GetNrCpfCnpj()
        {
            return nrCpfCnpj;
        }

        public void SetNrCpfCnpj(string nrCpfCnpj)
        {
            this.nrCpfCnpj = nrCpfCnpj;
        }

        public string GetNrInsc()
        {
            return nrInsc;
        }

        public void SetNrInsc(string nrInsc)
        {
            this.nrInsc = nrInsc;
        }

        public string GetDsAddress()
        {
            return dsAddress;
        }

        public void SetDsAddress(string dsAddress)
        {
            this.dsAddress = dsAddress;
        }

        public string GetNrPhone()
        {
            return nrPhone;
        }

        public void SetNrPhone(string nrPhone)
        {
            this.nrPhone = nrPhone;
        }

        public DateTime GetDtInsert()
        {
            return dtInsert;
        }

        public void SetDtInsert(DateTime dtInsert)
        {
            this.dtInsert = dtInsert;
        }

        public DateTime GetDtLastSell()
        {
            return dtLastSell;
        }

        public void SetDtLastSell(DateTime dtLastSell)
        {
            this.dtLastSell = dtLastSell;
        }

    }
}
