using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_V2
{
    public partial class Vaccination
    {
        public int Id { get; set; }
        public DateTime? DateVaccine { get; set; }
        public int? IdCabin { get; set; }
        public int? IdSideEffects { get; set; }
        public string DuiPacient { get; set; }

        public virtual Pacient DuiPacientNavigation { get; set; }
        public virtual Cabin IdCabinNavigation { get; set; }
        public virtual SideEffect IdSideEffectsNavigation { get; set; } 

        public Vaccination()
        {

        }

        public Vaccination(DateTime date, Cabin cabin, Pacient? pacient, SideEffect side)
        {
            this.DateVaccine = date;
            this.IdCabinNavigation = cabin;
            this.IdSideEffectsNavigation = side;
            this.DuiPacientNavigation = pacient;
        }

    }
}
