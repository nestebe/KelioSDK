
//.CoreWindowServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class CoreWindowServiceClient
  {
    private const string service = "CoreWindowService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public CoreWindowServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ImportCoreWindowsResponse ImportCoreWindows(
      ImportCoreWindows arg)
    {
      return Client.Post<ImportCoreWindows, ImportCoreWindowsResponse>(this.username, this.password, this.baseuri, "CoreWindowService", arg);
    }

    public Task<ImportCoreWindowsResponse> ImportCoreWindowsAsync(
      ImportCoreWindows arg)
    {
      return Client.PostAsync<ImportCoreWindows, ImportCoreWindowsResponse>(this.username, this.password, this.baseuri, "CoreWindowService", arg);
    }

    public ExportCoreWindowsListResponse ExportCoreWindowsList(
      ExportCoreWindowsList arg)
    {
      return Client.Post<ExportCoreWindowsList, ExportCoreWindowsListResponse>(this.username, this.password, this.baseuri, "CoreWindowService", arg);
    }

    public Task<ExportCoreWindowsListResponse> ExportCoreWindowsListAsync(
      ExportCoreWindowsList arg)
    {
      return Client.PostAsync<ExportCoreWindowsList, ExportCoreWindowsListResponse>(this.username, this.password, this.baseuri, "CoreWindowService", arg);
    }

    public ExportCoreWindowsResponse ExportCoreWindows(
      ExportCoreWindows arg)
    {
      return Client.Post<ExportCoreWindows, ExportCoreWindowsResponse>(this.username, this.password, this.baseuri, "CoreWindowService", arg);
    }

    public Task<ExportCoreWindowsResponse> ExportCoreWindowsAsync(
      ExportCoreWindows arg)
    {
      return Client.PostAsync<ExportCoreWindows, ExportCoreWindowsResponse>(this.username, this.password, this.baseuri, "CoreWindowService", arg);
    }
  }
}
