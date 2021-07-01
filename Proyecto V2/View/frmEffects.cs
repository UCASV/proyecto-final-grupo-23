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
    public partial class frmEffects : Form
    {
        private Pacient pacient { get; set; }
        private Cabin cabin { get; set; }
        private Vaccination vaccine { get; set;  }
        public frmEffects(Pacient pacient, Cabin cabin, Vaccination vaccine)
        {
            InitializeComponent();
            this.pacient = pacient;
            this.cabin = cabin;
            this.vaccine = vaccine;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
            try
            {
                var db = new ProyectoContext();
                Pacient pacient = this.pacient;
                Cabin cabin = this.cabin;
                Vaccination vaccine = this.vaccine;

                SideEffect effect = (SideEffect)cmbEffects.SelectedItem;
                SideEffect effect2 = db.Set<SideEffect>()
                    .SingleOrDefault(u => u.Id == effect.Id);

                if (rbYes.Checked == true)
                {
                    vaccine.IdSideEffectsNavigation = effect2;
                    db.Update(vaccine);
                    db.SaveChanges();

                    MessageBox.Show("Se ha confirmado y registrado la informacion de el sintoma presentado", "Vacunación",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                {
                    this.Hide();
                }
            }
            catch
            {
                MessageBox.Show("Algo anda mal", "Proceso de vacunación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmEffects_Load(object sender, EventArgs e)
        {
            var db = new ProyectoContext();

            var effects = db.SideEffects
                .OrderBy (u => u.Id)
                .ToList();

            cmbEffects.DataSource = effects;
            cmbEffects.DisplayMember = "SideEffects";
            cmbEffects.ValueMember = "Id";
        }
    }
}
