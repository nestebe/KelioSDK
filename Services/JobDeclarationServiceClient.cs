
//.JobDeclarationServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class JobDeclarationServiceClient
  {
    private const string service = "JobDeclarationService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public JobDeclarationServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ExportJobDeclarationsListResponse ExportJobDeclarationsList(
      ExportJobDeclarationsList arg)
    {
      return Client.Post<ExportJobDeclarationsList, ExportJobDeclarationsListResponse>(this.username, this.password, this.baseuri, "JobDeclarationService", arg, this.timeoutSeconds);
    }

    public Task<ExportJobDeclarationsListResponse> ExportJobDeclarationsListAsync(
      ExportJobDeclarationsList arg)
    {
      return Client.PostAsync<ExportJobDeclarationsList, ExportJobDeclarationsListResponse>(this.username, this.password, this.baseuri, "JobDeclarationService", arg, this.timeoutSeconds);
    }
  }
}
