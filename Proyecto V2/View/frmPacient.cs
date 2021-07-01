using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace Proyecto_V2
{
    public partial class frmPacient : Form
    {
        public frmPacient()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btncreate_pacient_Click(object sender, EventArgs e)
        {
            
            try
            {
                var db = new ProyectoContext();

                var listPacients = db.Pacients
                    .OrderBy(u => u.Dui)
                    .Where(u => u.Dui.Equals(txtDUI.Text))
                    .ToList();

                bool verify = listPacients.Count > 0;

                if (verify)
                {
                    MessageBox.Show("Actualmente el paciente ya existe en la lista", "Paciente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Disease disease = (Disease)cmbdisease.SelectedItem;
                    Disease disease2 = db.Set<Disease>()
                        .SingleOrDefault(u => u.Id == disease.Id);

                    TypeInstitution institution = (TypeInstitution)cmbinstitution.SelectedItem;
                    TypeInstitution institution2 = db.Set<TypeInstitution>()
                        .SingleOrDefault(u => u.Id == institution.Id);

                    GroupPriority groupPriority = (GroupPriority)cmbpriority.SelectedItem;
                    GroupPriority groupPriority2 = db.Set<GroupPriority>()
                        .SingleOrDefault(u => u.Id == groupPriority.Id);

                    var pacient = new Pacient(txtDUI.Text, txtname_pacient.Text, txtadress_pacient.Text, txtemail_pacient.Text, txtphone_pacient.Text, disease2, groupPriority2, institution2);

                    db.Add(pacient);
                    db.SaveChanges();

                    MessageBox.Show("El paciente se ha agregado a la lista", "Paciente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch
            {
                MessageBox.Show("Algo anda mal, probablemente excediste la cantidad de caracteres permitidos para los datos", "Formulario pacientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmPacient_Load(object sender, EventArgs e)
        {
            var db = new ProyectoContext();

            var diseases = db.Diseases
                .ToList();

            var institution = db.TypeInstitutions
                .ToList();

            var priority = db.GroupPriorities
                .ToList();

            cmbdisease.DataSource = diseases;
            cmbdisease.DisplayMember = "disease";
            cmbdisease.ValueMember = "Id";

            cmbinstitution.DataSource = institution;
            cmbinstitution.DisplayMember = "typee";
            cmbinstitution.ValueMember = "Id";

            cmbpriority.DataSource = priority;
            cmbpriority.DisplayMember = "groupp";
            cmbpriority.ValueMember = "Id";
        }

        private void btncancel_pacient_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

