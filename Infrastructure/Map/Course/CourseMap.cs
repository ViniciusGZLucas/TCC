using Domain.Entry;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Map
{
    public class CourseMap : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.CreationUser).WithMany(x => x.ListCourseCreationUser).HasForeignKey(x => x.CreationUserId);
            builder.HasOne(x => x.ChangeUser).WithMany(x => x.ListCourseChangeUser).HasForeignKey(x => x.ChangeUserId);

            builder.Property(x => x.Id)
                .IsRequired();

            builder.Property(x => x.CreationDate)
                .IsRequired();

            builder.Property(x => x.CreationUserId)
                .IsRequired();

            builder.Property(x => x.ChangeDate);

            builder.Property(x => x.ChangeUserId);

            builder.Property(x => x.Name)
                .IsRequired();
        }
    }
}
