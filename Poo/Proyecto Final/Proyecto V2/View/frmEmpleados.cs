using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_V2
{
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            bool verify = txtUser.Text.Length > 5 &&
                          txtPassword.Text.Length > 5 &&
                          (txtPassword.Text == txtPasswordr.Text);

            var db = new ProyectoContext();

            var listEmployee = db.Employees
                .OrderBy(u => u.NameEmployee)
                .Where(u => u.NameEmployee.Equals(txtName.Text))
                .ToList();

            var ListUserEmployee = db.Employees
                .OrderBy(u => u.NameEmployee)
                .Where(u => u.UserEmployee.Equals(txtUser.Text))
                .ToList();

            bool verify2 = listEmployee.Count > 0;
            bool verify3 = ListUserEmployee.Count > 0;

            if (!verify)
            {
                MessageBox.Show("Datos erroneos, por favor verificar que haya ingresado correctamente sus datos"
                    , "Empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verify2)
            {
                MessageBox.Show("El nombre del empleado que ingresaste actualmente existe en la base de datos "
                    , "Empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verify3)
            {
                MessageBox.Show("El usuario que ha ingresado actualmente esta en uso, ingresar uno diferente"
                   , "Empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TypeEmployee typeEmployee = (TypeEmployee)cmbTypeEmployee.SelectedItem;

                TypeEmployee typeEmployee2 = db.Set<TypeEmployee>()
                    .SingleOrDefault(u => u.Id == typeEmployee.Id);

                var Employee = new Employee(txtName.Text, txtEmail.Text, txtAdress.Text, txtUser.Text, txtPassword.Text, typeEmployee2);

                db.Add(Employee);
                db.SaveChanges();

                MessageBox.Show("El empleado ha sido ingresado a la base de datos exitosamente", "Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            var db = new ProyectoContext();
            var typeEmployee = db.TypeEmployees
                .ToList();
            cmbTypeEmployee.DataSource = typeEmployee;
            cmbTypeEmployee.DisplayMember = "Typee";
            cmbTypeEmployee.ValueMember = "Id";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
