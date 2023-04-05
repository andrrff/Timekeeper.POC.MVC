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
        OrgUrl     = "https://dev.azure.com/loopsterbr";
        Pat        = "j4dloqciogg56dg6rhvylr2xxkxkxfc7ynec6k27k7uivbcmiqcq";
        WorkItemId = "3964";
    }
}