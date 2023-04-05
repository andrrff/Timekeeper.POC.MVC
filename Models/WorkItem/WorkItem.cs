namespace Timekeeper.POC.MVC.Models.WorkItem;

public class WorkItem
{
    public int Id { get; set; }
    public Dictionary<string, object>? Fields { get; set; }
}