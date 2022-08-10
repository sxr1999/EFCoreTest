using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EFCoreTest;

public class TestDbContext : DbContext
{
    //private static ILoggerFactory _loggerFactory = LoggerFactory.Create(b => b.AddConsole());
    
    public DbSet<Book> Books { get; set; }
    public DbSet<Person> Persons { get; set; }

    public DbSet<Article> Articles { get; set; }
    public  DbSet<Commont>  Commonts { get; set; }

    public DbSet<User> Users { get; set; }
    public DbSet<Leave> Leaves { get; set; }
    public DbSet<OrgUnit> OrgUnits { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string a = "server=localhost;user=root;password=111;database=EfCoreTest;";
        optionsBuilder.UseMySql(a,ServerVersion.AutoDetect(a));
        //optionsBuilder.UseLoggerFactory(_loggerFactory);
        optionsBuilder.LogTo(a =>
        {
            if (!a.Contains("CommandExecuting"))
            {
                return;
            }
            Console.WriteLine(a);
        });
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
    }
}