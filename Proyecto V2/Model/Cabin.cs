using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_V2
{
    public partial class Cabin
    {
        public Cabin()
        {
            Cabinxemployees = new HashSet<Cabinxemployee>();
            Quotees = new HashSet<Quotee>();
            Records = new HashSet<Record>();
            Vaccinations = new HashSet<Vaccination>();
        }

        public int Id { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Mandated { get; set; }

        public virtual ICollection<Cabinxemployee> Cabinxemployees { get; set; }
        public virtual ICollection<Quotee> Quotees { get; set; }
        public virtual ICollection<Record> Records { get; set; }
        public virtual ICollection<Vaccination> Vaccinations { get; set; }

        public Cabin(string Adress, string Email, string Phone, string Mandated)
        {
            this.Adress = Adress;
            this.Email = Email;
            this.Phone = Phone;
            this.Mandated = Mandated;
        }

        public Cabin(string Adress)
        {
            this.Adress = Adress;
        }
    }
}
