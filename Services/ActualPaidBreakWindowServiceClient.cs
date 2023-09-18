
//.ActualPaidBreakWindowServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class ActualPaidBreakWindowServiceClient
  {
    private const string service = "ActualPaidBreakWindowService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public ActualPaidBreakWindowServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ImportActualPaidBreakWindowsResponse ImportActualPaidBreakWindows(
      ImportActualPaidBreakWindows arg)
    {
      return Client.Post<ImportActualPaidBreakWindows, ImportActualPaidBreakWindowsResponse>(this.username, this.password, this.baseuri, "ActualPaidBreakWindowService", arg, this.timeoutSeconds);
    }

    public Task<ImportActualPaidBreakWindowsResponse> ImportActualPaidBreakWindowsAsync(
      ImportActualPaidBreakWindows arg)
    {
      return Client.PostAsync<ImportActualPaidBreakWindows, ImportActualPaidBreakWindowsResponse>(this.username, this.password, this.baseuri, "ActualPaidBreakWindowService", arg, this.timeoutSeconds);
    }

    public ExportActualPaidBreakWindowsListResponse ExportActualPaidBreakWindowsList(
      ExportActualPaidBreakWindowsList arg)
    {
      return Client.Post<ExportActualPaidBreakWindowsList, ExportActualPaidBreakWindowsListResponse>(this.username, this.password, this.baseuri, "ActualPaidBreakWindowService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPaidBreakWindowsListResponse> ExportActualPaidBreakWindowsListAsync(
      ExportActualPaidBreakWindowsList arg)
    {
      return Client.PostAsync<ExportActualPaidBreakWindowsList, ExportActualPaidBreakWindowsListResponse>(this.username, this.password, this.baseuri, "ActualPaidBreakWindowService", arg, this.timeoutSeconds);
    }

    public ExportActualPaidBreakWindowsResponse ExportActualPaidBreakWindows(
      ExportActualPaidBreakWindows arg)
    {
      return Client.Post<ExportActualPaidBreakWindows, ExportActualPaidBreakWindowsResponse>(this.username, this.password, this.baseuri, "ActualPaidBreakWindowService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPaidBreakWindowsResponse> ExportActualPaidBreakWindowsAsync(
      ExportActualPaidBreakWindows arg)
    {
      return Client.PostAsync<ExportActualPaidBreakWindows, ExportActualPaidBreakWindowsResponse>(this.username, this.password, this.baseuri, "ActualPaidBreakWindowService", arg, this.timeoutSeconds);
    }
  }
}
