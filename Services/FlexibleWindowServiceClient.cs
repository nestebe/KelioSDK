
//.FlexibleWindowServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class FlexibleWindowServiceClient
  {
    private const string service = "FlexibleWindowService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public FlexibleWindowServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ImportFlexibleWindowsResponse ImportFlexibleWindows(
      ImportFlexibleWindows arg)
    {
      return Client.Post<ImportFlexibleWindows, ImportFlexibleWindowsResponse>(this.username, this.password, this.baseuri, "FlexibleWindowService", arg, this.timeoutSeconds);
    }

    public Task<ImportFlexibleWindowsResponse> ImportFlexibleWindowsAsync(
      ImportFlexibleWindows arg)
    {
      return Client.PostAsync<ImportFlexibleWindows, ImportFlexibleWindowsResponse>(this.username, this.password, this.baseuri, "FlexibleWindowService", arg, this.timeoutSeconds);
    }

    public ExportFlexibleWindowsListResponse ExportFlexibleWindowsList(
      ExportFlexibleWindowsList arg)
    {
      return Client.Post<ExportFlexibleWindowsList, ExportFlexibleWindowsListResponse>(this.username, this.password, this.baseuri, "FlexibleWindowService", arg, this.timeoutSeconds);
    }

    public Task<ExportFlexibleWindowsListResponse> ExportFlexibleWindowsListAsync(
      ExportFlexibleWindowsList arg)
    {
      return Client.PostAsync<ExportFlexibleWindowsList, ExportFlexibleWindowsListResponse>(this.username, this.password, this.baseuri, "FlexibleWindowService", arg, this.timeoutSeconds);
    }

    public ExportFlexibleWindowsResponse ExportFlexibleWindows(
      ExportFlexibleWindows arg)
    {
      return Client.Post<ExportFlexibleWindows, ExportFlexibleWindowsResponse>(this.username, this.password, this.baseuri, "FlexibleWindowService", arg, this.timeoutSeconds);
    }

    public Task<ExportFlexibleWindowsResponse> ExportFlexibleWindowsAsync(
      ExportFlexibleWindows arg)
    {
      return Client.PostAsync<ExportFlexibleWindows, ExportFlexibleWindowsResponse>(this.username, this.password, this.baseuri, "FlexibleWindowService", arg, this.timeoutSeconds);
    }
  }
}
