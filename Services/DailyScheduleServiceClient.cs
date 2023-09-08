
//.DailyScheduleServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class DailyScheduleServiceClient
  {
    private const string service = "DailyScheduleService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public DailyScheduleServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ImportDailySchedulesResponse ImportDailySchedules(
      ImportDailySchedules arg)
    {
      return Client.Post<ImportDailySchedules, ImportDailySchedulesResponse>(this.username, this.password, this.baseuri, "DailyScheduleService", arg);
    }

    public Task<ImportDailySchedulesResponse> ImportDailySchedulesAsync(
      ImportDailySchedules arg)
    {
      return Client.PostAsync<ImportDailySchedules, ImportDailySchedulesResponse>(this.username, this.password, this.baseuri, "DailyScheduleService", arg);
    }

    public ExportDailySchedulesResponse ExportDailySchedules(
      ExportDailySchedules arg)
    {
      return Client.Post<ExportDailySchedules, ExportDailySchedulesResponse>(this.username, this.password, this.baseuri, "DailyScheduleService", arg);
    }

    public Task<ExportDailySchedulesResponse> ExportDailySchedulesAsync(
      ExportDailySchedules arg)
    {
      return Client.PostAsync<ExportDailySchedules, ExportDailySchedulesResponse>(this.username, this.password, this.baseuri, "DailyScheduleService", arg);
    }
  }
}
