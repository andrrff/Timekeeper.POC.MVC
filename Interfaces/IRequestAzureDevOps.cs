namespace Timekeeper.POC.MVC.Interfaces;

public interface IRequestAzureDevOps
{
    string OrgUrl { get; set; }

    string Pat { get; set; }
}