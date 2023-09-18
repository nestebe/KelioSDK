
//.PresenceNotificationTimeServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class PresenceNotificationTimeServiceClient
  {
    private const string service = "PresenceNotificationTimeService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public PresenceNotificationTimeServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public DeletePresenceNotificationTimeResponse DeletePresenceNotificationTime(
      DeletePresenceNotificationTime arg)
    {
      return Client.Post<DeletePresenceNotificationTime, DeletePresenceNotificationTimeResponse>(this.username, this.password, this.baseuri, "PresenceNotificationTimeService", arg, this.timeoutSeconds);
    }

    public Task<DeletePresenceNotificationTimeResponse> DeletePresenceNotificationTimeAsync(
      DeletePresenceNotificationTime arg)
    {
      return Client.PostAsync<DeletePresenceNotificationTime, DeletePresenceNotificationTimeResponse>(this.username, this.password, this.baseuri, "PresenceNotificationTimeService", arg, this.timeoutSeconds);
    }

    public ImportPresenceNotificationTimeResponse ImportPresenceNotificationTime(
      ImportPresenceNotificationTime arg)
    {
      return Client.Post<ImportPresenceNotificationTime, ImportPresenceNotificationTimeResponse>(this.username, this.password, this.baseuri, "PresenceNotificationTimeService", arg, this.timeoutSeconds);
    }

    public Task<ImportPresenceNotificationTimeResponse> ImportPresenceNotificationTimeAsync(
      ImportPresenceNotificationTime arg)
    {
      return Client.PostAsync<ImportPresenceNotificationTime, ImportPresenceNotificationTimeResponse>(this.username, this.password, this.baseuri, "PresenceNotificationTimeService", arg, this.timeoutSeconds);
    }

    public ExportPresenceNotificationTimeResponse ExportPresenceNotificationTime(
      ExportPresenceNotificationTime arg)
    {
      return Client.Post<ExportPresenceNotificationTime, ExportPresenceNotificationTimeResponse>(this.username, this.password, this.baseuri, "PresenceNotificationTimeService", arg, this.timeoutSeconds);
    }

    public Task<ExportPresenceNotificationTimeResponse> ExportPresenceNotificationTimeAsync(
      ExportPresenceNotificationTime arg)
    {
      return Client.PostAsync<ExportPresenceNotificationTime, ExportPresenceNotificationTimeResponse>(this.username, this.password, this.baseuri, "PresenceNotificationTimeService", arg, this.timeoutSeconds);
    }
  }
}
