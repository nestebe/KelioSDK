
//.ScheduleServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class ScheduleServiceClient
  {
    private const string service = "ScheduleService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public ScheduleServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ImportSchedulesResponse ImportSchedules(ImportSchedules arg)
    {
      return Client.Post<ImportSchedules, ImportSchedulesResponse>(this.username, this.password, this.baseuri, "ScheduleService", arg, this.timeoutSeconds);
    }

    public Task<ImportSchedulesResponse> ImportSchedulesAsync(
      ImportSchedules arg)
    {
      return Client.PostAsync<ImportSchedules, ImportSchedulesResponse>(this.username, this.password, this.baseuri, "ScheduleService", arg, this.timeoutSeconds);
    }

    public ExportSchedulesResponse ExportSchedules(ExportSchedules arg)
    {
      return Client.Post<ExportSchedules, ExportSchedulesResponse>(this.username, this.password, this.baseuri, "ScheduleService", arg, this.timeoutSeconds);
    }

    public Task<ExportSchedulesResponse> ExportSchedulesAsync(
      ExportSchedules arg)
    {
      return Client.PostAsync<ExportSchedules, ExportSchedulesResponse>(this.username, this.password, this.baseuri, "ScheduleService", arg, this.timeoutSeconds);
    }
  }
}
