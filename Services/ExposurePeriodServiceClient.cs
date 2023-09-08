
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
    private readonly string baseuri;

    public ExposurePeriodServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ImportExposurePeriodResponse ImportExposurePeriod(
      ImportExposurePeriod arg)
    {
      return Client.Post<ImportExposurePeriod, ImportExposurePeriodResponse>(this.username, this.password, this.baseuri, "ExposurePeriodService", arg);
    }

    public Task<ImportExposurePeriodResponse> ImportExposurePeriodAsync(
      ImportExposurePeriod arg)
    {
      return Client.PostAsync<ImportExposurePeriod, ImportExposurePeriodResponse>(this.username, this.password, this.baseuri, "ExposurePeriodService", arg);
    }

    public ExportExposurePeriodResponse ExportExposurePeriod(
      ExportExposurePeriod arg)
    {
      return Client.Post<ExportExposurePeriod, ExportExposurePeriodResponse>(this.username, this.password, this.baseuri, "ExposurePeriodService", arg);
    }

    public Task<ExportExposurePeriodResponse> ExportExposurePeriodAsync(
      ExportExposurePeriod arg)
    {
      return Client.PostAsync<ExportExposurePeriod, ExportExposurePeriodResponse>(this.username, this.password, this.baseuri, "ExposurePeriodService", arg);
    }
  }
}
