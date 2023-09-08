
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
    private readonly string baseuri;

    public PenaltyWindowServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ImportPenaltyWindowsResponse ImportPenaltyWindows(
      ImportPenaltyWindows arg)
    {
      return Client.Post<ImportPenaltyWindows, ImportPenaltyWindowsResponse>(this.username, this.password, this.baseuri, "PenaltyWindowService", arg);
    }

    public Task<ImportPenaltyWindowsResponse> ImportPenaltyWindowsAsync(
      ImportPenaltyWindows arg)
    {
      return Client.PostAsync<ImportPenaltyWindows, ImportPenaltyWindowsResponse>(this.username, this.password, this.baseuri, "PenaltyWindowService", arg);
    }

    public ExportPenaltyWindowsListResponse ExportPenaltyWindowsList(
      ExportPenaltyWindowsList arg)
    {
      return Client.Post<ExportPenaltyWindowsList, ExportPenaltyWindowsListResponse>(this.username, this.password, this.baseuri, "PenaltyWindowService", arg);
    }

    public Task<ExportPenaltyWindowsListResponse> ExportPenaltyWindowsListAsync(
      ExportPenaltyWindowsList arg)
    {
      return Client.PostAsync<ExportPenaltyWindowsList, ExportPenaltyWindowsListResponse>(this.username, this.password, this.baseuri, "PenaltyWindowService", arg);
    }

    public ExportPenaltyWindowsResponse ExportPenaltyWindows(
      ExportPenaltyWindows arg)
    {
      return Client.Post<ExportPenaltyWindows, ExportPenaltyWindowsResponse>(this.username, this.password, this.baseuri, "PenaltyWindowService", arg);
    }

    public Task<ExportPenaltyWindowsResponse> ExportPenaltyWindowsAsync(
      ExportPenaltyWindows arg)
    {
      return Client.PostAsync<ExportPenaltyWindows, ExportPenaltyWindowsResponse>(this.username, this.password, this.baseuri, "PenaltyWindowService", arg);
    }
  }
}
