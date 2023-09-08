
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
    private readonly string baseuri;

    public JobDeclarationApprovalServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportJobDeclarationApprovalsResponse ExportJobDeclarationApprovals(
      ExportJobDeclarationApprovals arg)
    {
      return Client.Post<ExportJobDeclarationApprovals, ExportJobDeclarationApprovalsResponse>(this.username, this.password, this.baseuri, "JobDeclarationApprovalService", arg);
    }

    public Task<ExportJobDeclarationApprovalsResponse> ExportJobDeclarationApprovalsAsync(
      ExportJobDeclarationApprovals arg)
    {
      return Client.PostAsync<ExportJobDeclarationApprovals, ExportJobDeclarationApprovalsResponse>(this.username, this.password, this.baseuri, "JobDeclarationApprovalService", arg);
    }

    public ImportJobDeclarationApprovalsResponse ImportJobDeclarationApprovals(
      ImportJobDeclarationApprovals arg)
    {
      return Client.Post<ImportJobDeclarationApprovals, ImportJobDeclarationApprovalsResponse>(this.username, this.password, this.baseuri, "JobDeclarationApprovalService", arg);
    }

    public Task<ImportJobDeclarationApprovalsResponse> ImportJobDeclarationApprovalsAsync(
      ImportJobDeclarationApprovals arg)
    {
      return Client.PostAsync<ImportJobDeclarationApprovals, ImportJobDeclarationApprovalsResponse>(this.username, this.password, this.baseuri, "JobDeclarationApprovalService", arg);
    }
  }
}
