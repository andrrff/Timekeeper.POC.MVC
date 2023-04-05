using Microsoft.AspNetCore.Mvc;
using Timekeeper.POC.MVC.Services;
using Timekeeper.POC.MVC.Models.Request;

namespace Timekeeper.POC.MVC.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WorkItemModifiedMonthController : ControllerBase
{
    [HttpPost]
    public IActionResult GetWorkItemModifiedMonth([FromBody] WorkItemModifiedMonth req)
    {
        var azureDevOps = new AzureDevOps();
        var workItems   = azureDevOps.GetWorkItemModifiedMonth(req.OrgUrl, req.Pat, req.Name, req.ProjName);

        return new JsonResult(workItems);
    }
}
