
//.DailyScheduleWindowServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class DailyScheduleWindowServiceClient
  {
    private const string service = "DailyScheduleWindowService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public DailyScheduleWindowServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public DeleteDailyScheduleWindowsListResponse DeleteDailyScheduleWindowsList(
      DeleteDailyScheduleWindowsList arg)
    {
      return Client.Post<DeleteDailyScheduleWindowsList, DeleteDailyScheduleWindowsListResponse>(this.username, this.password, this.baseuri, "DailyScheduleWindowService", arg, this.timeoutSeconds);
    }

    public Task<DeleteDailyScheduleWindowsListResponse> DeleteDailyScheduleWindowsListAsync(
      DeleteDailyScheduleWindowsList arg)
    {
      return Client.PostAsync<DeleteDailyScheduleWindowsList, DeleteDailyScheduleWindowsListResponse>(this.username, this.password, this.baseuri, "DailyScheduleWindowService", arg, this.timeoutSeconds);
    }

    public DeleteDailyScheduleWindowsResponse DeleteDailyScheduleWindows(
      DeleteDailyScheduleWindows arg)
    {
      return Client.Post<DeleteDailyScheduleWindows, DeleteDailyScheduleWindowsResponse>(this.username, this.password, this.baseuri, "DailyScheduleWindowService", arg, this.timeoutSeconds);
    }

    public Task<DeleteDailyScheduleWindowsResponse> DeleteDailyScheduleWindowsAsync(
      DeleteDailyScheduleWindows arg)
    {
      return Client.PostAsync<DeleteDailyScheduleWindows, DeleteDailyScheduleWindowsResponse>(this.username, this.password, this.baseuri, "DailyScheduleWindowService", arg, this.timeoutSeconds);
    }

    public ExportDailyScheduleWindowsListResponse ExportDailyScheduleWindowsList(
      ExportDailyScheduleWindowsList arg)
    {
      return Client.Post<ExportDailyScheduleWindowsList, ExportDailyScheduleWindowsListResponse>(this.username, this.password, this.baseuri, "DailyScheduleWindowService", arg, this.timeoutSeconds);
    }

    public Task<ExportDailyScheduleWindowsListResponse> ExportDailyScheduleWindowsListAsync(
      ExportDailyScheduleWindowsList arg)
    {
      return Client.PostAsync<ExportDailyScheduleWindowsList, ExportDailyScheduleWindowsListResponse>(this.username, this.password, this.baseuri, "DailyScheduleWindowService", arg, this.timeoutSeconds);
    }

    public ExportDailyScheduleWindowsResponse ExportDailyScheduleWindows(
      ExportDailyScheduleWindows arg)
    {
      return Client.Post<ExportDailyScheduleWindows, ExportDailyScheduleWindowsResponse>(this.username, this.password, this.baseuri, "DailyScheduleWindowService", arg, this.timeoutSeconds);
    }

    public Task<ExportDailyScheduleWindowsResponse> ExportDailyScheduleWindowsAsync(
      ExportDailyScheduleWindows arg)
    {
      return Client.PostAsync<ExportDailyScheduleWindows, ExportDailyScheduleWindowsResponse>(this.username, this.password, this.baseuri, "DailyScheduleWindowService", arg, this.timeoutSeconds);
    }
  }
}
