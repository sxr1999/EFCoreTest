using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreTest;

public class OrgUnitConfig : IEntityTypeConfiguration<OrgUnit>
{
    public void Configure(EntityTypeBuilder<OrgUnit> builder)
    {
        builder.ToTable("T_OrgUnits");
        builder.HasOne<OrgUnit>(x => x.Parent).WithMany(x => x.Childern);
        builder.Property(x => x.Name).IsUnicode().IsRequired();
    }
}