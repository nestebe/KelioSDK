
//.MaxTimeWindowServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class MaxTimeWindowServiceClient
  {
    private const string service = "MaxTimeWindowService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public MaxTimeWindowServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ImportMaxTimeWindowsResponse ImportMaxTimeWindows(
      ImportMaxTimeWindows arg)
    {
      return Client.Post<ImportMaxTimeWindows, ImportMaxTimeWindowsResponse>(this.username, this.password, this.baseuri, "MaxTimeWindowService", arg);
    }

    public Task<ImportMaxTimeWindowsResponse> ImportMaxTimeWindowsAsync(
      ImportMaxTimeWindows arg)
    {
      return Client.PostAsync<ImportMaxTimeWindows, ImportMaxTimeWindowsResponse>(this.username, this.password, this.baseuri, "MaxTimeWindowService", arg);
    }

    public ExportMaxTimeWindowsListResponse ExportMaxTimeWindowsList(
      ExportMaxTimeWindowsList arg)
    {
      return Client.Post<ExportMaxTimeWindowsList, ExportMaxTimeWindowsListResponse>(this.username, this.password, this.baseuri, "MaxTimeWindowService", arg);
    }

    public Task<ExportMaxTimeWindowsListResponse> ExportMaxTimeWindowsListAsync(
      ExportMaxTimeWindowsList arg)
    {
      return Client.PostAsync<ExportMaxTimeWindowsList, ExportMaxTimeWindowsListResponse>(this.username, this.password, this.baseuri, "MaxTimeWindowService", arg);
    }

    public ExportMaxTimeWindowsResponse ExportMaxTimeWindows(
      ExportMaxTimeWindows arg)
    {
      return Client.Post<ExportMaxTimeWindows, ExportMaxTimeWindowsResponse>(this.username, this.password, this.baseuri, "MaxTimeWindowService", arg);
    }

    public Task<ExportMaxTimeWindowsResponse> ExportMaxTimeWindowsAsync(
      ExportMaxTimeWindows arg)
    {
      return Client.PostAsync<ExportMaxTimeWindows, ExportMaxTimeWindowsResponse>(this.username, this.password, this.baseuri, "MaxTimeWindowService", arg);
    }
  }
}
