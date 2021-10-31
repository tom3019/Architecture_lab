using System;
using Architecture_lab.Repositories.Member.Entity;
using Architecture_lab.Repositories.Member.Entity.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Architecture_lab.Repositories.Context
{
    public partial class SampleDbMySqlContext : DbContext
    {
        protected SampleDbMySqlContext()
        {
        }

        public SampleDbMySqlContext(DbContextOptions<SampleDbMsSqlContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 26));
            optionsBuilder.UseMySql("Data Source=127.0.0.1,1433;Initial Catalog=SampleDb;User ID=sa;Password=Tom30913", serverVersion);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MemberMySqlConfiguration());
            base.OnModelCreating(modelBuilder);
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public virtual DbSet<MemberDataModel> Members { get; set; }
    }
}