namespace EFCoreTest;

public class Leave
{
    public long Id { get; set; }
    public User? Approver { get; set; }
    public User? Requester { get; set; }
    public DateTime Time { get; set; }
}