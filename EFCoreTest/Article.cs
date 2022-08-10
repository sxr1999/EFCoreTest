namespace EFCoreTest;

public class Article
{
    public long Id { get; set; }
    public string Title { get; set; }
    public string Message { get; set; }
    public List<Commont> Commonts { get; set; } = new List<Commont>();
}