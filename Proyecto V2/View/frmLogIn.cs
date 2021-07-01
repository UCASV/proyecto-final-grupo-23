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

            try
            {
                var db = new ProyectoContext();

                var listEmployees = db.Employees
                    .Include(u => u.IdTypeEmployeeNavigation)
                    .OrderBy(u => u.Id)
                    .ToList();

                var result = listEmployees.Where(
                    u => u.UserEmployee.Equals(txtUser.Text) && u.PasswordEmployee.Equals(txtPassword.Text))
                    .ToList();

                var employee = result[0];
                Employee employee2 = db.Set<Employee>()
                    .SingleOrDefault(u => u.Id == employee.Id);

                Cabin cabin = (Cabin)cmbCabin.SelectedItem;
                Cabin cabin2 = db.Set<Cabin>()
                    .SingleOrDefault(u => u.Id == cabin.Id);

                if (result.Count == 0)
                {
                    MessageBox.Show("El usuario no existe o contraseña incorrecta!", "Login", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
                else
                {
                    var record = new Record(DateTime.Now, cabin2, employee);
                    db.Add(record);
                    db.SaveChanges();
                    MessageBox.Show("Bienvenido!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    quote.Show();
                    this.Hide();
                }
            }
            catch
            {
                MessageBox.Show("Algo anda mal, verifica que tus datos esten correctos", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


/*var listPacient = db.Pacients
                .Include(u => u.IdDiseaseNavigation)
                .Include(u => u.IdDiseaseNavigation)
                .Include(u => u.IdGroupPriorityNavigation)
                .OrderBy(u => u.Dui)
                .ToList();

var result = listPacient.Where(u => u.Dui == txtDui.Text).ToList();
var pacient = result[0];
Pacient pacient2 = db.Set<Pacient>()
    .SingleOrDefault(u => u.Dui == pacient.Dui);*/