using Newtonsoft.Json;

namespace Timekeeper.POC.MVC.Models.WorkItem;

public class WorkItemRoot
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Avatar
    {
        public string? href { get; set; }
    }

    public class Fields
    {
        [JsonProperty("System.AreaPath")]
        public string? SystemAreaPath { get; set; }

        [JsonProperty("System.TeamProject")]
        public string? SystemTeamProject { get; set; }

        [JsonProperty("System.IterationPath")]
        public string? SystemIterationPath { get; set; }

        [JsonProperty("System.WorkItemType")]
        public string? SystemWorkItemType { get; set; }

        [JsonProperty("System.State")]
        public string? SystemState { get; set; }

        [JsonProperty("System.Reason")]
        public string? SystemReason { get; set; }

        [JsonProperty("System.AssignedTo")]
        public SystemAssignedTo? SystemAssignedTo { get; set; }

        [JsonProperty("System.CreatedDate")]
        public DateTime SystemCreatedDate { get; set; }

        [JsonProperty("System.CreatedBy")]
        public SystemCreatedBy? SystemCreatedBy { get; set; }

        [JsonProperty("System.ChangedDate")]
        public DateTime SystemChangedDate { get; set; }

        [JsonProperty("System.ChangedBy")]
        public SystemChangedBy? SystemChangedBy { get; set; }

        [JsonProperty("System.CommentCount")]
        public int SystemCommentCount { get; set; }

        [JsonProperty("System.Title")]
        public string? SystemTitle { get; set; }

        [JsonProperty("System.BoardColumn")]
        public string? SystemBoardColumn { get; set; }

        [JsonProperty("System.BoardColumnDone")]
        public bool SystemBoardColumnDone { get; set; }

        [JsonProperty("Microsoft.VSTS.Common.StateChangeDate")]
        public DateTime MicrosoftVSTSCommonStateChangeDate { get; set; }

        [JsonProperty("Microsoft.VSTS.Common.ActivatedDate")]
        public DateTime MicrosoftVSTSCommonActivatedDate { get; set; }

        [JsonProperty("Microsoft.VSTS.Common.ActivatedBy")]
        public MicrosoftVSTSCommonActivatedBy? MicrosoftVSTSCommonActivatedBy { get; set; }

        [JsonProperty("Microsoft.VSTS.Common.ResolvedDate")]
        public DateTime MicrosoftVSTSCommonResolvedDate { get; set; }

        [JsonProperty("Microsoft.VSTS.Common.ResolvedBy")]
        public MicrosoftVSTSCommonResolvedBy? MicrosoftVSTSCommonResolvedBy { get; set; }

        [JsonProperty("Microsoft.VSTS.Common.Priority")]
        public int MicrosoftVSTSCommonPriority { get; set; }

        [JsonProperty("Microsoft.VSTS.Common.StackRank")]
        public double MicrosoftVSTSCommonStackRank { get; set; }

        [JsonProperty("Microsoft.VSTS.Common.ValueArea")]
        public string? MicrosoftVSTSCommonValueArea { get; set; }

        [JsonProperty("Microsoft.VSTS.Scheduling.FinishDate")]
        public DateTime MicrosoftVSTSSchedulingFinishDate { get; set; }

        [JsonProperty("WEF_B82049C971984EB182C1975E13FA20A5_Kanban.Column")]
        public string? WEF_B82049C971984EB182C1975E13FA20A5_KanbanColumn { get; set; }

        [JsonProperty("WEF_B82049C971984EB182C1975E13FA20A5_Kanban.Column.Done")]
        public bool WEF_B82049C971984EB182C1975E13FA20A5_KanbanColumnDone { get; set; }

        [JsonProperty("Custom.DeployHML")]
        public DateTime CustomDeployHML { get; set; }

        [JsonProperty("System.Description")]
        public string? SystemDescription { get; set; }
    }

    public class Links
    {
        public Avatar? avatar { get; set; }
    }

    public class MicrosoftVSTSCommonActivatedBy
    {
        public string? displayName { get; set; }
        public string? url { get; set; }
        public Links? _links { get; set; }
        public string? id { get; set; }
        public string? uniqueName { get; set; }
        public string? imageUrl { get; set; }
        public string? descriptor { get; set; }
    }

    public class MicrosoftVSTSCommonResolvedBy
    {
        public string? displayName { get; set; }
        public string? url { get; set; }
        public Links? _links { get; set; }
        public string? id { get; set; }
        public string? uniqueName { get; set; }
        public string? imageUrl { get; set; }
        public string? descriptor { get; set; }
    }

    public class Root
    {
        public int count { get; set; }
        public List<Value>? value { get; set; }
    }

    public class SystemAssignedTo
    {
        public string? displayName { get; set; }
        public string? url { get; set; }
        public Links? _links { get; set; }
        public string? id { get; set; }
        public string? uniqueName { get; set; }
        public string? imageUrl { get; set; }
        public string? descriptor { get; set; }
    }

    public class SystemChangedBy
    {
        public string? displayName { get; set; }
        public string? url { get; set; }
        public Links? _links { get; set; }
        public string? id { get; set; }
        public string? uniqueName { get; set; }
        public string? imageUrl { get; set; }
        public string? descriptor { get; set; }
    }

    public class SystemCreatedBy
    {
        public string? displayName { get; set; }
        public string? url { get; set; }
        public Links? _links { get; set; }
        public string? id { get; set; }
        public string? uniqueName { get; set; }
        public string? imageUrl { get; set; }
        public string? descriptor { get; set; }
    }

    public class Value
    {
        public int id { get; set; }
        public int rev { get; set; }
        public Fields? fields { get; set; }
        public string? url { get; set; }
    }


}