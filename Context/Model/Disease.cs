using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_V2
{
    public partial class Disease
    {
        public Disease()
        {
            Pacients = new HashSet<Pacient>();
        }

        public int Id { get; set; }
        public string Disease1 { get; set; }

        public virtual ICollection<Pacient> Pacients { get; set; }
    }
}
