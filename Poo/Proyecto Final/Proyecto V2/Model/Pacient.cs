using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_V2
{
    public partial class Pacient
    {
        public Pacient()
        {
            Quotees = new HashSet<Quotee>();
            Vaccinations = new HashSet<Vaccination>();
        }

        public string Dui { get; set; }
        public string NamePacient { get; set; }
        public string AdressPacient { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int? IdDisease { get; set; }
        public int? IdTypeInstitution { get; set; }
        public int? IdGroupPriority { get; set; }

        public virtual Disease IdDiseaseNavigation { get; set; }
        public virtual GroupPriority IdGroupPriorityNavigation { get; set; }
        public virtual TypeInstitution IdTypeInstitutionNavigation { get; set; }
        public virtual ICollection<Quotee> Quotees { get; set; }
        public virtual ICollection<Vaccination> Vaccinations { get; set; }

        public Pacient(string Dui, string NamePacient, string AdressPacient, string Email, string Phone, Disease disease, GroupPriority groupPriority, TypeInstitution typeInstitution)
        {
            this.Dui = Dui;
            this.NamePacient = NamePacient;
            this.AdressPacient = AdressPacient;
            this.Email = Email;
            this.Phone = Phone;
            this.IdDiseaseNavigation = disease;
            this.IdGroupPriorityNavigation = groupPriority;
            this.IdTypeInstitutionNavigation = typeInstitution;
        }
    }
}
