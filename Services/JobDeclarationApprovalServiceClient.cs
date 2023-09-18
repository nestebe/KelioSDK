
//.JobDeclarationApprovalServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class JobDeclarationApprovalServiceClient
  {
    private const string service = "JobDeclarationApprovalService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public JobDeclarationApprovalServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ExportJobDeclarationApprovalsResponse ExportJobDeclarationApprovals(
      ExportJobDeclarationApprovals arg)
    {
      return Client.Post<ExportJobDeclarationApprovals, ExportJobDeclarationApprovalsResponse>(this.username, this.password, this.baseuri, "JobDeclarationApprovalService", arg, this.timeoutSeconds);
    }

    public Task<ExportJobDeclarationApprovalsResponse> ExportJobDeclarationApprovalsAsync(
      ExportJobDeclarationApprovals arg)
    {
      return Client.PostAsync<ExportJobDeclarationApprovals, ExportJobDeclarationApprovalsResponse>(this.username, this.password, this.baseuri, "JobDeclarationApprovalService", arg, this.timeoutSeconds);
    }

    public ImportJobDeclarationApprovalsResponse ImportJobDeclarationApprovals(
      ImportJobDeclarationApprovals arg)
    {
      return Client.Post<ImportJobDeclarationApprovals, ImportJobDeclarationApprovalsResponse>(this.username, this.password, this.baseuri, "JobDeclarationApprovalService", arg, this.timeoutSeconds);
    }

    public Task<ImportJobDeclarationApprovalsResponse> ImportJobDeclarationApprovalsAsync(
      ImportJobDeclarationApprovals arg)
    {
      return Client.PostAsync<ImportJobDeclarationApprovals, ImportJobDeclarationApprovalsResponse>(this.username, this.password, this.baseuri, "JobDeclarationApprovalService", arg, this.timeoutSeconds);
    }
  }
}
