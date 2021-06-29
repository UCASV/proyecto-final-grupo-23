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
using MySql.Data.MySqlClient;

namespace Proyecto_V2
{
    public partial class frmQuotes : Form
    {
       
        public frmQuotes()
        {
            InitializeComponent();
        }

        private MySqlConnection connection = new MySqlConnection("Server=localhost;database=proyecto_final3;User=root;Password=malditos0001");

        private void frmQuotes_Load(object sender, EventArgs e)
        {
            connection.Open();
            string command = "select id 'id cita', date_vaccine 'fecha y hora de cita', place_vaccination 'lugar de vacunacion', id_cabin 'id de cabina', DUI_pacient 'DUI del paciente' from quotee;";
            MySqlDataAdapter adapter = new MySqlDataAdapter(command, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dtgvQuote.DataSource = dt;

            connection.Close();

            var db = new ProyectoContext();

            var cabin = db.Cabins
                .ToList();

            cmbCabin.DataSource = cabin;
            cmbCabin.DisplayMember = "Adress";
            cmbCabin.ValueMember = "Id";
        }

        private void btnAddPacient_Click(object sender, EventArgs e)
        {
            frmPacient pacient = new frmPacient();

            pacient.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            string command = "select DUI, name_pacient 'Nombre', adress_pacient 'Direccion', email, 'correo electronico', phone 'telefono', id_Disease 'ID nfermedad', id_type_institution 'Id tipo de institucion', id_group_priority 'Id grupo de prioridad' from pacient";
            MySqlDataAdapter adapter = new MySqlDataAdapter(command, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dtgvPacient.DataSource = dt;

            connection.Close();
        }

        private void btnCrearCita_Click(object sender, EventArgs e)
        {
            var db = new ProyectoContext();

            var listPacient = db.Pacients
                .Include(u => u.IdDiseaseNavigation)
                .Include(u => u.IdDiseaseNavigation)
                .Include(u => u.IdGroupPriorityNavigation)
                .OrderBy(u => u.Dui)              
                .ToList();

            var result = listPacient.Where(u => u.Dui == txtDui.Text).ToList();
            var pacient = result[0];
            Pacient pacient2 = db.Set<Pacient>()
                .SingleOrDefault(u => u.Dui == pacient.Dui);


            Cabin cabin = (Cabin)cmbCabin.SelectedItem;
            Cabin cabin2 = db.Set<Cabin>()
                .SingleOrDefault(u => u.Id == cabin.Id);

            bool verify = result.Count > 0;

            if (verify)
            {
                Quotee quote = new Quotee(dateTimePicker1.Value, cabin2.Adress.ToString(), cabin2, pacient2);

                db.Add(quote);
                db.SaveChanges();
                MessageBox.Show("Se agregado la cita exitosamente", "Proceso de citas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El paciente no existe en la lista, si desea agregar uno por favor llenar el formulario en la pestaña (Formulario del paciente)", "Proceso de cita", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate2_Click(object sender, EventArgs e)
        {
            connection.Open();
            string command = "select id 'id cita', date_vaccine 'fecha y hora de cita', place_vaccination 'lugar de vacunacion', id_cabin 'id de cabina', DUI_pacient 'DUI del paciente' from quotee;";
            MySqlDataAdapter adapter = new MySqlDataAdapter(command, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dtgvQuote.DataSource = dt;

            connection.Close();
        }
    }
}
