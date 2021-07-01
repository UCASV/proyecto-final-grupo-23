using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_V2
{
    public partial class Cabinxemployee
    {
        public int IdCabin { get; set; }
        public int IdEmployee { get; set; }

        public virtual Cabin IdCabinNavigation { get; set; }
        public virtual Employee IdEmployeeNavigation { get; set; }
    }
}
