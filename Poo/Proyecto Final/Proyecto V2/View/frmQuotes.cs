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
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

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
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss";

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
            try
            {
                var db = new ProyectoContext();

                var listPacient = db.Pacients
                    .Include(u => u.IdDiseaseNavigation)
                    .Include(u => u.IdDiseaseNavigation)
                    .Include(u => u.IdGroupPriorityNavigation)
                    .OrderBy(u => u.Dui)
                    .ToList();

                var listPacient2 = db.Pacients
                    .OrderBy(u => u.Dui)
                    .ToList();

                var prueba2 = listPacient2.Where(u => u.Dui.Equals(txtDui.Text)).ToList();

                var result = listPacient.Where(u => u.Dui == txtDui.Text).ToList();
                var pacient = result[0];
                Pacient pacient2 = db.Set<Pacient>()
                    .SingleOrDefault(u => u.Dui == pacient.Dui);

                var dates = db.Quotees
                    .Include(u => u.DuiPacientNavigation)
                    .Include(u => u.IdCabinNavigation)
                    .OrderBy(u => u.Id)
                    .ToList();

                var result2 = dates.Where(u => u.DuiPacientNavigation.Equals(pacient2)).ToList();
                bool verify2 = result2.Count > 0;

                Cabin cabin = (Cabin)cmbCabin.SelectedItem;
                Cabin cabin2 = db.Set<Cabin>()
                    .SingleOrDefault(u => u.Id == cabin.Id);

                bool verify = prueba2.Count > 0;

                if (verify2)
                {
                    MessageBox.Show("El paciente actualmente ya posee un cita agendada en la base de datos", "Proceso de citas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!verify)
                {
                    MessageBox.Show("El paciente no existe en la lista, si desea agregar uno por favor llenar el formulario en la pestaña (Formulario del paciente)", "Proceso de cita", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Quotee quote = new Quotee(dateTimePicker1.Value, cabin2.Adress.ToString(), cabin2, pacient2);

                    db.Add(quote);
                    db.SaveChanges();                  
                    MessageBox.Show("Se agregado la cita exitosamente", "Proceso de citas", MessageBoxButtons.OK, MessageBoxIcon.Information);                    

                    PdfWriter pw = new PdfWriter("/Users/David/Desktop/Pdf Citas/Pdf_Citas");
                    PdfDocument pdfDocument = new PdfDocument(pw);
                    Document doc = new Document(pdfDocument);

                    doc.Add(new Paragraph("DUI: " + pacient2.Dui));
                    doc.Add(new Paragraph("Nombre: " + pacient2.NamePacient));
                    doc.Add(new Paragraph("Lugar de la cita: " + quote.PlaceVaccination));
                    doc.Add(new Paragraph("Fecha: " + quote.DateVaccine));

                    doc.Close();
                }
            }
            catch
            {
                MessageBox.Show("Parece que algo anda mal, verifica que el paciente ya haya llenado el formulari", "Proces de cita", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnVaccine_Click(object sender, EventArgs e)
        {
            frmVaccination Process = new frmVaccination();

            Process.Show();
            this.Hide();
        }
    }
}
