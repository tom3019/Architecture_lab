using Architecture_lab.Repositories.Member.Entity;
using Architecture_lab.Repositories.Member.Entity.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Architecture_lab.Repositories.Context
{
    public partial class SampleDbMsSqlContext : DbContext
    {
        public SampleDbMsSqlContext()
        {
        }

        public SampleDbMsSqlContext(DbContextOptions<SampleDbMsSqlContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=127.0.0.1,1433;Initial Catalog=SampleDb;User ID=sa;Password=Tom30913");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MemberMsSqlConfiguration());
            base.OnModelCreating(modelBuilder);
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public virtual DbSet<MemberDataModel> Members { get; set; }
    }
}