
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
    private readonly string baseuri; private readonly int timeoutSeconds;

    public ToleranceWindowServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ImportToleranceWindowsResponse ImportToleranceWindows(
      ImportToleranceWindows arg)
    {
      return Client.Post<ImportToleranceWindows, ImportToleranceWindowsResponse>(this.username, this.password, this.baseuri, "ToleranceWindowService", arg, this.timeoutSeconds);
    }

    public Task<ImportToleranceWindowsResponse> ImportToleranceWindowsAsync(
      ImportToleranceWindows arg)
    {
      return Client.PostAsync<ImportToleranceWindows, ImportToleranceWindowsResponse>(this.username, this.password, this.baseuri, "ToleranceWindowService", arg, this.timeoutSeconds);
    }

    public ExportToleranceWindowsListResponse ExportToleranceWindowsList(
      ExportToleranceWindowsList arg)
    {
      return Client.Post<ExportToleranceWindowsList, ExportToleranceWindowsListResponse>(this.username, this.password, this.baseuri, "ToleranceWindowService", arg, this.timeoutSeconds);
    }

    public Task<ExportToleranceWindowsListResponse> ExportToleranceWindowsListAsync(
      ExportToleranceWindowsList arg)
    {
      return Client.PostAsync<ExportToleranceWindowsList, ExportToleranceWindowsListResponse>(this.username, this.password, this.baseuri, "ToleranceWindowService", arg, this.timeoutSeconds);
    }

    public ExportToleranceWindowsResponse ExportToleranceWindows(
      ExportToleranceWindows arg)
    {
      return Client.Post<ExportToleranceWindows, ExportToleranceWindowsResponse>(this.username, this.password, this.baseuri, "ToleranceWindowService", arg, this.timeoutSeconds);
    }

    public Task<ExportToleranceWindowsResponse> ExportToleranceWindowsAsync(
      ExportToleranceWindows arg)
    {
      return Client.PostAsync<ExportToleranceWindows, ExportToleranceWindowsResponse>(this.username, this.password, this.baseuri, "ToleranceWindowService", arg, this.timeoutSeconds);
    }
  }
}
