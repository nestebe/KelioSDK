
//.PenaltyWindowServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class PenaltyWindowServiceClient
  {
    private const string service = "PenaltyWindowService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public PenaltyWindowServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ImportPenaltyWindowsResponse ImportPenaltyWindows(
      ImportPenaltyWindows arg)
    {
      return Client.Post<ImportPenaltyWindows, ImportPenaltyWindowsResponse>(this.username, this.password, this.baseuri, "PenaltyWindowService", arg, this.timeoutSeconds);
    }

    public Task<ImportPenaltyWindowsResponse> ImportPenaltyWindowsAsync(
      ImportPenaltyWindows arg)
    {
      return Client.PostAsync<ImportPenaltyWindows, ImportPenaltyWindowsResponse>(this.username, this.password, this.baseuri, "PenaltyWindowService", arg, this.timeoutSeconds);
    }

    public ExportPenaltyWindowsListResponse ExportPenaltyWindowsList(
      ExportPenaltyWindowsList arg)
    {
      return Client.Post<ExportPenaltyWindowsList, ExportPenaltyWindowsListResponse>(this.username, this.password, this.baseuri, "PenaltyWindowService", arg, this.timeoutSeconds);
    }

    public Task<ExportPenaltyWindowsListResponse> ExportPenaltyWindowsListAsync(
      ExportPenaltyWindowsList arg)
    {
      return Client.PostAsync<ExportPenaltyWindowsList, ExportPenaltyWindowsListResponse>(this.username, this.password, this.baseuri, "PenaltyWindowService", arg, this.timeoutSeconds);
    }

    public ExportPenaltyWindowsResponse ExportPenaltyWindows(
      ExportPenaltyWindows arg)
    {
      return Client.Post<ExportPenaltyWindows, ExportPenaltyWindowsResponse>(this.username, this.password, this.baseuri, "PenaltyWindowService", arg, this.timeoutSeconds);
    }

    public Task<ExportPenaltyWindowsResponse> ExportPenaltyWindowsAsync(
      ExportPenaltyWindows arg)
    {
      return Client.PostAsync<ExportPenaltyWindows, ExportPenaltyWindowsResponse>(this.username, this.password, this.baseuri, "PenaltyWindowService", arg, this.timeoutSeconds);
    }
  }
}
