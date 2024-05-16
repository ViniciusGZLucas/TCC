using Domain.Entry;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Map
{
    public class ArticleDocumentMap : IEntityTypeConfiguration<ArticleDocument>
    {
        public void Configure(EntityTypeBuilder<ArticleDocument> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.CreationUser).WithMany(x => x.ListArticleDocumentCreationUser).HasForeignKey(x => x.CreationUserId);
            builder.HasOne(x => x.ChangeUser).WithMany(x => x.ListArticleDocumentChangeUser).HasForeignKey(x => x.ChangeUserId);
            builder.HasOne(x => x.Article).WithMany(x => x.ListArticleDocuments).HasForeignKey(x => x.ArticleId);

            builder.Property(x => x.Id)
                .IsRequired();

            builder.Property(x => x.CreationDate)
                .IsRequired();

            builder.Property(x => x.CreationUserId)
                .IsRequired();

            builder.Property(x => x.ChangeDate);

            builder.Property(x => x.ChangeUserId);

            builder.Property(x => x.ArticleId)
                .IsRequired();

            builder.Property(x => x.FileName)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(x => x.Base64File)
    .           IsRequired();
        }
    }
}
