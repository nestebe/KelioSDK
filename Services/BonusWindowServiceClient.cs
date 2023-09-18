
//.BonusWindowServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class BonusWindowServiceClient
  {
    private const string service = "BonusWindowService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public BonusWindowServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ImportBonusWindowsResponse ImportBonusWindows(
      ImportBonusWindows arg)
    {
      return Client.Post<ImportBonusWindows, ImportBonusWindowsResponse>(this.username, this.password, this.baseuri, "BonusWindowService", arg, this.timeoutSeconds);
    }

    public Task<ImportBonusWindowsResponse> ImportBonusWindowsAsync(
      ImportBonusWindows arg)
    {
      return Client.PostAsync<ImportBonusWindows, ImportBonusWindowsResponse>(this.username, this.password, this.baseuri, "BonusWindowService", arg, this.timeoutSeconds);
    }

    public ExportBonusWindowsListResponse ExportBonusWindowsList(
      ExportBonusWindowsList arg)
    {
      return Client.Post<ExportBonusWindowsList, ExportBonusWindowsListResponse>(this.username, this.password, this.baseuri, "BonusWindowService", arg, this.timeoutSeconds);
    }

    public Task<ExportBonusWindowsListResponse> ExportBonusWindowsListAsync(
      ExportBonusWindowsList arg)
    {
      return Client.PostAsync<ExportBonusWindowsList, ExportBonusWindowsListResponse>(this.username, this.password, this.baseuri, "BonusWindowService", arg, this.timeoutSeconds);
    }

    public ExportBonusWindowsResponse ExportBonusWindows(
      ExportBonusWindows arg)
    {
      return Client.Post<ExportBonusWindows, ExportBonusWindowsResponse>(this.username, this.password, this.baseuri, "BonusWindowService", arg, this.timeoutSeconds);
    }

    public Task<ExportBonusWindowsResponse> ExportBonusWindowsAsync(
      ExportBonusWindows arg)
    {
      return Client.PostAsync<ExportBonusWindows, ExportBonusWindowsResponse>(this.username, this.password, this.baseuri, "BonusWindowService", arg, this.timeoutSeconds);
    }
  }
}
