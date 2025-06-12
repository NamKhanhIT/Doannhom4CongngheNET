using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using KTXManager.Data;

namespace KTXManager.Data
{
    public class KTXContextFactory : IDesignTimeDbContextFactory<KTXContext>
    {
        public KTXContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<KTXContext>();
            optionsBuilder.UseSqlServer("Data Source=(local);Initial Catalog=QuanLyKTX;Integrated Security=True;TrustServerCertificate=True");

            return new KTXContext(optionsBuilder.Options);
        }
    }
} 