using System.Text;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using Timekeeper.POC.MVC.Models.Response;
using Microsoft.TeamFoundation.Core.WebApi;
using Microsoft.VisualStudio.Services.WebApi;
using Microsoft.VisualStudio.Services.Common;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi.Models;

namespace Timekeeper.POC.MVC.Services;

public class AzureDevOps
{

    public string GetWorkItemByIdUrl(string organizationUrl, string ids) => $"{organizationUrl}/_apis/wit/workitems?ids={ids}&api-version=7.0";

    public HttpClient GetHttpClient(string pat)
    {
        var httpClient = new HttpClient();

        httpClient.DefaultRequestHeaders.Accept.Clear();
        httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.ASCII.GetBytes($":{pat}")));

        return httpClient;
    }

    public string GetProjects(string azureDevOpsOrganizationUrl, string pat)
    {
        try
        {
            var credentials   = new VssBasicCredential(string.Empty, pat);
            var connection    = new VssConnection(new Uri(azureDevOpsOrganizationUrl), credentials);

            var projectClient = connection.GetClient<ProjectHttpClient>();
            var projects      = projectClient.GetProjects().Result;
            var retBuilder    = new System.Text.StringBuilder();

            foreach (TeamProjectReference p in projects)
            {
                retBuilder.AppendLine($"{p.Name} ({p.Id}) - {p.Description} - {p.Url} - {p.State}\n");
            }

            return retBuilder.ToString();
        }
        catch (Exception ex)
        {
            return $"{ex.GetType()}: {ex.Message}";
        }
    }

    public async Task<ResponseWorkItem.Root> GetWorkItemAsync(string organizationUrl, string pat, string workItemId)
    {
        var url       = GetWorkItemByIdUrl(organizationUrl, workItemId);
        var workItems = new ResponseWorkItem.Root();
        var client    = GetHttpClient(pat);
        var response  = await client.GetAsync(url);

        System.Console.WriteLine(url);

        if (response.IsSuccessStatusCode)
        {
            var responseBody = await response.Content.ReadAsStringAsync();
            var workItemList = JsonConvert.DeserializeObject<ResponseWorkItem.Root>(responseBody);

            if (workItemList is not null)
            {
                return workItemList;
            }
        }
        else
        {
            Console.WriteLine($"Erro ao obter work items. Código de status HTTP: {response.StatusCode}");
        }

        return workItems;
    }

    public List<int> GetWorkItemModifiedMonth(string organizationUrl, string pat, string name, string project)
    {        
        var connection    = new VssConnection(new Uri(organizationUrl), new VssBasicCredential(string.Empty, pat));
        var witClient     = connection.GetClient<WorkItemTrackingHttpClient>();
        var lastMonthDate = DateTime.Now.AddMonths(-1).ToString("yyyy-MM-dd");
        var query         = $"SELECT [System.Id], [System.Title], [System.State], [System.ChangedDate] FROM workitems WHERE [System.ChangedDate] > '{lastMonthDate}' AND [System.ChangedBy] = '{name}' ORDER BY [System.ChangedDate] DESC";
        var queryWiql     = new Wiql() { Query = query };
        var queryResult   = witClient.QueryByWiqlAsync(queryWiql, project).Result;

        if (queryResult.WorkItems.Count() > 0)
        {
            var workItemIds = new List<int>();

            foreach (var workItemReference in queryResult.WorkItems)
            {
                workItemIds.Add(workItemReference.Id);
            }

            Console.WriteLine($"IDs dos workitems modificados pelo usuário '{name}' nos últimos {lastMonthDate} mês(es): {string.Join(",", workItemIds)}");
            return workItemIds;
        }
        else
        {
            Console.WriteLine($"Não foram encontrados workitems modificados pelo usuário '{name}' nos últimos {lastMonthDate} mês(es).");
        }

        return new List<int>();
    }
}