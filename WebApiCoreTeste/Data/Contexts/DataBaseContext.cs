using Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Data.Contexts
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(StringConectionConfig());
            }
        }

        public DbSet<Funcionario> Funcionario { get; set; }

        private string StringConectionConfig()
        {
            return "Server=DESKTOP-IANDO4A;Initial Catalog=BancoOnTop;User ID=sa;Password=sqlserver2016;Integrated Security=False;Connect Timeout=15;Encrypt=False;Trusted_Connection=True";
        }
    }
}
