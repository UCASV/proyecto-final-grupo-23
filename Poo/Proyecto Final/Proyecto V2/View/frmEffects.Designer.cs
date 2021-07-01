
namespace Proyecto_V2
{
    partial class frmEffects
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEffects = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNo);
            this.groupBox1.Controls.Add(this.rbYes);
            this.groupBox1.Location = new System.Drawing.Point(38, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "¿Despues de los 30 minutos de observación el cliente presento algún síntoma?";
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Location = new System.Drawing.Point(12, 55);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(34, 19);
            this.rbYes.TabIndex = 0;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "Si";
            this.rbYes.UseVisualStyleBackColor = true;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(100, 55);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(41, 19);
            this.rbNo.TabIndex = 1;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(568, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sí seleccion si, Por favor seleccionar el síntoma que el paciente presento luego " +
    "presione el botón confirmar";
            // 
            // cmbEffects
            // 
            this.cmbEffects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEffects.FormattingEnabled = true;
            this.cmbEffects.Location = new System.Drawing.Point(30, 198);
            this.cmbEffects.Name = "cmbEffects";
            this.cmbEffects.Size = new System.Drawing.Size(282, 23);
            this.cmbEffects.TabIndex = 2;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(501, 229);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(99, 41);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Confirmar";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmEffects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 296);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cmbEffects);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEffects";
            this.Text = "Efecto secundario";
            this.Load += new System.EventHandler(this.frmEffects_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEffects;
        private System.Windows.Forms.Button btnOk;
    }
}