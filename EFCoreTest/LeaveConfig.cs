using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreTest;

public class LeaveConfig : IEntityTypeConfiguration<Leave>
{
    public void Configure(EntityTypeBuilder<Leave> builder)
    {
        builder.ToTable("T_Leaves");
        builder.HasOne<User>(x => x.Approver).WithMany();
        builder.HasOne<User>(x => x.Requester).WithMany();
    }
}