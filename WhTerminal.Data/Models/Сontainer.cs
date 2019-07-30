using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhTerminal.Data.Models
{
    public class Container : BaseEntity
    {
        public virtual Hangar Hangar { get; set; }
    }
}
