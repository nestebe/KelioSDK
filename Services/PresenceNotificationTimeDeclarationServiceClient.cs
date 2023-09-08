
//.PresenceNotificationTimeDeclarationServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class PresenceNotificationTimeDeclarationServiceClient
  {
    private const string service = "PresenceNotificationTimeDeclarationService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public PresenceNotificationTimeDeclarationServiceClient(
      string username,
      string password,
      string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportPresenceNotificationTimeDeclarationResponse ExportPresenceNotificationTimeDeclaration(
      ExportPresenceNotificationTimeDeclaration arg)
    {
      return Client.Post<ExportPresenceNotificationTimeDeclaration, ExportPresenceNotificationTimeDeclarationResponse>(this.username, this.password, this.baseuri, "PresenceNotificationTimeDeclarationService", arg);
    }

    public Task<ExportPresenceNotificationTimeDeclarationResponse> ExportPresenceNotificationTimeDeclarationAsync(
      ExportPresenceNotificationTimeDeclaration arg)
    {
      return Client.PostAsync<ExportPresenceNotificationTimeDeclaration, ExportPresenceNotificationTimeDeclarationResponse>(this.username, this.password, this.baseuri, "PresenceNotificationTimeDeclarationService", arg);
    }
  }
}
