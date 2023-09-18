
//.AddDeductWindowServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class AddDeductWindowServiceClient
  {
    private const string service = "AddDeductWindowService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public AddDeductWindowServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ExportAddDeductWindowsResponse ExportAddDeductWindows(
      ExportAddDeductWindows arg)
    {
      return Client.Post<ExportAddDeductWindows, ExportAddDeductWindowsResponse>(this.username, this.password, this.baseuri, "AddDeductWindowService", arg, this.timeoutSeconds);
    }

    public Task<ExportAddDeductWindowsResponse> ExportAddDeductWindowsAsync(
      ExportAddDeductWindows arg)
    {
      return Client.PostAsync<ExportAddDeductWindows, ExportAddDeductWindowsResponse>(this.username, this.password, this.baseuri, "AddDeductWindowService", arg, this.timeoutSeconds);
    }

    public ExportAddDeductWindowsListResponse ExportAddDeductWindowsList(
      ExportAddDeductWindowsList arg)
    {
      return Client.Post<ExportAddDeductWindowsList, ExportAddDeductWindowsListResponse>(this.username, this.password, this.baseuri, "AddDeductWindowService", arg, this.timeoutSeconds);
    }

    public Task<ExportAddDeductWindowsListResponse> ExportAddDeductWindowsListAsync(
      ExportAddDeductWindowsList arg)
    {
      return Client.PostAsync<ExportAddDeductWindowsList, ExportAddDeductWindowsListResponse>(this.username, this.password, this.baseuri, "AddDeductWindowService", arg, this.timeoutSeconds);
    }

    public ImportAddDeductWindowsResponse ImportAddDeductWindows(
      ImportAddDeductWindows arg)
    {
      return Client.Post<ImportAddDeductWindows, ImportAddDeductWindowsResponse>(this.username, this.password, this.baseuri, "AddDeductWindowService", arg, this.timeoutSeconds);
    }

    public Task<ImportAddDeductWindowsResponse> ImportAddDeductWindowsAsync(
      ImportAddDeductWindows arg)
    {
      return Client.PostAsync<ImportAddDeductWindows, ImportAddDeductWindowsResponse>(this.username, this.password, this.baseuri, "AddDeductWindowService", arg, this.timeoutSeconds);
    }
  }
}
