
//.ClockingDeclarationServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class ClockingDeclarationServiceClient
  {
    private const string service = "ClockingDeclarationService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public ClockingDeclarationServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportClockingDeclarationsResponse ExportClockingDeclarations(
      ExportClockingDeclarations arg)
    {
      return Client.Post<ExportClockingDeclarations, ExportClockingDeclarationsResponse>(this.username, this.password, this.baseuri, "ClockingDeclarationService", arg);
    }

    public Task<ExportClockingDeclarationsResponse> ExportClockingDeclarationsAsync(
      ExportClockingDeclarations arg)
    {
      return Client.PostAsync<ExportClockingDeclarations, ExportClockingDeclarationsResponse>(this.username, this.password, this.baseuri, "ClockingDeclarationService", arg);
    }
  }
}
