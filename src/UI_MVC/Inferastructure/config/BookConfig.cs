using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UI_MVC.Entitis;

namespace UI_MVC.Inferastructure.config
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(b =>  b.Id);
           builder.Property(b => b.Title)
                 .IsRequired()
                 .HasMaxLength(200);

            builder.Property(b => b.Author)
                .IsRequired()
                .HasMaxLength(200);

            builder.HasOne(b => b.Category)
             .WithMany(c=> c.Books)
             .HasForeignKey(b => b.CategoryId)
             .OnDelete(DeleteBehavior.Cascade);




        }
    }
}
