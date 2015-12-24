using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help.Domain
{
    public class HelpDBContext : DbContext
    {
        static HelpDBContext()
        {
            Database.SetInitializer<HelpDBContext>(null);
        }

        public HelpDBContext()
            : base("Name=HelpDBContext")
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<OrganizationRequest> OrganizationRequests { get; set; }


    }
}
