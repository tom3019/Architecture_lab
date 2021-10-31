using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Architecture_lab.Repositories.Member.Entity.Configurations
{
    public partial class MemberMySqlConfiguration : IEntityTypeConfiguration<MemberDataModel>
    {
        public void Configure(EntityTypeBuilder<MemberDataModel> builder)
        {
            builder.Property(m => m.Id).HasColumnType("int").HasColumnName("id").HasComment("會員主鍵");
            builder.Property(m => m.Account).HasColumnType("varchar(15)").HasColumnName("account").HasComment("會員帳號");
            builder.Property(m => m.Password).HasColumnType("varchar(20)").HasColumnName("password").HasComment("會員密碼");
            builder.Property(m => m.CreateTime).HasColumnType("datetime2").HasColumnName("createTime").HasComment("創建時間");
            builder.Property(m => m.UpdateTime).HasColumnType("datetime2").HasColumnName("updateTime").HasComment("更新時間");
            OnConfigurePartial(builder);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<MemberDataModel> builder);
    }
}