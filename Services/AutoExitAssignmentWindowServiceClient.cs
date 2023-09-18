
//.AutoExitAssignmentWindowServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class AutoExitAssignmentWindowServiceClient
  {
    private const string service = "AutoExitAssignmentWindowService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public AutoExitAssignmentWindowServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ExportAutoExitAssignmentWindowsResponse ExportAutoExitAssignmentWindows(
      ExportAutoExitAssignmentWindows arg)
    {
      return Client.Post<ExportAutoExitAssignmentWindows, ExportAutoExitAssignmentWindowsResponse>(this.username, this.password, this.baseuri, "AutoExitAssignmentWindowService", arg, this.timeoutSeconds);
    }

    public Task<ExportAutoExitAssignmentWindowsResponse> ExportAutoExitAssignmentWindowsAsync(
      ExportAutoExitAssignmentWindows arg)
    {
      return Client.PostAsync<ExportAutoExitAssignmentWindows, ExportAutoExitAssignmentWindowsResponse>(this.username, this.password, this.baseuri, "AutoExitAssignmentWindowService", arg, this.timeoutSeconds);
    }

    public ExportAutoExitAssignmentWindowsListResponse ExportAutoExitAssignmentWindowsList(
      ExportAutoExitAssignmentWindowsList arg)
    {
      return Client.Post<ExportAutoExitAssignmentWindowsList, ExportAutoExitAssignmentWindowsListResponse>(this.username, this.password, this.baseuri, "AutoExitAssignmentWindowService", arg, this.timeoutSeconds);
    }

    public Task<ExportAutoExitAssignmentWindowsListResponse> ExportAutoExitAssignmentWindowsListAsync(
      ExportAutoExitAssignmentWindowsList arg)
    {
      return Client.PostAsync<ExportAutoExitAssignmentWindowsList, ExportAutoExitAssignmentWindowsListResponse>(this.username, this.password, this.baseuri, "AutoExitAssignmentWindowService", arg, this.timeoutSeconds);
    }

    public ImportAutoExitAssignmentWindowsResponse ImportAutoExitAssignmentWindows(
      ImportAutoExitAssignmentWindows arg)
    {
      return Client.Post<ImportAutoExitAssignmentWindows, ImportAutoExitAssignmentWindowsResponse>(this.username, this.password, this.baseuri, "AutoExitAssignmentWindowService", arg, this.timeoutSeconds);
    }

    public Task<ImportAutoExitAssignmentWindowsResponse> ImportAutoExitAssignmentWindowsAsync(
      ImportAutoExitAssignmentWindows arg)
    {
      return Client.PostAsync<ImportAutoExitAssignmentWindows, ImportAutoExitAssignmentWindowsResponse>(this.username, this.password, this.baseuri, "AutoExitAssignmentWindowService", arg, this.timeoutSeconds);
    }
  }
}
