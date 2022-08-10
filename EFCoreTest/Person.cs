using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EFCoreTest;

public class Person
{
    public long Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public DateTime BrithDay { get; set; }  
}