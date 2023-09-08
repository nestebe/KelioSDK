
//.AnnualizedHourScheduleServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class AnnualizedHourScheduleServiceClient
  {
    private const string service = "AnnualizedHourScheduleService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public AnnualizedHourScheduleServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ImportAnnualizedHourSchedulesResponse ImportAnnualizedHourSchedules(
      ImportAnnualizedHourSchedules arg)
    {
      return Client.Post<ImportAnnualizedHourSchedules, ImportAnnualizedHourSchedulesResponse>(this.username, this.password, this.baseuri, "AnnualizedHourScheduleService", arg);
    }

    public Task<ImportAnnualizedHourSchedulesResponse> ImportAnnualizedHourSchedulesAsync(
      ImportAnnualizedHourSchedules arg)
    {
      return Client.PostAsync<ImportAnnualizedHourSchedules, ImportAnnualizedHourSchedulesResponse>(this.username, this.password, this.baseuri, "AnnualizedHourScheduleService", arg);
    }

    public ExportAnnualizedHourSchedulesResponse ExportAnnualizedHourSchedules(
      ExportAnnualizedHourSchedules arg)
    {
      return Client.Post<ExportAnnualizedHourSchedules, ExportAnnualizedHourSchedulesResponse>(this.username, this.password, this.baseuri, "AnnualizedHourScheduleService", arg);
    }

    public Task<ExportAnnualizedHourSchedulesResponse> ExportAnnualizedHourSchedulesAsync(
      ExportAnnualizedHourSchedules arg)
    {
      return Client.PostAsync<ExportAnnualizedHourSchedules, ExportAnnualizedHourSchedulesResponse>(this.username, this.password, this.baseuri, "AnnualizedHourScheduleService", arg);
    }
  }
}
