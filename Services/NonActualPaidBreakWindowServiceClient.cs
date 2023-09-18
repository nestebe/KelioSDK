
//.NonActualPaidBreakWindowServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class NonActualPaidBreakWindowServiceClient
  {
    private const string service = "NonActualPaidBreakWindowService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public NonActualPaidBreakWindowServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ExportNonActualPaidBreakWindowsResponse ExportNonActualPaidBreakWindows(
      ExportNonActualPaidBreakWindows arg)
    {
      return Client.Post<ExportNonActualPaidBreakWindows, ExportNonActualPaidBreakWindowsResponse>(this.username, this.password, this.baseuri, "NonActualPaidBreakWindowService", arg, this.timeoutSeconds);
    }

    public Task<ExportNonActualPaidBreakWindowsResponse> ExportNonActualPaidBreakWindowsAsync(
      ExportNonActualPaidBreakWindows arg)
    {
      return Client.PostAsync<ExportNonActualPaidBreakWindows, ExportNonActualPaidBreakWindowsResponse>(this.username, this.password, this.baseuri, "NonActualPaidBreakWindowService", arg, this.timeoutSeconds);
    }

    public ExportNonActualPaidBreakWindowsListResponse ExportNonActualPaidBreakWindowsList(
      ExportNonActualPaidBreakWindowsList arg)
    {
      return Client.Post<ExportNonActualPaidBreakWindowsList, ExportNonActualPaidBreakWindowsListResponse>(this.username, this.password, this.baseuri, "NonActualPaidBreakWindowService", arg, this.timeoutSeconds);
    }

    public Task<ExportNonActualPaidBreakWindowsListResponse> ExportNonActualPaidBreakWindowsListAsync(
      ExportNonActualPaidBreakWindowsList arg)
    {
      return Client.PostAsync<ExportNonActualPaidBreakWindowsList, ExportNonActualPaidBreakWindowsListResponse>(this.username, this.password, this.baseuri, "NonActualPaidBreakWindowService", arg, this.timeoutSeconds);
    }

    public ImportNonActualPaidBreakWindowsResponse ImportNonActualPaidBreakWindows(
      ImportNonActualPaidBreakWindows arg)
    {
      return Client.Post<ImportNonActualPaidBreakWindows, ImportNonActualPaidBreakWindowsResponse>(this.username, this.password, this.baseuri, "NonActualPaidBreakWindowService", arg, this.timeoutSeconds);
    }

    public Task<ImportNonActualPaidBreakWindowsResponse> ImportNonActualPaidBreakWindowsAsync(
      ImportNonActualPaidBreakWindows arg)
    {
      return Client.PostAsync<ImportNonActualPaidBreakWindows, ImportNonActualPaidBreakWindowsResponse>(this.username, this.password, this.baseuri, "NonActualPaidBreakWindowService", arg, this.timeoutSeconds);
    }
  }
}
