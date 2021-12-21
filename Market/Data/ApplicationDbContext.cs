using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Market.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products{ get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            SqlConnectionStringBuilder ConnectionString = new SqlConnectionStringBuilder()
            {
                DataSource = "DELLVOSTRO512",
                InitialCatalog = "NasserProducts",
                IntegratedSecurity = true
            };
            optionsBuilder.UseSqlServer(ConnectionString.ToString());
        }
    }
}
