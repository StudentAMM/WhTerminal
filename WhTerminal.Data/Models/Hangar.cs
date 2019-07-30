using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhTerminal.Data.Models
{
    public class Hangar : BaseEntity
    {
        public int maxContainers { get; set; }
        public int countContainers { get; set; }
        public virtual Area Area { get; set; }
        public virtual ICollection<Container> Containers { get; set; }
    }
}
