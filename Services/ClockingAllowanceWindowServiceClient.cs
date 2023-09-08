
//.ClockingAllowanceWindowServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class ClockingAllowanceWindowServiceClient
  {
    private const string service = "ClockingAllowanceWindowService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public ClockingAllowanceWindowServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportClockingAllowanceWindowsResponse ExportClockingAllowanceWindows(
      ExportClockingAllowanceWindows arg)
    {
      return Client.Post<ExportClockingAllowanceWindows, ExportClockingAllowanceWindowsResponse>(this.username, this.password, this.baseuri, "ClockingAllowanceWindowService", arg);
    }

    public Task<ExportClockingAllowanceWindowsResponse> ExportClockingAllowanceWindowsAsync(
      ExportClockingAllowanceWindows arg)
    {
      return Client.PostAsync<ExportClockingAllowanceWindows, ExportClockingAllowanceWindowsResponse>(this.username, this.password, this.baseuri, "ClockingAllowanceWindowService", arg);
    }

    public ExportClockingAllowanceWindowsListResponse ExportClockingAllowanceWindowsList(
      ExportClockingAllowanceWindowsList arg)
    {
      return Client.Post<ExportClockingAllowanceWindowsList, ExportClockingAllowanceWindowsListResponse>(this.username, this.password, this.baseuri, "ClockingAllowanceWindowService", arg);
    }

    public Task<ExportClockingAllowanceWindowsListResponse> ExportClockingAllowanceWindowsListAsync(
      ExportClockingAllowanceWindowsList arg)
    {
      return Client.PostAsync<ExportClockingAllowanceWindowsList, ExportClockingAllowanceWindowsListResponse>(this.username, this.password, this.baseuri, "ClockingAllowanceWindowService", arg);
    }

    public ImportClockingAllowanceWindowsResponse ImportClockingAllowanceWindows(
      ImportClockingAllowanceWindows arg)
    {
      return Client.Post<ImportClockingAllowanceWindows, ImportClockingAllowanceWindowsResponse>(this.username, this.password, this.baseuri, "ClockingAllowanceWindowService", arg);
    }

    public Task<ImportClockingAllowanceWindowsResponse> ImportClockingAllowanceWindowsAsync(
      ImportClockingAllowanceWindows arg)
    {
      return Client.PostAsync<ImportClockingAllowanceWindows, ImportClockingAllowanceWindowsResponse>(this.username, this.password, this.baseuri, "ClockingAllowanceWindowService", arg);
    }
  }
}
