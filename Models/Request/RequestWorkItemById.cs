using Timekeeper.POC.MVC.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Timekeeper.POC.MVC.Models.Request;

public class RequestWorkItemById : IRequestAzureDevOps, IRequestWorkItemById
{
    [Required]
    public string OrgUrl { get; set; }

    [Required]
    public string Pat    { get; set; }

    [Required]
    public string WorkItemId { get; set; }

    public RequestWorkItemById()
    {
        OrgUrl     = string.Empty;
        Pat        = string.Empty;
        WorkItemId = string.Empty;
    }
}