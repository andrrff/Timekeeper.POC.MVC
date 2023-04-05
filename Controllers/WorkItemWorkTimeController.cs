using Microsoft.AspNetCore.Mvc;
using Timekeeper.POC.MVC.Services;
using Timekeeper.POC.MVC.Models.Request;

namespace Timekeeper.POC.MVC.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WorkItemWorkTimeController : ControllerBase
{
    [HttpPost]
    public IActionResult GetWorkItemModifiedMonth([FromBody] WorkItemModifiedMonth req)
    {
        var azureDevOps  = new AzureDevOps();
        var workItemsLst = azureDevOps.GetWorkItemWorkTime(req.OrgUrl, req.Pat, req.Name, req.ProjName);

        return new JsonResult(workItemsLst);
    }
}
