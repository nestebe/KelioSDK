
//.CalculationRuleWindowServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class CalculationRuleWindowServiceClient
  {
    private const string service = "CalculationRuleWindowService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public CalculationRuleWindowServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ExportCalculationRuleWindowsResponse ExportCalculationRuleWindows(
      ExportCalculationRuleWindows arg)
    {
      return Client.Post<ExportCalculationRuleWindows, ExportCalculationRuleWindowsResponse>(this.username, this.password, this.baseuri, "CalculationRuleWindowService", arg, this.timeoutSeconds);
    }

    public Task<ExportCalculationRuleWindowsResponse> ExportCalculationRuleWindowsAsync(
      ExportCalculationRuleWindows arg)
    {
      return Client.PostAsync<ExportCalculationRuleWindows, ExportCalculationRuleWindowsResponse>(this.username, this.password, this.baseuri, "CalculationRuleWindowService", arg, this.timeoutSeconds);
    }

    public ExportCalculationRuleWindowsListResponse ExportCalculationRuleWindowsList(
      ExportCalculationRuleWindowsList arg)
    {
      return Client.Post<ExportCalculationRuleWindowsList, ExportCalculationRuleWindowsListResponse>(this.username, this.password, this.baseuri, "CalculationRuleWindowService", arg, this.timeoutSeconds);
    }

    public Task<ExportCalculationRuleWindowsListResponse> ExportCalculationRuleWindowsListAsync(
      ExportCalculationRuleWindowsList arg)
    {
      return Client.PostAsync<ExportCalculationRuleWindowsList, ExportCalculationRuleWindowsListResponse>(this.username, this.password, this.baseuri, "CalculationRuleWindowService", arg, this.timeoutSeconds);
    }

    public ImportCalculationRuleWindowsResponse ImportCalculationRuleWindows(
      ImportCalculationRuleWindows arg)
    {
      return Client.Post<ImportCalculationRuleWindows, ImportCalculationRuleWindowsResponse>(this.username, this.password, this.baseuri, "CalculationRuleWindowService", arg, this.timeoutSeconds);
    }

    public Task<ImportCalculationRuleWindowsResponse> ImportCalculationRuleWindowsAsync(
      ImportCalculationRuleWindows arg)
    {
      return Client.PostAsync<ImportCalculationRuleWindows, ImportCalculationRuleWindowsResponse>(this.username, this.password, this.baseuri, "CalculationRuleWindowService", arg, this.timeoutSeconds);
    }
  }
}
