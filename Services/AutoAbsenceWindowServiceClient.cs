
//.AutoAbsenceWindowServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class AutoAbsenceWindowServiceClient
  {
    private const string service = "AutoAbsenceWindowService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public AutoAbsenceWindowServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ImportAutoAbsenceWindowsResponse ImportAutoAbsenceWindows(
      ImportAutoAbsenceWindows arg)
    {
      return Client.Post<ImportAutoAbsenceWindows, ImportAutoAbsenceWindowsResponse>(this.username, this.password, this.baseuri, "AutoAbsenceWindowService", arg);
    }

    public Task<ImportAutoAbsenceWindowsResponse> ImportAutoAbsenceWindowsAsync(
      ImportAutoAbsenceWindows arg)
    {
      return Client.PostAsync<ImportAutoAbsenceWindows, ImportAutoAbsenceWindowsResponse>(this.username, this.password, this.baseuri, "AutoAbsenceWindowService", arg);
    }

    public ExportAutoAbsenceWindowsListResponse ExportAutoAbsenceWindowsList(
      ExportAutoAbsenceWindowsList arg)
    {
      return Client.Post<ExportAutoAbsenceWindowsList, ExportAutoAbsenceWindowsListResponse>(this.username, this.password, this.baseuri, "AutoAbsenceWindowService", arg);
    }

    public Task<ExportAutoAbsenceWindowsListResponse> ExportAutoAbsenceWindowsListAsync(
      ExportAutoAbsenceWindowsList arg)
    {
      return Client.PostAsync<ExportAutoAbsenceWindowsList, ExportAutoAbsenceWindowsListResponse>(this.username, this.password, this.baseuri, "AutoAbsenceWindowService", arg);
    }

    public ExportAutoAbsenceWindowsResponse ExportAutoAbsenceWindows(
      ExportAutoAbsenceWindows arg)
    {
      return Client.Post<ExportAutoAbsenceWindows, ExportAutoAbsenceWindowsResponse>(this.username, this.password, this.baseuri, "AutoAbsenceWindowService", arg);
    }

    public Task<ExportAutoAbsenceWindowsResponse> ExportAutoAbsenceWindowsAsync(
      ExportAutoAbsenceWindows arg)
    {
      return Client.PostAsync<ExportAutoAbsenceWindows, ExportAutoAbsenceWindowsResponse>(this.username, this.password, this.baseuri, "AutoAbsenceWindowService", arg);
    }
  }
}
