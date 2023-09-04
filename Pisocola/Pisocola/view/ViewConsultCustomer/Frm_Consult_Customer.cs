using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pisocola.com.model;
using Pisocola.com.dao;
using System.Collections;

namespace Pisocola
{
    public partial class Frm_Consult_Customer : System.Windows.Forms.Form
    {
        Frm_Initial_Menu initialMenu;

        public Frm_Consult_Customer(Frm_Initial_Menu initialMenu)
        {
            InitializeComponent();

            this.initialMenu = initialMenu;
            Rb_Consult_Cnpj.Checked = true;
        }

        private void Btn_Search_Customer_Click(object sender, EventArgs e)
        {
            LoadCustomerListView();
        }

        private void Btn_Edit_Customer_Click(object sender, EventArgs e)
        {
            EditCustomer();
        }

        private void Inpt_Customer_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (e.KeyChar.ToString()).ToUpper().ToCharArray()[0];
        }

        private void Inpt_Social_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (e.KeyChar.ToString()).ToUpper().ToCharArray()[0];
        }

        private void LoadCustomerListView()
        {
            Grid_Customer_Consult.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            Grid_Customer_Consult.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            Grid_Customer_Consult.Items.Clear();

            Customer c;
            ListViewItem item;

            string where = "";

            if (Inpt_Customer_Name.Text != "")
                where += "AND NM_CUSTOMER LIKE '%" + Inpt_Customer_Name.Text + "%' ";

            if (Inpt_Social_Name.Text != "")
                where += "AND NM_SOCIAL LIKE '%" + Inpt_Social_Name.Text + "%' ";

            if (Rb_Consult_Cpf.Checked)
            {
                if (Inpt_Cpf_Cnpj.Text != "   .   .   -")
                    where += "AND NR_CPF_CNPJ = '" + Inpt_Cpf_Cnpj.Text + "' ";
            }
            else
            {
                if (Inpt_Cpf_Cnpj.Text != "  .   .   /    -")
                    where += "AND NR_CPF_CNPJ = '" + Inpt_Cpf_Cnpj.Text + "' ";
            }

            List<Object> list = CustomerDAO.GetInstance().GetCustomersByWhere(where);
            string[] row = new string[8];

            for (int count = 0; count < list.Count; count++)
            {
                c = (Customer) list[count];

                row[0] = Convert.ToString(c.GetIdCustomer());
                row[1] = c.GetNmCustomer();
                row[2] = c.GetNmSocial();
                row[3] = c.GetNrCpfCnpj();
                row[4] = c.GetNrInsc();
                row[5] = c.GetDsAddress();
                row[6] = c.GetNrPhone();
                row[7] = Convert.ToString(c.GetDtInsert()).Split(' ')[0];

                item = new ListViewItem(row);
                Grid_Customer_Consult.Items.Add(item);
            }

            foreach (ColumnHeader column in Grid_Customer_Consult.Columns)
            {
                column.Width = -2;
            }
        }

        private void EditCustomer()
        {
            try
            {
                Dictionary<string, string> selectedCustomer = new Dictionary<string, string>();

                selectedCustomer.Add("ID_CUSTOMER", Grid_Customer_Consult.SelectedItems[0].SubItems[0].Text);
                selectedCustomer.Add("NM_CUSTOMER", Grid_Customer_Consult.SelectedItems[0].SubItems[1].Text);
                selectedCustomer.Add("NM_SOCIAL", Grid_Customer_Consult.SelectedItems[0].SubItems[2].Text);
                selectedCustomer.Add("NR_CPF_CNPJ", Grid_Customer_Consult.SelectedItems[0].SubItems[3].Text);
                selectedCustomer.Add("NR_INSC", Grid_Customer_Consult.SelectedItems[0].SubItems[4].Text);
                selectedCustomer.Add("DS_ADDRESS", Grid_Customer_Consult.SelectedItems[0].SubItems[5].Text);
                selectedCustomer.Add("NR_PHONE", Grid_Customer_Consult.SelectedItems[0].SubItems[6].Text);

                initialMenu.OpenChildForm(new Frm_New_Customer(selectedCustomer));
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.StackTrace);
                MessageBox.Show("Para editar um cliente, selecione seu ID.", "Atenção");
            }
        }

        private void ChangeCpfCnpjMask()
        {
            Inpt_Cpf_Cnpj.Clear();

            if (Rb_Consult_Cpf.Checked)
            {
                Inpt_Cpf_Cnpj.Mask = @"000,000,000-00";
            }
            else
            {
                Inpt_Cpf_Cnpj.Mask = @"00,000,000/0000-00";
            }
        }

        private void Rb_Consult_Cpf_CheckedChanged(object sender, EventArgs e)
        {
            ChangeCpfCnpjMask();
        }

        private void Rb_Consult_Cnpj_CheckedChanged(object sender, EventArgs e)
        {
            ChangeCpfCnpjMask();
        }

        private void Btn_Delete_Customer_Click(object sender, EventArgs e)
        {
            try
            {
                Customer c = new Customer();

                c.SetIdCustomer(Convert.ToInt32(Grid_Customer_Consult.SelectedItems[0].SubItems[0].Text));
                CustomerDAO.GetInstance().DeleteCustomer(c);

                LoadCustomerListView();
                MessageBox.Show("Usuário deletado com sucesso.", "Concluído");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Para deletar um cliente, selecione seu ID.", "Atenção");
            }
        }
    }
}
