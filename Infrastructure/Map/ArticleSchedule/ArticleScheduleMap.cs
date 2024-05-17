using Domain.Entry;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Map
{
    public class ArticleScheduleMap : IEntityTypeConfiguration<ArticleSchedule>
    {
        public void Configure(EntityTypeBuilder<ArticleSchedule> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.CreationUser).WithMany(x => x.ListArticleScheduleCreationUser).HasForeignKey(x => x.CreationUserId);
            builder.HasOne(x => x.Article).WithMany(x => x.ListArticleSchedule).HasForeignKey(x => x.ArticleId);

            builder.Property(x => x.Id)
                .IsRequired();

            builder.Property(x => x.CreationDate)
                .IsRequired();

            builder.Property(x => x.CreationUserId)
                .IsRequired();

            builder.Property(x => x.ArticleId)
                .IsRequired();

            builder.Property(x => x.Description)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(x => x.Date)
                .IsRequired();
        }
    }
}
