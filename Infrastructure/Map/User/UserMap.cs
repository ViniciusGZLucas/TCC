using Domain.Entry;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Map
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.CreationUser).WithMany(x => x.ListCreationUser).HasForeignKey(x => x.CreationUserId);
            builder.HasOne(x => x.ChangeUser).WithMany(x => x.ListChangeUser).HasForeignKey(x => x.ChangeUserId);

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

            builder.Property(x => x.Email)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(x => x.Password)
                .HasMaxLength(70)
                .IsRequired();
        }
    }
}
