
//.RoundingOnClockingWindowServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class RoundingOnClockingWindowServiceClient
  {
    private const string service = "RoundingOnClockingWindowService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public RoundingOnClockingWindowServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportRoundingOnClockingWindowsResponse ExportRoundingOnClockingWindows(
      ExportRoundingOnClockingWindows arg)
    {
      return Client.Post<ExportRoundingOnClockingWindows, ExportRoundingOnClockingWindowsResponse>(this.username, this.password, this.baseuri, "RoundingOnClockingWindowService", arg);
    }

    public Task<ExportRoundingOnClockingWindowsResponse> ExportRoundingOnClockingWindowsAsync(
      ExportRoundingOnClockingWindows arg)
    {
      return Client.PostAsync<ExportRoundingOnClockingWindows, ExportRoundingOnClockingWindowsResponse>(this.username, this.password, this.baseuri, "RoundingOnClockingWindowService", arg);
    }

    public ExportRoundingOnClockingWindowsListResponse ExportRoundingOnClockingWindowsList(
      ExportRoundingOnClockingWindowsList arg)
    {
      return Client.Post<ExportRoundingOnClockingWindowsList, ExportRoundingOnClockingWindowsListResponse>(this.username, this.password, this.baseuri, "RoundingOnClockingWindowService", arg);
    }

    public Task<ExportRoundingOnClockingWindowsListResponse> ExportRoundingOnClockingWindowsListAsync(
      ExportRoundingOnClockingWindowsList arg)
    {
      return Client.PostAsync<ExportRoundingOnClockingWindowsList, ExportRoundingOnClockingWindowsListResponse>(this.username, this.password, this.baseuri, "RoundingOnClockingWindowService", arg);
    }

    public ImportRoundingOnClockingWindowsResponse ImportRoundingOnClockingWindows(
      ImportRoundingOnClockingWindows arg)
    {
      return Client.Post<ImportRoundingOnClockingWindows, ImportRoundingOnClockingWindowsResponse>(this.username, this.password, this.baseuri, "RoundingOnClockingWindowService", arg);
    }

    public Task<ImportRoundingOnClockingWindowsResponse> ImportRoundingOnClockingWindowsAsync(
      ImportRoundingOnClockingWindows arg)
    {
      return Client.PostAsync<ImportRoundingOnClockingWindows, ImportRoundingOnClockingWindowsResponse>(this.username, this.password, this.baseuri, "RoundingOnClockingWindowService", arg);
    }
  }
}
