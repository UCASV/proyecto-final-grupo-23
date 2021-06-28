using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_V2.Migrations;

namespace Proyecto_V2
{
    public partial class frmCabin : Form
    {
        public frmCabin()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var db = new ProyectoContext();

            var cabin = new Cabin(txtAddress.Text, txtEmail.Text, txtPhoneNumber.Text, txtName.Text);

            db.Add(cabin);
            db.SaveChanges();

            MessageBox.Show("Cabina creada exitosamente!", "No se que poner aqui", MessageBoxButtons.OK,
                    MessageBoxIcon.Information); 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
