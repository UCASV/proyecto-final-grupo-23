
namespace Proyecto_V2
{
    partial class frmVaccination
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVaccination));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnVaccine = new System.Windows.Forms.Button();
            this.cmbCabin = new System.Windows.Forms.ComboBox();
            this.txtDui = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnVaccine2 = new System.Windows.Forms.Button();
            this.cmbCabin2 = new System.Windows.Forms.ComboBox();
            this.txtDui2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dtgvEmployee = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.btnBack = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(46, 152);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(696, 296);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.btnVaccine);
            this.tabPage1.Controls.Add(this.cmbCabin);
            this.tabPage1.Controls.Add(this.txtDui);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(688, 268);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Vacuna";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(277, 115);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(225, 23);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(131, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha segunda cita: ";
            // 
            // btnVaccine
            // 
            this.btnVaccine.Location = new System.Drawing.Point(523, 174);
            this.btnVaccine.Name = "btnVaccine";
            this.btnVaccine.Size = new System.Drawing.Size(117, 42);
            this.btnVaccine.TabIndex = 8;
            this.btnVaccine.Text = "Vacunar";
            this.btnVaccine.UseVisualStyleBackColor = true;
            this.btnVaccine.Click += new System.EventHandler(this.btnVaccine_Click);
            // 
            // cmbCabin
            // 
            this.cmbCabin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCabin.FormattingEnabled = true;
            this.cmbCabin.Location = new System.Drawing.Point(277, 86);
            this.cmbCabin.Name = "cmbCabin";
            this.cmbCabin.Size = new System.Drawing.Size(225, 23);
            this.cmbCabin.TabIndex = 4;
            // 
            // txtDui
            // 
            this.txtDui.Location = new System.Drawing.Point(277, 57);
            this.txtDui.Name = "txtDui";
            this.txtDui.Size = new System.Drawing.Size(226, 23);
            this.txtDui.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(207, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cabina:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(231, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "DUI:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnVaccine2);
            this.tabPage2.Controls.Add(this.cmbCabin2);
            this.tabPage2.Controls.Add(this.txtDui2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(688, 268);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Segunda dosis";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnVaccine2
            // 
            this.btnVaccine2.Location = new System.Drawing.Point(479, 191);
            this.btnVaccine2.Name = "btnVaccine2";
            this.btnVaccine2.Size = new System.Drawing.Size(160, 33);
            this.btnVaccine2.TabIndex = 4;
            this.btnVaccine2.Text = "Aplicar segunda dosis";
            this.btnVaccine2.UseVisualStyleBackColor = true;
            this.btnVaccine2.Click += new System.EventHandler(this.btnVaccine2_Click);
            // 
            // cmbCabin2
            // 
            this.cmbCabin2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCabin2.FormattingEnabled = true;
            this.cmbCabin2.Location = new System.Drawing.Point(269, 96);
            this.cmbCabin2.Name = "cmbCabin2";
            this.cmbCabin2.Size = new System.Drawing.Size(197, 23);
            this.cmbCabin2.TabIndex = 3;
            // 
            // txtDui2
            // 
            this.txtDui2.Location = new System.Drawing.Point(269, 53);
            this.txtDui2.Name = "txtDui2";
            this.txtDui2.Size = new System.Drawing.Size(198, 23);
            this.txtDui2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cabina: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "DUI:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnUpdate);
            this.tabPage3.Controls.Add(this.dtgvEmployee);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(688, 268);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Informacion de los empleados";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(563, 222);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(111, 31);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Actualizar Tabla";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dtgvEmployee
            // 
            this.dtgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEmployee.Location = new System.Drawing.Point(2, 8);
            this.dtgvEmployee.Name = "dtgvEmployee";
            this.dtgvEmployee.ReadOnly = true;
            this.dtgvEmployee.RowTemplate.Height = 25;
            this.dtgvEmployee.Size = new System.Drawing.Size(683, 198);
            this.dtgvEmployee.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 147);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(0, 29);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(88, 34);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Regresar";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmVaccination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(69)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmVaccination";
            this.Text = "Proceso de vacunación";
            this.Load += new System.EventHandler(this.frmVaccination_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Button btnVaccine;
        private System.Windows.Forms.ComboBox cmbCabin;
        private System.Windows.Forms.TextBox txtDui;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dtgvEmployee;
        private System.Windows.Forms.Button btnVaccine2;
        private System.Windows.Forms.ComboBox cmbCabin2;
        private System.Windows.Forms.TextBox txtDui2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
    }
}