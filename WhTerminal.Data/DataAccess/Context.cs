using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhTerminal.Data.Models;

namespace WhTerminal.Data.DataAccess
{
    public partial class WhContext
    {
        public DbSet<Area> Areas { get; set; }
        public DbSet<Hangar> Hangars { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Container> Containers { get; set; }
    }
}
