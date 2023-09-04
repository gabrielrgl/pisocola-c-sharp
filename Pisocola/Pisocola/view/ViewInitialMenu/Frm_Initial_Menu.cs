using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Pisocola
{
    public partial class Frm_Initial_Menu : System.Windows.Forms.Form
    {
        public Frm_Initial_Menu()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private System.Windows.Forms.Form activeForm = null;

        private void CustomizeDesign()
        {
            //Panel_Customer_SubMenu.Visible = false;
            Panel_Seller_SubMenu.Visible = false;
        }

        private void HideSubMenu()
        {
            if (Panel_Customer_SubMenu.Visible == true)
                Panel_Customer_SubMenu.Visible = false;
            if (Panel_Seller_SubMenu.Visible == true)
                Panel_Seller_SubMenu.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {

            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }

        }

        private void Btn_Customer_Menu_Click(object sender, EventArgs e)
        {
            //ShowSubMenu(Panel_Customer_SubMenu);
        }

        private void Btn_Seller_Menu_Click(object sender, EventArgs e)
        {
            //ShowSubMenu(Panel_Seller_SubMenu);
        }

        private void Btn_Consult_Customer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_Consult_Customer((Frm_Initial_Menu) Form.ActiveForm));
            //HideSubMenu();
        }

        private void Btn_Register_Customer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_New_Customer());
            //HideSubMenu();
        }

        private void Btn_Import_Customer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_Import_Customer());
            //HideSubMenu();
        }

        public void OpenChildForm(System.Windows.Forms.Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Panel_Child_Form.Controls.Add(childForm);
            Panel_Child_Form.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
