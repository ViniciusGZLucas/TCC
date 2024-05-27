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

            builder.HasOne(x => x.ChangeUser).WithMany(x => x.ListChangeUser).HasForeignKey(x => x.ChangeUserId);

            builder.Property(x => x.Id)
                .IsRequired();

            builder.Property(x => x.CreationDate)
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

            builder.Property(x => x.BindingDate)
                .IsRequired();

            builder.Property(x => x.BindingDate)
                .HasMaxLength(13)
                .IsRequired();

            var defaultUser = new User("Admin", "admin@admin.com", "privateAdmin@email.com", "123456", DateTime.Now, "");
            defaultUser.PopulateBaseProperties(1, DateTime.Now, 1, null, null, default, null);

            builder.HasData(defaultUser);
        }
    }
}
