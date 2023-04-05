using Microsoft.AspNetCore.Mvc;
using Timekeeper.POC.MVC.Services;
using Timekeeper.POC.MVC.Models.Request;

namespace Timekeeper.POC.MVC.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WorkItemByIdController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> GetWorkItemByIdAsync([FromBody] RequestWorkItemById req)
    {
        var azureDevOps = new AzureDevOps();
        var workItems   = await azureDevOps.GetWorkItemAsync(req.OrgUrl, req.Pat, req.WorkItemId);

        return new JsonResult(workItems);
    }
}
