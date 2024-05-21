using Domain.Entry;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Map
{
    public class AdvisorMap : IEntityTypeConfiguration<Advisor>
    {
        public void Configure(EntityTypeBuilder<Advisor> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.CreationUser).WithMany(x => x.ListAdvisorCreationUser).HasForeignKey(x => x.CreationUserId);
            builder.HasOne(x => x.ChangeUser).WithMany(x => x.ListAdvisorChangeUser).HasForeignKey(x => x.ChangeUserId);
            builder.HasOne(x => x.Course).WithMany(x => x.ListAdvisor).HasForeignKey(x => x.CourseId);

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

            builder.Property(x => x.CurriculumLink)
                .IsRequired();

            builder.Property(x => x.CourseId)
                .IsRequired();
        }
    }
}
