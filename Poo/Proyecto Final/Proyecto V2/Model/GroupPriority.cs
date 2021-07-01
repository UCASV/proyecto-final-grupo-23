using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_V2
{
    public partial class GroupPriority
    {
        public GroupPriority()
        {
            Pacients = new HashSet<Pacient>();
        }

        public int Id { get; set; }
        public string Groupp { get; set; }

        public virtual ICollection<Pacient> Pacients { get; set; }
    }
}
