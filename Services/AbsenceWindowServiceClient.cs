
//.AbsenceWindowServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class AbsenceWindowServiceClient
  {
    private const string service = "AbsenceWindowService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public AbsenceWindowServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportAbsenceWindowsResponse ExportAbsenceWindows(
      ExportAbsenceWindows arg)
    {
      return Client.Post<ExportAbsenceWindows, ExportAbsenceWindowsResponse>(this.username, this.password, this.baseuri, "AbsenceWindowService", arg);
    }

    public Task<ExportAbsenceWindowsResponse> ExportAbsenceWindowsAsync(
      ExportAbsenceWindows arg)
    {
      return Client.PostAsync<ExportAbsenceWindows, ExportAbsenceWindowsResponse>(this.username, this.password, this.baseuri, "AbsenceWindowService", arg);
    }

    public ExportAbsenceWindowsListResponse ExportAbsenceWindowsList(
      ExportAbsenceWindowsList arg)
    {
      return Client.Post<ExportAbsenceWindowsList, ExportAbsenceWindowsListResponse>(this.username, this.password, this.baseuri, "AbsenceWindowService", arg);
    }

    public Task<ExportAbsenceWindowsListResponse> ExportAbsenceWindowsListAsync(
      ExportAbsenceWindowsList arg)
    {
      return Client.PostAsync<ExportAbsenceWindowsList, ExportAbsenceWindowsListResponse>(this.username, this.password, this.baseuri, "AbsenceWindowService", arg);
    }

    public ImportAbsenceWindowsResponse ImportAbsenceWindows(
      ImportAbsenceWindows arg)
    {
      return Client.Post<ImportAbsenceWindows, ImportAbsenceWindowsResponse>(this.username, this.password, this.baseuri, "AbsenceWindowService", arg);
    }

    public Task<ImportAbsenceWindowsResponse> ImportAbsenceWindowsAsync(
      ImportAbsenceWindows arg)
    {
      return Client.PostAsync<ImportAbsenceWindows, ImportAbsenceWindowsResponse>(this.username, this.password, this.baseuri, "AbsenceWindowService", arg);
    }
  }
}
