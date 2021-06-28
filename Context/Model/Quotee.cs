using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_V2
{
    public partial class Quotee
    {
        public int Id { get; set; }
        public DateTime? DateVaccine { get; set; }
        public string PlaceVaccination { get; set; }
        public int? IdCabin { get; set; }
        public string DuiPacient { get; set; }

        public virtual Pacient DuiPacientNavigation { get; set; }
        public virtual Cabin IdCabinNavigation { get; set; }

        public Quotee()
        {

        }

        public Quotee(DateTime date, string Place, Cabin cabin, Pacient pacient)
        {
            this.DateVaccine = date;
            this.PlaceVaccination = Place;
            this.IdCabinNavigation = cabin;
            this.DuiPacientNavigation = pacient;
        }
    }
}
