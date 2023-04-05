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
        OrgUrl   = "https://dev.azure.com/loopsterbr";
        Pat      = "j4dloqciogg56dg6rhvylr2xxkxkxfc7ynec6k27k7uivbcmiqcq";
        ProjName = "LoopsterBR - Easy Fleet";
        Name     = "Andre Freitas";
    }    
}