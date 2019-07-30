using System.Configuration;
using System.Data.Entity;
using System.Reflection;
using System.Data.Entity.ModelConfiguration.Conventions;
using WhTerminal.Data.Models;

namespace WhTerminal.Data.DataAccess
{
    public partial class WhContext : DbContext
    {

        //public WhContext()
        //        : base(ConfigurationManager.ConnectionStrings["WhConnectionString"].ConnectionString)
        //{
        //}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //base.OnModelCreating(modelBuilder);
            //modelBuilder.Configurations.AddFromAssembly(Assembly.GetAssembly(typeof(WhContext)));
        }
    }
}