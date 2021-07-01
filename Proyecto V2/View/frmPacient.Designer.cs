
namespace Proyecto_V2
{
    partial class frmPacient
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPacient));
            this.txtDUI = new System.Windows.Forms.TextBox();
            this.txtadress_pacient = new System.Windows.Forms.TextBox();
            this.txtname_pacient = new System.Windows.Forms.TextBox();
            this.txtemail_pacient = new System.Windows.Forms.TextBox();
            this.txtphone_pacient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbdisease = new System.Windows.Forms.ComboBox();
            this.cmbpriority = new System.Windows.Forms.ComboBox();
            this.cmbinstitution = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.btncreate_pacient = new System.Windows.Forms.Button();
            this.btncancel_pacient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDUI
            // 
            this.txtDUI.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDUI.Location = new System.Drawing.Point(140, 12);
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(124, 23);
            this.txtDUI.TabIndex = 0;
            // 
            // txtadress_pacient
            // 
            this.txtadress_pacient.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtadress_pacient.Location = new System.Drawing.Point(140, 94);
            this.txtadress_pacient.Name = "txtadress_pacient";
            this.txtadress_pacient.Size = new System.Drawing.Size(124, 23);
            this.txtadress_pacient.TabIndex = 1;
            // 
            // txtname_pacient
            // 
            this.txtname_pacient.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtname_pacient.Location = new System.Drawing.Point(140, 53);
            this.txtname_pacient.Name = "txtname_pacient";
            this.txtname_pacient.Size = new System.Drawing.Size(124, 23);
            this.txtname_pacient.TabIndex = 2;
            // 
            // txtemail_pacient
            // 
            this.txtemail_pacient.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtemail_pacient.Location = new System.Drawing.Point(140, 135);
            this.txtemail_pacient.Name = "txtemail_pacient";
            this.txtemail_pacient.Size = new System.Drawing.Size(124, 23);
            this.txtemail_pacient.TabIndex = 3;
            // 
            // txtphone_pacient
            // 
            this.txtphone_pacient.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtphone_pacient.Location = new System.Drawing.Point(140, 176);
            this.txtphone_pacient.Name = "txtphone_pacient";
            this.txtphone_pacient.Size = new System.Drawing.Size(124, 23);
            this.txtphone_pacient.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 41);
            this.label1.TabIndex = 5;
            this.label1.Text = "DUI:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enfermedad:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Correo electronico:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Direccion:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nombre:";
            // 
            // cmbdisease
            // 
            this.cmbdisease.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbdisease.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdisease.FormattingEnabled = true;
            this.cmbdisease.Location = new System.Drawing.Point(140, 217);
            this.cmbdisease.Name = "cmbdisease";
            this.cmbdisease.Size = new System.Drawing.Size(124, 23);
            this.cmbdisease.TabIndex = 12;
            // 
            // cmbpriority
            // 
            this.cmbpriority.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbpriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbpriority.FormattingEnabled = true;
            this.cmbpriority.Location = new System.Drawing.Point(140, 299);
            this.cmbpriority.Name = "cmbpriority";
            this.cmbpriority.Size = new System.Drawing.Size(124, 23);
            this.cmbpriority.TabIndex = 13;
            // 
            // cmbinstitution
            // 
            this.cmbinstitution.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbinstitution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbinstitution.FormattingEnabled = true;
            this.cmbinstitution.Location = new System.Drawing.Point(140, 258);
            this.cmbinstitution.Name = "cmbinstitution";
            this.cmbinstitution.Size = new System.Drawing.Size(124, 23);
            this.cmbinstitution.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tipo de institucion:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Grupo de prioridadL";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtDUI, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtname_pacient, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmbpriority, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.cmbinstitution, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtadress_pacient, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmbdisease, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtemail_pacient, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtphone_pacient, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(258, 74);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.020408F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.2449F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.2449F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.2449F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.2449F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.2449F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.2449F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.2449F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.2449F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.020408F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(274, 337);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(245, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(318, 21);
            this.label9.TabIndex = 19;
            this.label9.Text = "Bienvenido, llenar los siguientes datos!";
            // 
            // btncreate_pacient
            // 
            this.btncreate_pacient.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btncreate_pacient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncreate_pacient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncreate_pacient.Location = new System.Drawing.Point(12, 320);
            this.btncreate_pacient.Name = "btncreate_pacient";
            this.btncreate_pacient.Size = new System.Drawing.Size(113, 47);
            this.btncreate_pacient.TabIndex = 20;
            this.btncreate_pacient.Text = "Crear";
            this.btncreate_pacient.UseVisualStyleBackColor = false;
            this.btncreate_pacient.Click += new System.EventHandler(this.btncreate_pacient_Click);
            // 
            // btncancel_pacient
            // 
            this.btncancel_pacient.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btncancel_pacient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel_pacient.Location = new System.Drawing.Point(131, 320);
            this.btncancel_pacient.Name = "btncancel_pacient";
            this.btncancel_pacient.Size = new System.Drawing.Size(113, 47);
            this.btncancel_pacient.TabIndex = 21;
            this.btncancel_pacient.Text = "Cancelar";
            this.btncancel_pacient.UseVisualStyleBackColor = false;
            this.btncancel_pacient.Click += new System.EventHandler(this.btncancel_pacient_Click);
            // 
            // frmPacient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(573, 445);
            this.Controls.Add(this.btncancel_pacient);
            this.Controls.Add(this.btncreate_pacient);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmPacient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paciente";
            this.Load += new System.EventHandler(this.frmPacient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDUI;
        private System.Windows.Forms.TextBox txtadress_pacient;
        private System.Windows.Forms.TextBox txtname_pacient;
        private System.Windows.Forms.TextBox txtemail_pacient;
        private System.Windows.Forms.TextBox txtphone_pacient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbdisease;
        private System.Windows.Forms.ComboBox cmbpriority;
        private System.Windows.Forms.ComboBox cmbinstitution;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btncreate_pacient;
        private System.Windows.Forms.Button btncancel_pacient;
    }
}

