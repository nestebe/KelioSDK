
//.ExposurePeriodServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class ExposurePeriodServiceClient
  {
    private const string service = "ExposurePeriodService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public ExposurePeriodServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ImportExposurePeriodResponse ImportExposurePeriod(
      ImportExposurePeriod arg)
    {
      return Client.Post<ImportExposurePeriod, ImportExposurePeriodResponse>(this.username, this.password, this.baseuri, "ExposurePeriodService", arg, this.timeoutSeconds);
    }

    public Task<ImportExposurePeriodResponse> ImportExposurePeriodAsync(
      ImportExposurePeriod arg)
    {
      return Client.PostAsync<ImportExposurePeriod, ImportExposurePeriodResponse>(this.username, this.password, this.baseuri, "ExposurePeriodService", arg, this.timeoutSeconds);
    }

    public ExportExposurePeriodResponse ExportExposurePeriod(
      ExportExposurePeriod arg)
    {
      return Client.Post<ExportExposurePeriod, ExportExposurePeriodResponse>(this.username, this.password, this.baseuri, "ExposurePeriodService", arg, this.timeoutSeconds);
    }

    public Task<ExportExposurePeriodResponse> ExportExposurePeriodAsync(
      ExportExposurePeriod arg)
    {
      return Client.PostAsync<ExportExposurePeriod, ExportExposurePeriodResponse>(this.username, this.password, this.baseuri, "ExposurePeriodService", arg, this.timeoutSeconds);
    }
  }
}
