
//.RuleExtensionExecutionServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class RuleExtensionExecutionServiceClient
  {
    private const string service = "RuleExtensionExecutionService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public RuleExtensionExecutionServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ImportRuleExtensionExecutionResponse ImportRuleExtensionExecution(
      ImportRuleExtensionExecution arg)
    {
      return Client.Post<ImportRuleExtensionExecution, ImportRuleExtensionExecutionResponse>(this.username, this.password, this.baseuri, "RuleExtensionExecutionService", arg, this.timeoutSeconds);
    }

    public Task<ImportRuleExtensionExecutionResponse> ImportRuleExtensionExecutionAsync(
      ImportRuleExtensionExecution arg)
    {
      return Client.PostAsync<ImportRuleExtensionExecution, ImportRuleExtensionExecutionResponse>(this.username, this.password, this.baseuri, "RuleExtensionExecutionService", arg, this.timeoutSeconds);
    }

    public ExportRuleExtensionExecutionResponse ExportRuleExtensionExecution(
      ExportRuleExtensionExecution arg)
    {
      return Client.Post<ExportRuleExtensionExecution, ExportRuleExtensionExecutionResponse>(this.username, this.password, this.baseuri, "RuleExtensionExecutionService", arg, this.timeoutSeconds);
    }

    public Task<ExportRuleExtensionExecutionResponse> ExportRuleExtensionExecutionAsync(
      ExportRuleExtensionExecution arg)
    {
      return Client.PostAsync<ExportRuleExtensionExecution, ExportRuleExtensionExecutionResponse>(this.username, this.password, this.baseuri, "RuleExtensionExecutionService", arg, this.timeoutSeconds);
    }

    public DeleteRuleExtensionExecutionResponse DeleteRuleExtensionExecution(
      DeleteRuleExtensionExecution arg)
    {
      return Client.Post<DeleteRuleExtensionExecution, DeleteRuleExtensionExecutionResponse>(this.username, this.password, this.baseuri, "RuleExtensionExecutionService", arg, this.timeoutSeconds);
    }

    public Task<DeleteRuleExtensionExecutionResponse> DeleteRuleExtensionExecutionAsync(
      DeleteRuleExtensionExecution arg)
    {
      return Client.PostAsync<DeleteRuleExtensionExecution, DeleteRuleExtensionExecutionResponse>(this.username, this.password, this.baseuri, "RuleExtensionExecutionService", arg, this.timeoutSeconds);
    }
  }
}
