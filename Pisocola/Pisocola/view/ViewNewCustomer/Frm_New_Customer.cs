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

namespace Pisocola
{
    public partial class Frm_New_Customer : Form
    {
        public Frm_New_Customer()
        {
            InitializeComponent();
            InitView();
        }

        public Frm_New_Customer(Dictionary<string, string> customerFields)
        {
            InitializeComponent();

            this.customerFields = customerFields;
            InitView();
        }

        private List<string> emptyfieldsList = null;
        private Dictionary<string, string> customerFields = null;

        private bool editMode = false;
        private bool isNrCpfCnpjValid = true;
        private bool isNrInscValid = true;

        private void InitView()
        {
            Lbl_Valid_Cpf_Cnpj.Visible = false;
            Lbl_Valid_Nr_Insc.Visible = false;

            if (customerFields != null) //Caso a tela esteja em modo de edicao
            {
                Btn_Save_Customer.Text = "Atualizar";

                Inpt_Nm_Customer.Text = customerFields["NM_CUSTOMER"];
                Inpt_Nm_Social.Text = customerFields["NM_SOCIAL"];
                Inpt_Ds_Address.Text = customerFields["DS_ADDRESS"];

                if (customerFields["NR_CPF_CNPJ"].Contains("/"))
                    Rb_New_Cnpj.Checked = true;
                else
                    Rb_New_Cpf.Checked = true;

                Inpt_Cpf_Cnpj.Text = customerFields["NR_CPF_CNPJ"];
                Inpt_Nr_Insc.Text = customerFields["NR_INSC"];
                Inpt_Nr_Phone.Text = customerFields["NR_PHONE"];

                editMode = true;
            }
            else //Caso a tela seja o cadastro de um novo cliente
            {
                editMode = false;
                Rb_New_Cnpj.Checked = true;
            }
        }

        private void SaveCustomer()
        {
            bool isValid = ValidadeFields();

            if (isValid)
            {
                Customer c = new Customer();

                c.SetNmCustomer(Inpt_Nm_Customer.Text);
                c.SetNmSocial(Inpt_Nm_Social.Text);
                c.SetDsAddress(Inpt_Ds_Address.Text);
                c.SetNrCpfCnpj(Inpt_Cpf_Cnpj.Text);
                c.SetNrInsc(Inpt_Nr_Insc.Text);
                c.SetNrPhone(Inpt_Nr_Phone.Text);

                if (editMode)
                {
                    c.SetIdCustomer(Convert.ToInt32(customerFields["ID_CUSTOMER"]));
                    CustomerDAO.GetInstance().UpdateCustomer(c);
                    MessageBox.Show("Cliente atualizado com sucesso!", "Concluído");
                }
                else
                {
                    CustomerDAO.GetInstance().InsertCustomer(c);
                    MessageBox.Show("Cliente cadastrado com sucesso!", "Concluído");
                }
                
                //MessageBox.Show("O CPF/CNPJ já está cadastrado!", "Atenção!");
            }
            else
            {
                string emptyFields = "";

                foreach (string item in emptyfieldsList)
                {
                    emptyFields += item + "\n";
                }

                if(isNrInscValid || isNrCpfCnpjValid)
                    MessageBox.Show("Alguns valores de campos já foram cadastrados.", "Atenção");
                else
                    MessageBox.Show("Alguns campos obrigatórios não foram preenchidos, são eles:\n\n" + emptyFields, "Atenção");

                emptyfieldsList = null;
            }
        }

        private bool ValidadeFields()
        {
            bool isValid = true;
            emptyfieldsList = new List<string>();

            if (isNrInscValid)
                isValid = false;

            if (isNrCpfCnpjValid)
                isValid = false;

            if (Inpt_Nm_Customer.Text == "")
            {
                isValid = false;
                emptyfieldsList.Add("Nome Fantasia");
            }

            if (Inpt_Nm_Social.Text == "")
            {
                isValid = false;
                emptyfieldsList.Add("Nome Social");
            }

            if (Inpt_Ds_Address.Text == "")
            {
                isValid = false;
                emptyfieldsList.Add("Endereço");
            }

            if (Rb_New_Cpf.Checked)
            {
                if(Inpt_Cpf_Cnpj.Text == "   .   .   -")
                {
                    isValid = false;
                    emptyfieldsList.Add("CPF/CNPJ");
                }
            }
            else
            {
                if (Inpt_Cpf_Cnpj.Text == "  .   .   /    -")
                {
                    isValid = false;
                    emptyfieldsList.Add("CPF/CNPJ");
                }
            }

            if (Inpt_Nr_Insc.Text == "       -")
            {
                isValid = false;
                emptyfieldsList.Add("Inscrição");
            }

            return isValid;
        }

        private void Inpt_Nm_Customer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (e.KeyChar.ToString()).ToUpper().ToCharArray()[0];
        }

        private void Inpt_Nm_Social_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (e.KeyChar.ToString()).ToUpper().ToCharArray()[0];
        }

        private void Inpt_Ds_Address_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (e.KeyChar.ToString()).ToUpper().ToCharArray()[0];
        }

        private void ChangeCpfCnpjMask()
        {
            Inpt_Cpf_Cnpj.Clear();

            if (Rb_New_Cpf.Checked)
            {
                Inpt_Cpf_Cnpj.Mask = @"000,000,000-00";
            }
            else
            {
                Inpt_Cpf_Cnpj.Mask = @"00,000,000/0000-00";
            }
        }

        private void Rb_New_Cpf_CheckedChanged(object sender, EventArgs e)
        {
            ChangeCpfCnpjMask();
        }

        private void Rb_New_Cnpj_CheckedChanged(object sender, EventArgs e)
        {
            ChangeCpfCnpjMask();
        }

        private void Btn_Save_Customer_Click(object sender, EventArgs e)
        {
            SaveCustomer();
        }

        private void Inpt_Cpf_Cnpj_KeyUp(object sender, KeyEventArgs e)
        {
            isNrCpfCnpjValid = CustomerDAO.GetInstance().VerifyCpfCnpj(Inpt_Cpf_Cnpj.Text);

            if (isNrCpfCnpjValid)
                Lbl_Valid_Cpf_Cnpj.Visible = true;
            else
                Lbl_Valid_Cpf_Cnpj.Visible = false;
        }

        private void Inpt_Nr_Insc_KeyUp(object sender, KeyEventArgs e)
        {
            isNrInscValid = CustomerDAO.GetInstance().VerifyNrInsc(Inpt_Nr_Insc.Text); isNrInscValid = CustomerDAO.GetInstance().VerifyNrInsc(Inpt_Nr_Insc.Text);

            if (isNrInscValid)
                Lbl_Valid_Nr_Insc.Visible = true;
            else
                Lbl_Valid_Nr_Insc.Visible = false;

            if (isNrInscValid)
                Lbl_Valid_Nr_Insc.Visible = true;
            else
                Lbl_Valid_Nr_Insc.Visible = false;
        }
    }
}
