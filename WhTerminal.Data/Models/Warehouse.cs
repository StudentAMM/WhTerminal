using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhTerminal.Data.Models
{
    public class Warehouse : BaseEntity
    {
        public virtual ICollection<Area> Areas { get; set; }
    }
}
