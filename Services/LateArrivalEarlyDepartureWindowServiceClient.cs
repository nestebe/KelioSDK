
//.LateArrivalEarlyDepartureWindowServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class LateArrivalEarlyDepartureWindowServiceClient
  {
    private const string service = "LateArrivalEarlyDepartureWindowService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public LateArrivalEarlyDepartureWindowServiceClient(
      string username,
      string password,
      string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ExportLateArrivalEarlyDepartureWindowsResponse ExportLateArrivalEarlyDepartureWindows(
      ExportLateArrivalEarlyDepartureWindows arg)
    {
      return Client.Post<ExportLateArrivalEarlyDepartureWindows, ExportLateArrivalEarlyDepartureWindowsResponse>(this.username, this.password, this.baseuri, "LateArrivalEarlyDepartureWindowService", arg, this.timeoutSeconds);
    }

    public Task<ExportLateArrivalEarlyDepartureWindowsResponse> ExportLateArrivalEarlyDepartureWindowsAsync(
      ExportLateArrivalEarlyDepartureWindows arg)
    {
      return Client.PostAsync<ExportLateArrivalEarlyDepartureWindows, ExportLateArrivalEarlyDepartureWindowsResponse>(this.username, this.password, this.baseuri, "LateArrivalEarlyDepartureWindowService", arg, this.timeoutSeconds);
    }

    public ExportLateArrivalEarlyDepartureWindowsListResponse ExportLateArrivalEarlyDepartureWindowsList(
      ExportLateArrivalEarlyDepartureWindowsList arg)
    {
      return Client.Post<ExportLateArrivalEarlyDepartureWindowsList, ExportLateArrivalEarlyDepartureWindowsListResponse>(this.username, this.password, this.baseuri, "LateArrivalEarlyDepartureWindowService", arg, this.timeoutSeconds);
    }

    public Task<ExportLateArrivalEarlyDepartureWindowsListResponse> ExportLateArrivalEarlyDepartureWindowsListAsync(
      ExportLateArrivalEarlyDepartureWindowsList arg)
    {
      return Client.PostAsync<ExportLateArrivalEarlyDepartureWindowsList, ExportLateArrivalEarlyDepartureWindowsListResponse>(this.username, this.password, this.baseuri, "LateArrivalEarlyDepartureWindowService", arg, this.timeoutSeconds);
    }

    public ImportLateArrivalEarlyDepartureWindowsResponse ImportLateArrivalEarlyDepartureWindows(
      ImportLateArrivalEarlyDepartureWindows arg)
    {
      return Client.Post<ImportLateArrivalEarlyDepartureWindows, ImportLateArrivalEarlyDepartureWindowsResponse>(this.username, this.password, this.baseuri, "LateArrivalEarlyDepartureWindowService", arg, this.timeoutSeconds);
    }

    public Task<ImportLateArrivalEarlyDepartureWindowsResponse> ImportLateArrivalEarlyDepartureWindowsAsync(
      ImportLateArrivalEarlyDepartureWindows arg)
    {
      return Client.PostAsync<ImportLateArrivalEarlyDepartureWindows, ImportLateArrivalEarlyDepartureWindowsResponse>(this.username, this.password, this.baseuri, "LateArrivalEarlyDepartureWindowService", arg, this.timeoutSeconds);
    }
  }
}
