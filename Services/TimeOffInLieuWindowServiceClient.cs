
//.TimeOffInLieuWindowServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class TimeOffInLieuWindowServiceClient
  {
    private const string service = "TimeOffInLieuWindowService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public TimeOffInLieuWindowServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportTimeOffInLieuWindowsResponse ExportTimeOffInLieuWindows(
      ExportTimeOffInLieuWindows arg)
    {
      return Client.Post<ExportTimeOffInLieuWindows, ExportTimeOffInLieuWindowsResponse>(this.username, this.password, this.baseuri, "TimeOffInLieuWindowService", arg);
    }

    public Task<ExportTimeOffInLieuWindowsResponse> ExportTimeOffInLieuWindowsAsync(
      ExportTimeOffInLieuWindows arg)
    {
      return Client.PostAsync<ExportTimeOffInLieuWindows, ExportTimeOffInLieuWindowsResponse>(this.username, this.password, this.baseuri, "TimeOffInLieuWindowService", arg);
    }

    public ExportTimeOffInLieuWindowsListResponse ExportTimeOffInLieuWindowsList(
      ExportTimeOffInLieuWindowsList arg)
    {
      return Client.Post<ExportTimeOffInLieuWindowsList, ExportTimeOffInLieuWindowsListResponse>(this.username, this.password, this.baseuri, "TimeOffInLieuWindowService", arg);
    }

    public Task<ExportTimeOffInLieuWindowsListResponse> ExportTimeOffInLieuWindowsListAsync(
      ExportTimeOffInLieuWindowsList arg)
    {
      return Client.PostAsync<ExportTimeOffInLieuWindowsList, ExportTimeOffInLieuWindowsListResponse>(this.username, this.password, this.baseuri, "TimeOffInLieuWindowService", arg);
    }

    public ImportTimeOffInLieuWindowsResponse ImportTimeOffInLieuWindows(
      ImportTimeOffInLieuWindows arg)
    {
      return Client.Post<ImportTimeOffInLieuWindows, ImportTimeOffInLieuWindowsResponse>(this.username, this.password, this.baseuri, "TimeOffInLieuWindowService", arg);
    }

    public Task<ImportTimeOffInLieuWindowsResponse> ImportTimeOffInLieuWindowsAsync(
      ImportTimeOffInLieuWindows arg)
    {
      return Client.PostAsync<ImportTimeOffInLieuWindows, ImportTimeOffInLieuWindowsResponse>(this.username, this.password, this.baseuri, "TimeOffInLieuWindowService", arg);
    }
  }
}
