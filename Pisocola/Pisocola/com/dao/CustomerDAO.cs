using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Pisocola.com.model;

namespace Pisocola.com.dao
{
    public class CustomerDAO : BaseDAO
    {
        private static CustomerDAO instance;

        public static CustomerDAO GetInstance()
        {
            if (instance == null)
                instance = new CustomerDAO();

            return instance;
        }

        public CustomerDAO()
        {
            tableName = "customer";
            columnParam = "ID_CUSTOMER";
        }

        public List<Object> GetCustomers()
        {
            return GetList("SELECT * FROM " + tableName);
        }

        public Customer GetCustomer(int idCustomer)
        {
            return (Customer) GetItem("SELECT * FROM " + tableName + " WHERE 1=1 AND ID_CUSTOMER = " + idCustomer);
        }

        public List<Object> GetCustomersByWhere(string where)
        {
            return GetList("SELECT * FROM " + tableName + " WHERE 1=1 " + where);
        }

        public bool VerifyCpfCnpj(string nrCpfCnpj)
        {
            Customer c = (Customer) GetItem("SELECT * FROM " + tableName + " WHERE 1=1 AND NR_CPF_CNPJ = '" + nrCpfCnpj + "'");

            if (c != null)
                return true;
            else
                return false;
        }

        public bool VerifyNrInsc(string nrInsc)
        {
            Customer c = (Customer) GetItem("SELECT * FROM " + tableName + " WHERE 1=1 AND NR_INSC = '" + nrInsc + "'");

            if (c != null)
                return true;
            else
                return false;
        }

        public Customer InsertCustomer (Customer customer)
        {
            int id = instertItem("INSERT INTO " + tableName + " (NM_CUSTOMER, NM_SOCIAL, NR_CPF_CNPJ, NR_INSC, DS_ADDRESS, NR_PHONE, DT_INSERT) VALUES (@, @, @, @, @, @, SYSDATE())",
                        new Object[] {
                            customer.GetNmCustomer(),
                            customer.GetNmSocial(),
                            customer.GetNrCpfCnpj(),
                            customer.GetNrInsc(),
                            customer.GetDsAddress(),
                            customer.GetNrPhone()
                        });

            return GetCustomer(id);
        }

        public Customer UpdateCustomer(Customer customer)
        {
            return (Customer) UpdateItem("UPDATE " + tableName + " SET NM_CUSTOMER = @,  NM_SOCIAL = @, NR_CPF_CNPJ = @, NR_INSC = @, DS_ADDRESS = @, NR_PHONE = @ WHERE ID_CUSTOMER = @",
                        new Object[] {
                            customer.GetNmCustomer(),
                            customer.GetNmSocial(),
                            customer.GetNrCpfCnpj(),
                            customer.GetNrInsc(),
                            customer.GetDsAddress(),
                            customer.GetNrPhone(),
                            customer.GetIdCustomer()
                        }, customer.GetIdCustomer());
        }

        public void DeleteCustomer(Customer customer)
        {
            DeleteItem("DELETE FROM " + tableName + " WHERE ID_CUSTOMER = @", new Object[] { customer.GetIdCustomer() });
        }

        protected override Dictionary<string, string> ProcessRowNoCast(MySqlDataReader data)
        {
            Dictionary<string, string> d = new Dictionary<string, string>();

            for (int count = 0; count < data.FieldCount; count++)
            {
                d.Add(data.GetName(count), Convert.ToString(data.GetValue(count)));
            }

            return d;
        }

        protected override Object ProcessRow(MySqlDataReader data)
        {
            Customer customer = new Customer();

            customer.SetIdCustomer((int) data["ID_CUSTOMER"]);
            customer.SetNmCustomer((string) data["NM_CUSTOMER"]);
            customer.SetNmSocial((string) data["NM_SOCIAL"]);
            customer.SetNrCpfCnpj((string) data["NR_CPF_CNPJ"]);
            customer.SetNrInsc((string) data["NR_INSC"]);
            customer.SetDsAddress((string) data["DS_ADDRESS"]);
            customer.SetNrPhone((string) data["NR_PHONE"]);
            customer.SetDtInsert((DateTime) data["DT_INSERT"]);
            customer.SetDtLastSell((DateTime) data["DT_LAST_SELL"]);

            return customer;
        }

    }
}
