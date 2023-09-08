
//.ToleranceWindowServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class ToleranceWindowServiceClient
  {
    private const string service = "ToleranceWindowService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public ToleranceWindowServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ImportToleranceWindowsResponse ImportToleranceWindows(
      ImportToleranceWindows arg)
    {
      return Client.Post<ImportToleranceWindows, ImportToleranceWindowsResponse>(this.username, this.password, this.baseuri, "ToleranceWindowService", arg);
    }

    public Task<ImportToleranceWindowsResponse> ImportToleranceWindowsAsync(
      ImportToleranceWindows arg)
    {
      return Client.PostAsync<ImportToleranceWindows, ImportToleranceWindowsResponse>(this.username, this.password, this.baseuri, "ToleranceWindowService", arg);
    }

    public ExportToleranceWindowsListResponse ExportToleranceWindowsList(
      ExportToleranceWindowsList arg)
    {
      return Client.Post<ExportToleranceWindowsList, ExportToleranceWindowsListResponse>(this.username, this.password, this.baseuri, "ToleranceWindowService", arg);
    }

    public Task<ExportToleranceWindowsListResponse> ExportToleranceWindowsListAsync(
      ExportToleranceWindowsList arg)
    {
      return Client.PostAsync<ExportToleranceWindowsList, ExportToleranceWindowsListResponse>(this.username, this.password, this.baseuri, "ToleranceWindowService", arg);
    }

    public ExportToleranceWindowsResponse ExportToleranceWindows(
      ExportToleranceWindows arg)
    {
      return Client.Post<ExportToleranceWindows, ExportToleranceWindowsResponse>(this.username, this.password, this.baseuri, "ToleranceWindowService", arg);
    }

    public Task<ExportToleranceWindowsResponse> ExportToleranceWindowsAsync(
      ExportToleranceWindows arg)
    {
      return Client.PostAsync<ExportToleranceWindows, ExportToleranceWindowsResponse>(this.username, this.password, this.baseuri, "ToleranceWindowService", arg);
    }
  }
}
