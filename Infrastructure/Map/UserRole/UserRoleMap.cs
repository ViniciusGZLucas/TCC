using Domain.Entry;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Map
{
    public class UserRoleMap : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.CreationUser).WithMany(x => x.ListUserRoleCreationUser).HasForeignKey(x => x.CreationUserId);
            builder.HasOne(x => x.User).WithMany(x => x.ListUserRole).HasForeignKey(x => x.UserId);
            builder.HasOne(x => x.Role).WithMany(x => x.ListUserRole).HasForeignKey(x => x.RoleId);

            builder.Property(x => x.Id)
                .IsRequired();

            builder.Property(x => x.CreationDate)
                .IsRequired();

            builder.Property(x => x.CreationUserId)
                .IsRequired();

            builder.Property(x => x.ChangeDate);

            builder.Property(x => x.ChangeUserId);

            builder.Property(x => x.UserId)
                .IsRequired();

            builder.Property(x => x.RoleId)
                .IsRequired();
        }
    }
}
