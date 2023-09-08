
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
    private readonly string baseuri;

    public NonActualPaidBreakWindowServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportNonActualPaidBreakWindowsResponse ExportNonActualPaidBreakWindows(
      ExportNonActualPaidBreakWindows arg)
    {
      return Client.Post<ExportNonActualPaidBreakWindows, ExportNonActualPaidBreakWindowsResponse>(this.username, this.password, this.baseuri, "NonActualPaidBreakWindowService", arg);
    }

    public Task<ExportNonActualPaidBreakWindowsResponse> ExportNonActualPaidBreakWindowsAsync(
      ExportNonActualPaidBreakWindows arg)
    {
      return Client.PostAsync<ExportNonActualPaidBreakWindows, ExportNonActualPaidBreakWindowsResponse>(this.username, this.password, this.baseuri, "NonActualPaidBreakWindowService", arg);
    }

    public ExportNonActualPaidBreakWindowsListResponse ExportNonActualPaidBreakWindowsList(
      ExportNonActualPaidBreakWindowsList arg)
    {
      return Client.Post<ExportNonActualPaidBreakWindowsList, ExportNonActualPaidBreakWindowsListResponse>(this.username, this.password, this.baseuri, "NonActualPaidBreakWindowService", arg);
    }

    public Task<ExportNonActualPaidBreakWindowsListResponse> ExportNonActualPaidBreakWindowsListAsync(
      ExportNonActualPaidBreakWindowsList arg)
    {
      return Client.PostAsync<ExportNonActualPaidBreakWindowsList, ExportNonActualPaidBreakWindowsListResponse>(this.username, this.password, this.baseuri, "NonActualPaidBreakWindowService", arg);
    }

    public ImportNonActualPaidBreakWindowsResponse ImportNonActualPaidBreakWindows(
      ImportNonActualPaidBreakWindows arg)
    {
      return Client.Post<ImportNonActualPaidBreakWindows, ImportNonActualPaidBreakWindowsResponse>(this.username, this.password, this.baseuri, "NonActualPaidBreakWindowService", arg);
    }

    public Task<ImportNonActualPaidBreakWindowsResponse> ImportNonActualPaidBreakWindowsAsync(
      ImportNonActualPaidBreakWindows arg)
    {
      return Client.PostAsync<ImportNonActualPaidBreakWindows, ImportNonActualPaidBreakWindowsResponse>(this.username, this.password, this.baseuri, "NonActualPaidBreakWindowService", arg);
    }
  }
}
