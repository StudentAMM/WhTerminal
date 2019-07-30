using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhTerminal.Data.Models
{
    public class Area : BaseEntity
    {
        public virtual Warehouse Warehouse { get; set; }
        public virtual ICollection<Hangar> Hangars { get; set; }
    }
}
