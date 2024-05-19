using Domain.Entry;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Map
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.CreationUser).WithMany(x => x.ListArticleCreationUser).HasForeignKey(x => x.CreationUserId);
            builder.HasOne(x => x.ChangeUser).WithMany(x => x.ListArticleChangeUser).HasForeignKey(x => x.ChangeUserId);
            builder.HasOne(x => x.Author).WithMany(x => x.ListArticleAuthor).HasForeignKey(x => x.AuthorId);
            builder.HasOne(x => x.Advisor).WithMany(x => x.ListArticleAdvisor).HasForeignKey(x => x.AdvisorId);
            builder.HasOne(x => x.CoAdvisor).WithMany(x => x.ListArticleCoAdvisor).HasForeignKey(x => x.CoAdvisorId);

            builder.Property(x => x.Id)
                .IsRequired();

            builder.Property(x => x.CreationDate)
                .IsRequired();

            builder.Property(x => x.CreationUserId)
                .IsRequired();

            builder.Property(x => x.ChangeDate);

            builder.Property(x => x.ChangeUserId);

            builder.Property(x => x.Title)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(x => x.Description)
                .HasMaxLength(500)
                .IsRequired();

            builder.Property(x => x.AuthorId)
                .IsRequired();

            builder.Property(x => x.CoAdvisorId);
        }
    }
}
