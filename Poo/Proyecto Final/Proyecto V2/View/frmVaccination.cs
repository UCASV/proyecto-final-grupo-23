using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace Proyecto_V2
{
    public partial class frmVaccination : Form
    {
        public frmVaccination()
        {
            InitializeComponent();
        }

        private MySqlConnection connection = new MySqlConnection("Server=localhost;database=proyecto_final3;User=root;Password=malditos0001");
        private void frmVaccination_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss";

            var db = new ProyectoContext();

            var cabin = db.Cabins
                .ToList();

            cmbCabin.DataSource = cabin;
            cmbCabin.DisplayMember = "Adress";
            cmbCabin.ValueMember = "Id";

            cmbCabin2.DataSource = cabin;
            cmbCabin2.DisplayMember = "Adress";
            cmbCabin2.ValueMember = "Id";

            update();
            
        }

        public void update()
        {
            connection.Open();
            string command = "select id 'Id empleado', name_employee 'Nombre del empleado', email 'Correo electronico', adress 'Dirección', user_employee 'usuario', id_type_employee 'id tipo de empleado' from employee";
            MySqlDataAdapter adapter = new MySqlDataAdapter(command, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dtgvEmployee.DataSource = dt;

            connection.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            update();
        }

        private void btnVaccine_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new ProyectoContext();

                var listPacient = db.Pacients
                    .Include(u => u.IdDiseaseNavigation)
                    .Include(u => u.IdTypeInstitutionNavigation)
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

                var dates = db.Quotees
                    .Include(u => u.DuiPacientNavigation)
                    .Include(u => u.IdCabinNavigation)
                    .OrderBy(u => u.Id)
                    .ToList();

                var result3 = dates.Where(u => u.DuiPacientNavigation.Equals(pacient2)).ToList();

                var listVaccine = db.Vaccinations
                    .Include(u => u.DuiPacientNavigation)
                    .Include(u => u.IdCabinNavigation)
                    .Include(u => u.IdSideEffectsNavigation)
                    .OrderBy(u => u.Id)
                    .ToList();

                var result2 = listVaccine.Where(u => u.DuiPacientNavigation.Equals(pacient2)).ToList();
                                 
                bool verify = result.Count > 0;
                bool verify2 = result2.Count > 0;
                bool verify3 = result3.Count > 0;

                if (verify2)
                {
                    MessageBox.Show("A el paciente ya se la puesto la primera dosis", "Proceso de Vacunación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!verify)
                {
                    MessageBox.Show("El paciente no se encuentra agendado en la lista por la tanto tampoco posee un cita ir al proceso de cita y llenar el formulario del paciente",
                                    "Proceso de vacunación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if(!verify3)
                {
                    MessageBox.Show("El paciente aun no ha solicitado una cita para su vacunación para iniciar este proceso ir a proceso de cita", "Proceso de vacunacion",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }                    
                else
                {
                    Vaccination vaccine = new Vaccination(DateTime.Now, cabin2, pacient2, null);

                    db.Add(vaccine);
                    db.SaveChanges();
                    

                    Quotee quote = new Quotee(dateTimePicker1.Value, cabin2.Adress.ToString(), cabin2, pacient2);

                    db.Add(quote);
                    db.SaveChanges();

                    PdfWriter pw = new PdfWriter("/Users/David/Desktop/Pdf Citas/Pdf_Citas");
                    PdfDocument pdfDocument = new PdfDocument(pw);
                    Document doc = new Document(pdfDocument);

                    doc.Add(new Paragraph("DUI: " + pacient2.Dui));
                    doc.Add(new Paragraph("Nombre: " + pacient2.NamePacient));
                    doc.Add(new Paragraph("Lugar de la cita: " + quote.PlaceVaccination));
                    doc.Add(new Paragraph("Fecha: " + quote.DateVaccine));

                    doc.Close(); 

                    MessageBox.Show("El paciente ha sido vacunado con exito, se ha agendado su nueva cita y se mantendra en observación durante 30 minutos",
                        "Proceso de cita", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frmEffects effects = new frmEffects(pacient2, cabin2, vaccine);
                    effects.Show();
                }


            }
            catch
            {
                MessageBox.Show("Algo anda mal, probablemente el DUI que ingreso no existe en la base de datos","Proceso de Vacunación",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVaccine2_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new ProyectoContext();

                var listPacient = db.Pacients
                    .Include(u => u.IdDiseaseNavigation)
                    .Include(u => u.IdTypeInstitutionNavigation)
                    .Include(u => u.IdGroupPriorityNavigation)
                    .OrderBy(u => u.Dui)
                    .ToList();

                var result = listPacient.Where(u => u.Dui == txtDui2.Text).ToList();
                var pacient = result[0];
                Pacient pacient2 = db.Set<Pacient>()
                    .SingleOrDefault(u => u.Dui == pacient.Dui);

                var dates = db.Quotees
                    .Include(u => u.DuiPacientNavigation)
                    .Include(u => u.IdCabinNavigation)
                    .OrderBy(u => u.Id)
                    .ToList();

                var listVaccine = db.Vaccinations
                    .Include(u => u.DuiPacientNavigation)
                    .Include(u => u.IdCabinNavigation)
                    .Include(u => u.IdSideEffectsNavigation)
                    .OrderBy(u => u.Id)
                    .ToList();

                Cabin cabin = (Cabin)cmbCabin2.SelectedItem;
                Cabin cabin2 = db.Set<Cabin>()
                    .SingleOrDefault(u => u.Id == cabin.Id);

                var result3 = listVaccine.Where(u => u.DuiPacientNavigation.Equals(pacient2)).ToList();

                var result2 = dates.Where(u => u.DuiPacientNavigation.Equals(pacient2)).ToList();


                bool verify = result2.Count <= 1;
                bool verify2 = result3.Count < 1;
                bool verify3 = result3.Count > 1;
                
                if(verify)
                {
                    MessageBox.Show("No ha agendado su segunda cita", "Proceso de vacunacion", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if(verify2)
                {
                    MessageBox.Show("A el paciente aun no se le ha puesto su primera vacuna", "Proceso de vacunacion",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if(verify3)
                {
                    MessageBox.Show("A el paciente se le ha aplicado la segunda dosis de la vacuna anteriormente", "Proceso de vacunacion",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Vaccination vaccine = new Vaccination(DateTime.Now, cabin2, pacient2, null);

                    db.Add(vaccine);
                    db.SaveChanges();

                    MessageBox.Show("El paciente se le ha aplicado la segunda dosis con exito y se mantendra en observación durante 30 minutos", "Proceso de cita",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frmEffects effects = new frmEffects(pacient2, cabin2, vaccine);
                    effects.Show();
                }
                

            }
            catch
            {
                MessageBox.Show("Algo anda mal, probablemente el DUI que ingreso no existe en la base de datos", "Proceso de Vacunación",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmQuotes quotes = new frmQuotes();
            quotes.Show();
            this.Hide();
        }
    }
}
