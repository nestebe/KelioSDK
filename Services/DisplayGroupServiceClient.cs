
//.DisplayGroupServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class DisplayGroupServiceClient
  {
    private const string service = "DisplayGroupService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public DisplayGroupServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ImportDisplayGroupsResponse ImportDisplayGroups(
      ImportDisplayGroups arg)
    {
      return Client.Post<ImportDisplayGroups, ImportDisplayGroupsResponse>(this.username, this.password, this.baseuri, "DisplayGroupService", arg);
    }

    public Task<ImportDisplayGroupsResponse> ImportDisplayGroupsAsync(
      ImportDisplayGroups arg)
    {
      return Client.PostAsync<ImportDisplayGroups, ImportDisplayGroupsResponse>(this.username, this.password, this.baseuri, "DisplayGroupService", arg);
    }

    public ExportDisplayGroupsResponse ExportDisplayGroups(
      ExportDisplayGroups arg)
    {
      return Client.Post<ExportDisplayGroups, ExportDisplayGroupsResponse>(this.username, this.password, this.baseuri, "DisplayGroupService", arg);
    }

    public Task<ExportDisplayGroupsResponse> ExportDisplayGroupsAsync(
      ExportDisplayGroups arg)
    {
      return Client.PostAsync<ExportDisplayGroups, ExportDisplayGroupsResponse>(this.username, this.password, this.baseuri, "DisplayGroupService", arg);
    }
  }
}
