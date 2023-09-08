
//.BreakWithConditionalDurationWindowServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class BreakWithConditionalDurationWindowServiceClient
  {
    private const string service = "BreakWithConditionalDurationWindowService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public BreakWithConditionalDurationWindowServiceClient(
      string username,
      string password,
      string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportBreakWithConditionalDurationWindowsResponse ExportBreakWithConditionalDurationWindows(
      ExportBreakWithConditionalDurationWindows arg)
    {
      return Client.Post<ExportBreakWithConditionalDurationWindows, ExportBreakWithConditionalDurationWindowsResponse>(this.username, this.password, this.baseuri, "BreakWithConditionalDurationWindowService", arg);
    }

    public Task<ExportBreakWithConditionalDurationWindowsResponse> ExportBreakWithConditionalDurationWindowsAsync(
      ExportBreakWithConditionalDurationWindows arg)
    {
      return Client.PostAsync<ExportBreakWithConditionalDurationWindows, ExportBreakWithConditionalDurationWindowsResponse>(this.username, this.password, this.baseuri, "BreakWithConditionalDurationWindowService", arg);
    }

    public ExportBreakWithConditionalDurationWindowsListResponse ExportBreakWithConditionalDurationWindowsList(
      ExportBreakWithConditionalDurationWindowsList arg)
    {
      return Client.Post<ExportBreakWithConditionalDurationWindowsList, ExportBreakWithConditionalDurationWindowsListResponse>(this.username, this.password, this.baseuri, "BreakWithConditionalDurationWindowService", arg);
    }

    public Task<ExportBreakWithConditionalDurationWindowsListResponse> ExportBreakWithConditionalDurationWindowsListAsync(
      ExportBreakWithConditionalDurationWindowsList arg)
    {
      return Client.PostAsync<ExportBreakWithConditionalDurationWindowsList, ExportBreakWithConditionalDurationWindowsListResponse>(this.username, this.password, this.baseuri, "BreakWithConditionalDurationWindowService", arg);
    }

    public ImportBreakWithConditionalDurationWindowsResponse ImportBreakWithConditionalDurationWindows(
      ImportBreakWithConditionalDurationWindows arg)
    {
      return Client.Post<ImportBreakWithConditionalDurationWindows, ImportBreakWithConditionalDurationWindowsResponse>(this.username, this.password, this.baseuri, "BreakWithConditionalDurationWindowService", arg);
    }

    public Task<ImportBreakWithConditionalDurationWindowsResponse> ImportBreakWithConditionalDurationWindowsAsync(
      ImportBreakWithConditionalDurationWindows arg)
    {
      return Client.PostAsync<ImportBreakWithConditionalDurationWindows, ImportBreakWithConditionalDurationWindowsResponse>(this.username, this.password, this.baseuri, "BreakWithConditionalDurationWindowService", arg);
    }
  }
}
