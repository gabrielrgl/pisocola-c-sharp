namespace Pisocola
{
    partial class Frm_New_Customer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.Inpt_Nm_Customer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Inpt_Nm_Social = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Inpt_Ds_Address = new System.Windows.Forms.TextBox();
            this.Rb_New_Cpf = new System.Windows.Forms.RadioButton();
            this.Rb_New_Cnpj = new System.Windows.Forms.RadioButton();
            this.Inpt_Cpf_Cnpj = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Inpt_Nr_Insc = new System.Windows.Forms.MaskedTextBox();
            this.Inpt_Nr_Phone = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_Save_Customer = new System.Windows.Forms.Button();
            this.Lbl_Valid_Cpf_Cnpj = new System.Windows.Forms.Label();
            this.Lbl_Valid_Nr_Insc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(268, 31);
            this.label6.TabIndex = 17;
            this.label6.Text = "Cadastro de Clientes";
            // 
            // Inpt_Nm_Customer
            // 
            this.Inpt_Nm_Customer.Location = new System.Drawing.Point(12, 64);
            this.Inpt_Nm_Customer.Name = "Inpt_Nm_Customer";
            this.Inpt_Nm_Customer.Size = new System.Drawing.Size(230, 20);
            this.Inpt_Nm_Customer.TabIndex = 18;
            this.Inpt_Nm_Customer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Inpt_Nm_Customer_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(2);
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nome Fantasia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(2);
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nome Social";
            // 
            // Inpt_Nm_Social
            // 
            this.Inpt_Nm_Social.Location = new System.Drawing.Point(12, 111);
            this.Inpt_Nm_Social.Name = "Inpt_Nm_Social";
            this.Inpt_Nm_Social.Size = new System.Drawing.Size(230, 20);
            this.Inpt_Nm_Social.TabIndex = 21;
            this.Inpt_Nm_Social.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Inpt_Nm_Social_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(2);
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "Endereço";
            // 
            // Inpt_Ds_Address
            // 
            this.Inpt_Ds_Address.Location = new System.Drawing.Point(12, 158);
            this.Inpt_Ds_Address.Name = "Inpt_Ds_Address";
            this.Inpt_Ds_Address.Size = new System.Drawing.Size(230, 20);
            this.Inpt_Ds_Address.TabIndex = 23;
            this.Inpt_Ds_Address.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Inpt_Ds_Address_KeyPress);
            // 
            // Rb_New_Cpf
            // 
            this.Rb_New_Cpf.AutoSize = true;
            this.Rb_New_Cpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.Rb_New_Cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Rb_New_Cpf.Location = new System.Drawing.Point(12, 184);
            this.Rb_New_Cpf.Name = "Rb_New_Cpf";
            this.Rb_New_Cpf.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Rb_New_Cpf.Size = new System.Drawing.Size(55, 21);
            this.Rb_New_Cpf.TabIndex = 25;
            this.Rb_New_Cpf.TabStop = true;
            this.Rb_New_Cpf.Text = "CPF";
            this.Rb_New_Cpf.UseVisualStyleBackColor = false;
            this.Rb_New_Cpf.CheckedChanged += new System.EventHandler(this.Rb_New_Cpf_CheckedChanged);
            // 
            // Rb_New_Cnpj
            // 
            this.Rb_New_Cnpj.AutoSize = true;
            this.Rb_New_Cnpj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.Rb_New_Cnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Rb_New_Cnpj.Location = new System.Drawing.Point(70, 184);
            this.Rb_New_Cnpj.Name = "Rb_New_Cnpj";
            this.Rb_New_Cnpj.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Rb_New_Cnpj.Size = new System.Drawing.Size(64, 21);
            this.Rb_New_Cnpj.TabIndex = 26;
            this.Rb_New_Cnpj.TabStop = true;
            this.Rb_New_Cnpj.Text = "CNPJ";
            this.Rb_New_Cnpj.UseVisualStyleBackColor = false;
            this.Rb_New_Cnpj.CheckedChanged += new System.EventHandler(this.Rb_New_Cnpj_CheckedChanged);
            // 
            // Inpt_Cpf_Cnpj
            // 
            this.Inpt_Cpf_Cnpj.Location = new System.Drawing.Point(12, 211);
            this.Inpt_Cpf_Cnpj.Mask = "00,000,000/0000-00";
            this.Inpt_Cpf_Cnpj.Name = "Inpt_Cpf_Cnpj";
            this.Inpt_Cpf_Cnpj.Size = new System.Drawing.Size(107, 20);
            this.Inpt_Cpf_Cnpj.TabIndex = 27;
            this.Inpt_Cpf_Cnpj.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Inpt_Cpf_Cnpj_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 234);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(2);
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 28;
            this.label4.Text = "Inscrição";
            // 
            // Inpt_Nr_Insc
            // 
            this.Inpt_Nr_Insc.Location = new System.Drawing.Point(12, 258);
            this.Inpt_Nr_Insc.Mask = "0000000-00";
            this.Inpt_Nr_Insc.Name = "Inpt_Nr_Insc";
            this.Inpt_Nr_Insc.Size = new System.Drawing.Size(73, 20);
            this.Inpt_Nr_Insc.TabIndex = 29;
            this.Inpt_Nr_Insc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Inpt_Nr_Insc_KeyUp);
            // 
            // Inpt_Nr_Phone
            // 
            this.Inpt_Nr_Phone.Location = new System.Drawing.Point(12, 305);
            this.Inpt_Nr_Phone.Mask = "00000-0000";
            this.Inpt_Nr_Phone.Name = "Inpt_Nr_Phone";
            this.Inpt_Nr_Phone.Size = new System.Drawing.Size(91, 20);
            this.Inpt_Nr_Phone.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 281);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(2);
            this.label5.Size = new System.Drawing.Size(68, 21);
            this.label5.TabIndex = 30;
            this.label5.Text = "Telefone";
            // 
            // Btn_Save_Customer
            // 
            this.Btn_Save_Customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.Btn_Save_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Save_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Save_Customer.Location = new System.Drawing.Point(12, 331);
            this.Btn_Save_Customer.Name = "Btn_Save_Customer";
            this.Btn_Save_Customer.Size = new System.Drawing.Size(101, 31);
            this.Btn_Save_Customer.TabIndex = 32;
            this.Btn_Save_Customer.Text = "Cadastrar";
            this.Btn_Save_Customer.UseVisualStyleBackColor = false;
            this.Btn_Save_Customer.Click += new System.EventHandler(this.Btn_Save_Customer_Click);
            // 
            // Lbl_Valid_Cpf_Cnpj
            // 
            this.Lbl_Valid_Cpf_Cnpj.AutoSize = true;
            this.Lbl_Valid_Cpf_Cnpj.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Valid_Cpf_Cnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Valid_Cpf_Cnpj.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Valid_Cpf_Cnpj.Location = new System.Drawing.Point(125, 212);
            this.Lbl_Valid_Cpf_Cnpj.Name = "Lbl_Valid_Cpf_Cnpj";
            this.Lbl_Valid_Cpf_Cnpj.Size = new System.Drawing.Size(195, 17);
            this.Lbl_Valid_Cpf_Cnpj.TabIndex = 33;
            this.Lbl_Valid_Cpf_Cnpj.Text = "Este valor já está cadastrado!";
            // 
            // Lbl_Valid_Nr_Insc
            // 
            this.Lbl_Valid_Nr_Insc.AutoSize = true;
            this.Lbl_Valid_Nr_Insc.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Valid_Nr_Insc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Valid_Nr_Insc.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Valid_Nr_Insc.Location = new System.Drawing.Point(91, 259);
            this.Lbl_Valid_Nr_Insc.Name = "Lbl_Valid_Nr_Insc";
            this.Lbl_Valid_Nr_Insc.Size = new System.Drawing.Size(195, 17);
            this.Lbl_Valid_Nr_Insc.TabIndex = 34;
            this.Lbl_Valid_Nr_Insc.Text = "Este valor já está cadastrado!";
            // 
            // Frm_New_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.Lbl_Valid_Nr_Insc);
            this.Controls.Add(this.Lbl_Valid_Cpf_Cnpj);
            this.Controls.Add(this.Btn_Save_Customer);
            this.Controls.Add(this.Inpt_Nr_Phone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Inpt_Nr_Insc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Inpt_Cpf_Cnpj);
            this.Controls.Add(this.Rb_New_Cnpj);
            this.Controls.Add(this.Rb_New_Cpf);
            this.Controls.Add(this.Inpt_Ds_Address);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Inpt_Nm_Social);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Inpt_Nm_Customer);
            this.Controls.Add(this.label6);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Frm_New_Customer";
            this.Text = "Frm_New_Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Inpt_Nm_Customer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Inpt_Nm_Social;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Inpt_Ds_Address;
        private System.Windows.Forms.RadioButton Rb_New_Cpf;
        private System.Windows.Forms.RadioButton Rb_New_Cnpj;
        private System.Windows.Forms.MaskedTextBox Inpt_Cpf_Cnpj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox Inpt_Nr_Insc;
        private System.Windows.Forms.MaskedTextBox Inpt_Nr_Phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_Save_Customer;
        private System.Windows.Forms.Label Lbl_Valid_Cpf_Cnpj;
        private System.Windows.Forms.Label Lbl_Valid_Nr_Insc;
    }
}