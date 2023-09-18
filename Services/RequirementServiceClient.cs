
//.RequirementServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class RequirementServiceClient
  {
    private const string service = "RequirementService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public RequirementServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public DeleteRequirementsResponse DeleteRequirements(
      DeleteRequirements arg)
    {
      return Client.Post<DeleteRequirements, DeleteRequirementsResponse>(this.username, this.password, this.baseuri, "RequirementService", arg, this.timeoutSeconds);
    }

    public Task<DeleteRequirementsResponse> DeleteRequirementsAsync(
      DeleteRequirements arg)
    {
      return Client.PostAsync<DeleteRequirements, DeleteRequirementsResponse>(this.username, this.password, this.baseuri, "RequirementService", arg, this.timeoutSeconds);
    }

    public ImportRequirementsResponse ImportRequirements(
      ImportRequirements arg)
    {
      return Client.Post<ImportRequirements, ImportRequirementsResponse>(this.username, this.password, this.baseuri, "RequirementService", arg, this.timeoutSeconds);
    }

    public Task<ImportRequirementsResponse> ImportRequirementsAsync(
      ImportRequirements arg)
    {
      return Client.PostAsync<ImportRequirements, ImportRequirementsResponse>(this.username, this.password, this.baseuri, "RequirementService", arg, this.timeoutSeconds);
    }

    public ExportRequirementsResponse ExportRequirements(
      ExportRequirements arg)
    {
      return Client.Post<ExportRequirements, ExportRequirementsResponse>(this.username, this.password, this.baseuri, "RequirementService", arg, this.timeoutSeconds);
    }

    public Task<ExportRequirementsResponse> ExportRequirementsAsync(
      ExportRequirements arg)
    {
      return Client.PostAsync<ExportRequirements, ExportRequirementsResponse>(this.username, this.password, this.baseuri, "RequirementService", arg, this.timeoutSeconds);
    }
  }
}
