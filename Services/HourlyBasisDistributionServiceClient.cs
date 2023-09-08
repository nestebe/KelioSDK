
//.HourlyBasisDistributionServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class HourlyBasisDistributionServiceClient
  {
    private const string service = "HourlyBasisDistributionService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public HourlyBasisDistributionServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportHourlyBasisDistributionsListResponse ExportHourlyBasisDistributionsList(
      ExportHourlyBasisDistributionsList arg)
    {
      return Client.Post<ExportHourlyBasisDistributionsList, ExportHourlyBasisDistributionsListResponse>(this.username, this.password, this.baseuri, "HourlyBasisDistributionService", arg);
    }

    public Task<ExportHourlyBasisDistributionsListResponse> ExportHourlyBasisDistributionsListAsync(
      ExportHourlyBasisDistributionsList arg)
    {
      return Client.PostAsync<ExportHourlyBasisDistributionsList, ExportHourlyBasisDistributionsListResponse>(this.username, this.password, this.baseuri, "HourlyBasisDistributionService", arg);
    }

    public ImportHourlyBasisDistributionsListResponse ImportHourlyBasisDistributionsList(
      ImportHourlyBasisDistributionsList arg)
    {
      return Client.Post<ImportHourlyBasisDistributionsList, ImportHourlyBasisDistributionsListResponse>(this.username, this.password, this.baseuri, "HourlyBasisDistributionService", arg);
    }

    public Task<ImportHourlyBasisDistributionsListResponse> ImportHourlyBasisDistributionsListAsync(
      ImportHourlyBasisDistributionsList arg)
    {
      return Client.PostAsync<ImportHourlyBasisDistributionsList, ImportHourlyBasisDistributionsListResponse>(this.username, this.password, this.baseuri, "HourlyBasisDistributionService", arg);
    }
  }
}
