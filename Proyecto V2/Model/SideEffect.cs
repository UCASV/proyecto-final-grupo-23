using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_V2
{
    public partial class SideEffect
    {
        public SideEffect()
        {
            Vaccinations = new HashSet<Vaccination>();
        }

        public int Id { get; set; }
        public string SideEffects { get; set; }

        public virtual ICollection<Vaccination> Vaccinations { get; set; }
    }
}
