using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_V2
{
    public partial class Record
    {
        public int Id { get; set; }
        public DateTime? DateRecord { get; set; }
        public int? IdCabin { get; set; }
        public int? IdEmployee { get; set; }

        public virtual Cabin IdCabinNavigation { get; set; }
        public virtual Employee IdEmployeeNavigation { get; set; }

        public Record()
        {

        }

        public Record(DateTime date, Cabin cabin, Employee employee)
        {
            this.DateRecord = date;
            this.IdCabinNavigation = cabin;
            this.IdEmployeeNavigation = employee;
        }
    }
}
