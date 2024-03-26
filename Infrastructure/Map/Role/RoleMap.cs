using Domain.Entry;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Map
{
    public class RoleMap : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.CreationUser).WithMany(x => x.ListRoleCreationUser).HasForeignKey(x => x.CreationUserId);
            builder.HasOne(x => x.ChangeUser).WithMany(x => x.ListRoleChangeUser).HasForeignKey(x => x.ChangeUserId);

            builder.Property(x => x.Id)
                .IsRequired();

            builder.Property(x => x.CreationDate)
                .IsRequired();

            builder.Property(x => x.CreationUserId)
                .IsRequired();

            builder.Property(x => x.ChangeDate);

            builder.Property(x => x.ChangeUserId);

            builder.Property(x => x.Name)
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(x => x.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.IsAdmin)
                .IsRequired();
        }
    }
}
