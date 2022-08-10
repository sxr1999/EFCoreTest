using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreTest;

public class CommontConfig : IEntityTypeConfiguration<Commont>
{
    public void Configure(EntityTypeBuilder<Commont> builder)
    {
        builder.ToTable("T_Commonts");
        builder.HasOne<Article>(a => a.Article).WithMany(b => b.Commonts);
    }
}