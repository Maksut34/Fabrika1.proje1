using Fabrika1.proje.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrika1.proje.ORM.Context
{
    class Context:DbContext
    {
        public Context()
        {
            Database.Connection.ConnectionString = "Server=LAPTOP-PAPDGKQ8\\SQLEXPRESS02;Database=Fabrika;uid=sa;pwd=1;";
        }

       public DbSet<Internet_Sales> Internet_Sales { get; set; }
       public DbSet<Shoe_Manufacturıng> Shoe_Manufacturıngs { get; set; }
       public DbSet<Shoes_ın_and_out> Shoes_In_And_Outs { get; set; }
       public DbSet<Materıals_Avaılable> Materıals_Avaılable { get; set; }
    }
}
