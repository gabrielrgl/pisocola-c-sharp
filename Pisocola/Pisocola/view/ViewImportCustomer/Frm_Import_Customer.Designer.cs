namespace Pisocola
{
    partial class Frm_Import_Customer
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Grid_Import_Lines = new System.Windows.Forms.ListView();
            this.Field_Nr_Line = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Field_Nm_Customer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Field_Nm_Social = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Field_Nr_Cpf_Cnpj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Field_Nr_Insc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Field_Ds_Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Field_Nr_Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Btn_Select_File = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Grid_Invalid_Lines = new System.Windows.Forms.ListView();
            this.Field_Nr_Line_Error = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Field_Ds_Error = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Import = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Grid_Import_Lines
            // 
            this.Grid_Import_Lines.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid_Import_Lines.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Field_Nr_Line,
            this.Field_Nm_Customer,
            this.Field_Nm_Social,
            this.Field_Nr_Cpf_Cnpj,
            this.Field_Nr_Insc,
            this.Field_Ds_Address,
            this.Field_Nr_Phone});
            this.Grid_Import_Lines.HideSelection = false;
            this.Grid_Import_Lines.Location = new System.Drawing.Point(12, 63);
            this.Grid_Import_Lines.Name = "Grid_Import_Lines";
            this.Grid_Import_Lines.Size = new System.Drawing.Size(1300, 237);
            this.Grid_Import_Lines.TabIndex = 13;
            this.Grid_Import_Lines.UseCompatibleStateImageBehavior = false;
            this.Grid_Import_Lines.View = System.Windows.Forms.View.Details;
            // 
            // Field_Nr_Line
            // 
            this.Field_Nr_Line.Text = "Nr. Linha";
            // 
            // Field_Nm_Customer
            // 
            this.Field_Nm_Customer.Text = "Nome do Cliente";
            // 
            // Field_Nm_Social
            // 
            this.Field_Nm_Social.Text = "Nome Social";
            // 
            // Field_Nr_Cpf_Cnpj
            // 
            this.Field_Nr_Cpf_Cnpj.Text = "CPF/CNPJ";
            // 
            // Field_Nr_Insc
            // 
            this.Field_Nr_Insc.Text = "Inscrição";
            // 
            // Field_Ds_Address
            // 
            this.Field_Ds_Address.Text = "Endereço";
            // 
            // Field_Nr_Phone
            // 
            this.Field_Nr_Phone.Text = "Telefone";
            // 
            // Btn_Select_File
            // 
            this.Btn_Select_File.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Select_File.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.Btn_Select_File.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Select_File.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Select_File.ForeColor = System.Drawing.Color.White;
            this.Btn_Select_File.Location = new System.Drawing.Point(1154, 9);
            this.Btn_Select_File.Name = "Btn_Select_File";
            this.Btn_Select_File.Size = new System.Drawing.Size(158, 31);
            this.Btn_Select_File.TabIndex = 14;
            this.Btn_Select_File.Text = "Selecionar Arquivo";
            this.Btn_Select_File.UseVisualStyleBackColor = false;
            this.Btn_Select_File.Click += new System.EventHandler(this.Btn_Select_File_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(293, 31);
            this.label6.TabIndex = 18;
            this.label6.Text = "Importação de Clientes";
            // 
            // Grid_Invalid_Lines
            // 
            this.Grid_Invalid_Lines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid_Invalid_Lines.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Field_Nr_Line_Error,
            this.Field_Ds_Error});
            this.Grid_Invalid_Lines.HideSelection = false;
            this.Grid_Invalid_Lines.Location = new System.Drawing.Point(12, 337);
            this.Grid_Invalid_Lines.Name = "Grid_Invalid_Lines";
            this.Grid_Invalid_Lines.Size = new System.Drawing.Size(1300, 212);
            this.Grid_Invalid_Lines.TabIndex = 19;
            this.Grid_Invalid_Lines.UseCompatibleStateImageBehavior = false;
            this.Grid_Invalid_Lines.View = System.Windows.Forms.View.Details;
            // 
            // Field_Nr_Line_Error
            // 
            this.Field_Nr_Line_Error.Text = "Nr. Linha";
            // 
            // Field_Ds_Error
            // 
            this.Field_Ds_Error.Text = "Tipo do Erro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 31);
            this.label1.TabIndex = 20;
            this.label1.Text = "Linhas Inválidas";
            // 
            // Btn_Import
            // 
            this.Btn_Import.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Import.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.Btn_Import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Import.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Import.ForeColor = System.Drawing.Color.White;
            this.Btn_Import.Location = new System.Drawing.Point(990, 9);
            this.Btn_Import.Name = "Btn_Import";
            this.Btn_Import.Size = new System.Drawing.Size(158, 31);
            this.Btn_Import.TabIndex = 21;
            this.Btn_Import.Text = "Importar";
            this.Btn_Import.UseVisualStyleBackColor = false;
            this.Btn_Import.Click += new System.EventHandler(this.Btn_Import_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(457, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Utilizar separador ponto e vírgula (;) para realizar a importação de CSV";
            // 
            // Frm_Import_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1324, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Import);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Grid_Invalid_Lines);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Btn_Select_File);
            this.Controls.Add(this.Grid_Import_Lines);
            this.Name = "Frm_Import_Customer";
            this.Text = "Importação de Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListView Grid_Import_Lines;
        private System.Windows.Forms.Button Btn_Select_File;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView Grid_Invalid_Lines;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader Field_Nr_Line;
        private System.Windows.Forms.ColumnHeader Field_Nm_Customer;
        private System.Windows.Forms.ColumnHeader Field_Nm_Social;
        private System.Windows.Forms.ColumnHeader Field_Nr_Cpf_Cnpj;
        private System.Windows.Forms.ColumnHeader Field_Nr_Insc;
        private System.Windows.Forms.ColumnHeader Field_Ds_Address;
        private System.Windows.Forms.ColumnHeader Field_Nr_Phone;
        private System.Windows.Forms.ColumnHeader Field_Nr_Line_Error;
        private System.Windows.Forms.ColumnHeader Field_Ds_Error;
        private System.Windows.Forms.Button Btn_Import;
        private System.Windows.Forms.Label label2;
    }
}