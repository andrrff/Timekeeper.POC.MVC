using Timekeeper.POC.MVC.Interfaces;

namespace Timekeeper.POC.MVC.Models.Request;

public class WorkItemModifiedMonth : IRequestAzureDevOps, IRequestAzureDevopsProject, IRequestAzureDevOpsUser
{
    public string OrgUrl { get; set; }
    
    public string Pat    { get; set; }
    
    public string ProjName { get; set; }
    
    public string Name { get; set; }

    public WorkItemModifiedMonth()
    {
        OrgUrl   = string.Empty;
        Pat      = string.Empty;
        ProjName = string.Empty;
        Name     = string.Empty;
    }    
}