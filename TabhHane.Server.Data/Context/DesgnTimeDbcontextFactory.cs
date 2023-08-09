using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabhHane.Server.Data.Context
{
    public class DesgnTimeDbcontextFactory : IDesignTimeDbContextFactory<TabhHaneContext>
    {
        public TabhHaneContext CreateDbContext(string[] args)
        {
            string connectionString = "Server=DESKTOP-SLOIL0F;Database=TabhHaneTest;User Id=sa;Password=17421742;TrustServerCertificate=True";
            var builder = new DbContextOptionsBuilder<TabhHaneContext>();
            builder.UseSqlServer(connectionString);
            return new TabhHaneContext(builder.Options);
        }
    }
}
