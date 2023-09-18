
//.AnomalyServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class AnomalyServiceClient
  {
    private const string service = "AnomalyService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public AnomalyServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ExportAnomaliesResponse ExportAnomalies(ExportAnomalies arg)
    {
      return Client.Post<ExportAnomalies, ExportAnomaliesResponse>(this.username, this.password, this.baseuri, "AnomalyService", arg, this.timeoutSeconds);
    }

    public Task<ExportAnomaliesResponse> ExportAnomaliesAsync(
      ExportAnomalies arg)
    {
      return Client.PostAsync<ExportAnomalies, ExportAnomaliesResponse>(this.username, this.password, this.baseuri, "AnomalyService", arg, this.timeoutSeconds);
    }

    public ExportAnomaliesListResponse ExportAnomaliesList(
      ExportAnomaliesList arg)
    {
      return Client.Post<ExportAnomaliesList, ExportAnomaliesListResponse>(this.username, this.password, this.baseuri, "AnomalyService", arg, this.timeoutSeconds);
    }

    public Task<ExportAnomaliesListResponse> ExportAnomaliesListAsync(
      ExportAnomaliesList arg)
    {
      return Client.PostAsync<ExportAnomaliesList, ExportAnomaliesListResponse>(this.username, this.password, this.baseuri, "AnomalyService", arg, this.timeoutSeconds);
    }
  }
}
