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
            
            try
            {
                var db = new ProyectoContext();

                var cabin = new Cabin(txtAddress.Text, txtEmail.Text, txtPhoneNumber.Text, txtName.Text);

                db.Add(cabin);
                db.SaveChanges();

                MessageBox.Show("Cabina creada exitosamente!", "Cabina", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Algo anda mal!, verifica que tus datos esten correctos", "Cabina", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }
        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
