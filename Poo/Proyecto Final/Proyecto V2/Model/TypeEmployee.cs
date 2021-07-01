using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_V2
{
    public partial class TypeEmployee
    {
        public TypeEmployee()
        {
            Employees = new HashSet<Employee>();
        }

        public int Id { get; set; }
        public string Typee { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }

        public TypeEmployee(string Typee)
        {
            this.Typee = Typee;
        }
    }
}
