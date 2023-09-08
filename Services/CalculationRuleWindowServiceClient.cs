
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
    private readonly string baseuri;

    public CalculationRuleWindowServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportCalculationRuleWindowsResponse ExportCalculationRuleWindows(
      ExportCalculationRuleWindows arg)
    {
      return Client.Post<ExportCalculationRuleWindows, ExportCalculationRuleWindowsResponse>(this.username, this.password, this.baseuri, "CalculationRuleWindowService", arg);
    }

    public Task<ExportCalculationRuleWindowsResponse> ExportCalculationRuleWindowsAsync(
      ExportCalculationRuleWindows arg)
    {
      return Client.PostAsync<ExportCalculationRuleWindows, ExportCalculationRuleWindowsResponse>(this.username, this.password, this.baseuri, "CalculationRuleWindowService", arg);
    }

    public ExportCalculationRuleWindowsListResponse ExportCalculationRuleWindowsList(
      ExportCalculationRuleWindowsList arg)
    {
      return Client.Post<ExportCalculationRuleWindowsList, ExportCalculationRuleWindowsListResponse>(this.username, this.password, this.baseuri, "CalculationRuleWindowService", arg);
    }

    public Task<ExportCalculationRuleWindowsListResponse> ExportCalculationRuleWindowsListAsync(
      ExportCalculationRuleWindowsList arg)
    {
      return Client.PostAsync<ExportCalculationRuleWindowsList, ExportCalculationRuleWindowsListResponse>(this.username, this.password, this.baseuri, "CalculationRuleWindowService", arg);
    }

    public ImportCalculationRuleWindowsResponse ImportCalculationRuleWindows(
      ImportCalculationRuleWindows arg)
    {
      return Client.Post<ImportCalculationRuleWindows, ImportCalculationRuleWindowsResponse>(this.username, this.password, this.baseuri, "CalculationRuleWindowService", arg);
    }

    public Task<ImportCalculationRuleWindowsResponse> ImportCalculationRuleWindowsAsync(
      ImportCalculationRuleWindows arg)
    {
      return Client.PostAsync<ImportCalculationRuleWindows, ImportCalculationRuleWindowsResponse>(this.username, this.password, this.baseuri, "CalculationRuleWindowService", arg);
    }
  }
}
