using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_V2
{
    public partial class Employee
    {
        public Employee()
        {
            Cabinxemployees = new HashSet<Cabinxemployee>();
            Records = new HashSet<Record>();
        }

        public int Id { get; set; }
        public string NameEmployee { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public string UserEmployee { get; set; }
        public string PasswordEmployee { get; set; }
        public int? IdTypeEmployee { get; set; }

        public virtual TypeEmployee IdTypeEmployeeNavigation { get; set; }
        public virtual ICollection<Cabinxemployee> Cabinxemployees { get; set; }
        public virtual ICollection<Record> Records { get; set; }

        public Employee(string NameEmployee, string Email, string Adress, string UserEmployee, string PasswordEmployee, TypeEmployee typeEmployee)
        {
            this.NameEmployee = NameEmployee;
            this.Email = Email;
            this.Adress = Adress;
            this.UserEmployee = UserEmployee;
            this.PasswordEmployee = PasswordEmployee;
            this.IdTypeEmployeeNavigation = typeEmployee;
        }
    }
}
