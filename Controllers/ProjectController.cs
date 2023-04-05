using Microsoft.AspNetCore.Mvc;
using Timekeeper.POC.MVC.Services;

namespace Timekeeper.POC.MVC.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProjectController : ControllerBase
{
    [HttpGet]
    public IActionResult GetProjects([FromQuery] string orgUrl = "https://dev.azure.com/loopsterbr", string pat = "j4dloqciogg56dg6rhvylr2xxkxkxfc7ynec6k27k7uivbcmiqcq")
    {
        var azureDevOps = new AzureDevOps();
        var projects    = azureDevOps.GetProjects(orgUrl, pat);

        return new JsonResult(projects);
    }
}
