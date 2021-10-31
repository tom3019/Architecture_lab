using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Architecture_lab.Repositories.Member.Entity.Configurations
{
    public partial class MemberMsSqlConfiguration : IEntityTypeConfiguration<MemberDataModel>
    {
        public void Configure(EntityTypeBuilder<MemberDataModel> builder)
        {
            builder.HasKey(m => m.Id).HasAnnotation("SqlServer:Identity", "1, 1");
            builder.Property(m => m.Id).HasColumnType("int").HasColumnName("Id").HasComment("會員主鍵");
            builder.Property(m => m.Account).HasColumnType("varchar(15)").HasColumnName("Account").HasComment("會員帳號");
            builder.Property(m => m.Password).HasColumnType("varchar(20)").HasColumnName("Password").HasComment("會員密碼");
            builder.Property(m => m.CreateTime).HasColumnType("datetime2").HasColumnName("CreateTime").HasComment("創建時間");
            builder.Property(m => m.UpdateTime).HasColumnType("datetime2").HasColumnName("UpdateTime").HasComment("更新時間");
            OnConfigurePartial(builder);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<MemberDataModel> builder);
    }
}