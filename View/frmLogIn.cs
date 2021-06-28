using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;

namespace Proyecto_V2
{
    public partial class frmLogIn : Form
    {
        frmQuotes quote = new frmQuotes();
        public frmLogIn()
        {
            InitializeComponent();
        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            var db = new ProyectoContext();

            var listEmployees = db.Employees
                .Include(u => u.IdTypeEmployeeNavigation)
                .OrderBy(u => u.Id)
                .ToList();

            var result = listEmployees.Where(
                u => u.UserEmployee.Equals(txtUser.Text) && u.PasswordEmployee.Equals(txtPassword.Text))
                .ToList();

            if(result.Count == 0)
            {
                MessageBox.Show("El usuario no existe o contraseña incorrecta!", "Login", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {                          
                MessageBox.Show("Bienvenido!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                quote.Show();
                this.Hide();
            }
        }

        private void btnAddCabin_Click(object sender, EventArgs e)
        {
            frmCabin newCabin = new frmCabin();

            newCabin.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmEmpleados newEmployee = new frmEmpleados();

            newEmployee.Show();
        }

               
        private void frmLogIn_Load(object sender, EventArgs e)
        {
            var db = new ProyectoContext();
            var cabin = db.Cabins
                .ToList();

            cmbCabin.DataSource = cabin;
            cmbCabin.DisplayMember = "Adress";
            cmbCabin.ValueMember = "Id";
        }
    }
}
