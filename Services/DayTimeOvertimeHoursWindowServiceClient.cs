
//.DayTimeOvertimeHoursWindowServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class DayTimeOvertimeHoursWindowServiceClient
  {
    private const string service = "DayTimeOvertimeHoursWindowService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public DayTimeOvertimeHoursWindowServiceClient(
      string username,
      string password,
      string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ImportDayTimeOvertimeHoursWindowsResponse ImportDayTimeOvertimeHoursWindows(
      ImportDayTimeOvertimeHoursWindows arg)
    {
      return Client.Post<ImportDayTimeOvertimeHoursWindows, ImportDayTimeOvertimeHoursWindowsResponse>(this.username, this.password, this.baseuri, "DayTimeOvertimeHoursWindowService", arg);
    }

    public Task<ImportDayTimeOvertimeHoursWindowsResponse> ImportDayTimeOvertimeHoursWindowsAsync(
      ImportDayTimeOvertimeHoursWindows arg)
    {
      return Client.PostAsync<ImportDayTimeOvertimeHoursWindows, ImportDayTimeOvertimeHoursWindowsResponse>(this.username, this.password, this.baseuri, "DayTimeOvertimeHoursWindowService", arg);
    }

    public ExportDayTimeOvertimeHoursWindowsListResponse ExportDayTimeOvertimeHoursWindowsList(
      ExportDayTimeOvertimeHoursWindowsList arg)
    {
      return Client.Post<ExportDayTimeOvertimeHoursWindowsList, ExportDayTimeOvertimeHoursWindowsListResponse>(this.username, this.password, this.baseuri, "DayTimeOvertimeHoursWindowService", arg);
    }

    public Task<ExportDayTimeOvertimeHoursWindowsListResponse> ExportDayTimeOvertimeHoursWindowsListAsync(
      ExportDayTimeOvertimeHoursWindowsList arg)
    {
      return Client.PostAsync<ExportDayTimeOvertimeHoursWindowsList, ExportDayTimeOvertimeHoursWindowsListResponse>(this.username, this.password, this.baseuri, "DayTimeOvertimeHoursWindowService", arg);
    }

    public ExportDayTimeOvertimeHoursWindowsResponse ExportDayTimeOvertimeHoursWindows(
      ExportDayTimeOvertimeHoursWindows arg)
    {
      return Client.Post<ExportDayTimeOvertimeHoursWindows, ExportDayTimeOvertimeHoursWindowsResponse>(this.username, this.password, this.baseuri, "DayTimeOvertimeHoursWindowService", arg);
    }

    public Task<ExportDayTimeOvertimeHoursWindowsResponse> ExportDayTimeOvertimeHoursWindowsAsync(
      ExportDayTimeOvertimeHoursWindows arg)
    {
      return Client.PostAsync<ExportDayTimeOvertimeHoursWindows, ExportDayTimeOvertimeHoursWindowsResponse>(this.username, this.password, this.baseuri, "DayTimeOvertimeHoursWindowService", arg);
    }
  }
}
