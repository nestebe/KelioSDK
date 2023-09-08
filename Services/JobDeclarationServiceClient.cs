
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
    private readonly string baseuri;

    public JobDeclarationServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportJobDeclarationsListResponse ExportJobDeclarationsList(
      ExportJobDeclarationsList arg)
    {
      return Client.Post<ExportJobDeclarationsList, ExportJobDeclarationsListResponse>(this.username, this.password, this.baseuri, "JobDeclarationService", arg);
    }

    public Task<ExportJobDeclarationsListResponse> ExportJobDeclarationsListAsync(
      ExportJobDeclarationsList arg)
    {
      return Client.PostAsync<ExportJobDeclarationsList, ExportJobDeclarationsListResponse>(this.username, this.password, this.baseuri, "JobDeclarationService", arg);
    }
  }
}
