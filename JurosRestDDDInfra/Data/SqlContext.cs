using JurosRestDDDDomain.Entities;
using Microsoft.EntityFrameworkCore;

namespace JurosRestDDDInfra.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {

        }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {

        }

        public DbSet<Taxa> Taxas { get; set; }
        public DbSet<Juro> Juros { get; set; }

        //Example base fields 
        //public override int SaveChanges()
        //{
        //    foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("") != null))
        //    {
        //        if(entry.State == EntityState.Added)
        //        {
        //            entry.Property("DataCadastro").CurrentValue = DateTime.Now;
        //        }
        //    }
        //    return base.SaveChanges();
        //}
    }
}
