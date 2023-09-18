
//.OvertimeHoursWindowServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class OvertimeHoursWindowServiceClient
  {
    private const string service = "OvertimeHoursWindowService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public OvertimeHoursWindowServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ExportOvertimeHoursWindowsResponse ExportOvertimeHoursWindows(
      ExportOvertimeHoursWindows arg)
    {
      return Client.Post<ExportOvertimeHoursWindows, ExportOvertimeHoursWindowsResponse>(this.username, this.password, this.baseuri, "OvertimeHoursWindowService", arg, this.timeoutSeconds);
    }

    public Task<ExportOvertimeHoursWindowsResponse> ExportOvertimeHoursWindowsAsync(
      ExportOvertimeHoursWindows arg)
    {
      return Client.PostAsync<ExportOvertimeHoursWindows, ExportOvertimeHoursWindowsResponse>(this.username, this.password, this.baseuri, "OvertimeHoursWindowService", arg, this.timeoutSeconds);
    }

    public ExportOvertimeHoursWindowsListResponse ExportOvertimeHoursWindowsList(
      ExportOvertimeHoursWindowsList arg)
    {
      return Client.Post<ExportOvertimeHoursWindowsList, ExportOvertimeHoursWindowsListResponse>(this.username, this.password, this.baseuri, "OvertimeHoursWindowService", arg, this.timeoutSeconds);
    }

    public Task<ExportOvertimeHoursWindowsListResponse> ExportOvertimeHoursWindowsListAsync(
      ExportOvertimeHoursWindowsList arg)
    {
      return Client.PostAsync<ExportOvertimeHoursWindowsList, ExportOvertimeHoursWindowsListResponse>(this.username, this.password, this.baseuri, "OvertimeHoursWindowService", arg, this.timeoutSeconds);
    }

    public ImportOvertimeHoursWindowsResponse ImportOvertimeHoursWindows(
      ImportOvertimeHoursWindows arg)
    {
      return Client.Post<ImportOvertimeHoursWindows, ImportOvertimeHoursWindowsResponse>(this.username, this.password, this.baseuri, "OvertimeHoursWindowService", arg, this.timeoutSeconds);
    }

    public Task<ImportOvertimeHoursWindowsResponse> ImportOvertimeHoursWindowsAsync(
      ImportOvertimeHoursWindows arg)
    {
      return Client.PostAsync<ImportOvertimeHoursWindows, ImportOvertimeHoursWindowsResponse>(this.username, this.password, this.baseuri, "OvertimeHoursWindowService", arg, this.timeoutSeconds);
    }
  }
}
