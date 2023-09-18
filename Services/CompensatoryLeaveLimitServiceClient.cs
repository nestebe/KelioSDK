
//.CompensatoryLeaveLimitServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class CompensatoryLeaveLimitServiceClient
  {
    private const string service = "CompensatoryLeaveLimitService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public CompensatoryLeaveLimitServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ImportCompensatoryLeaveLimitsResponse ImportCompensatoryLeaveLimits(
      ImportCompensatoryLeaveLimits arg)
    {
      return Client.Post<ImportCompensatoryLeaveLimits, ImportCompensatoryLeaveLimitsResponse>(this.username, this.password, this.baseuri, "CompensatoryLeaveLimitService", arg, this.timeoutSeconds);
    }

    public Task<ImportCompensatoryLeaveLimitsResponse> ImportCompensatoryLeaveLimitsAsync(
      ImportCompensatoryLeaveLimits arg)
    {
      return Client.PostAsync<ImportCompensatoryLeaveLimits, ImportCompensatoryLeaveLimitsResponse>(this.username, this.password, this.baseuri, "CompensatoryLeaveLimitService", arg, this.timeoutSeconds);
    }

    public ExportCompensatoryLeaveLimitsResponse ExportCompensatoryLeaveLimits(
      ExportCompensatoryLeaveLimits arg)
    {
      return Client.Post<ExportCompensatoryLeaveLimits, ExportCompensatoryLeaveLimitsResponse>(this.username, this.password, this.baseuri, "CompensatoryLeaveLimitService", arg, this.timeoutSeconds);
    }

    public Task<ExportCompensatoryLeaveLimitsResponse> ExportCompensatoryLeaveLimitsAsync(
      ExportCompensatoryLeaveLimits arg)
    {
      return Client.PostAsync<ExportCompensatoryLeaveLimits, ExportCompensatoryLeaveLimitsResponse>(this.username, this.password, this.baseuri, "CompensatoryLeaveLimitService", arg, this.timeoutSeconds);
    }
  }
}
