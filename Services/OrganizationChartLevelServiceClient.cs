
//.OrganizationChartLevelServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class OrganizationChartLevelServiceClient
  {
    private const string service = "OrganizationChartLevelService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public OrganizationChartLevelServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ImportOrganizationChartLevelsResponse ImportOrganizationChartLevels(
      ImportOrganizationChartLevels arg)
    {
      return Client.Post<ImportOrganizationChartLevels, ImportOrganizationChartLevelsResponse>(this.username, this.password, this.baseuri, "OrganizationChartLevelService", arg, this.timeoutSeconds);
    }

    public Task<ImportOrganizationChartLevelsResponse> ImportOrganizationChartLevelsAsync(
      ImportOrganizationChartLevels arg)
    {
      return Client.PostAsync<ImportOrganizationChartLevels, ImportOrganizationChartLevelsResponse>(this.username, this.password, this.baseuri, "OrganizationChartLevelService", arg, this.timeoutSeconds);
    }

    public ExportOrganizationChartLevelsResponse ExportOrganizationChartLevels(
      ExportOrganizationChartLevels arg)
    {
      return Client.Post<ExportOrganizationChartLevels, ExportOrganizationChartLevelsResponse>(this.username, this.password, this.baseuri, "OrganizationChartLevelService", arg, this.timeoutSeconds);
    }

    public Task<ExportOrganizationChartLevelsResponse> ExportOrganizationChartLevelsAsync(
      ExportOrganizationChartLevels arg)
    {
      return Client.PostAsync<ExportOrganizationChartLevels, ExportOrganizationChartLevelsResponse>(this.username, this.password, this.baseuri, "OrganizationChartLevelService", arg, this.timeoutSeconds);
    }

    public DeleteOrganizationChartLevelsResponse DeleteOrganizationChartLevels(
      DeleteOrganizationChartLevels arg)
    {
      return Client.Post<DeleteOrganizationChartLevels, DeleteOrganizationChartLevelsResponse>(this.username, this.password, this.baseuri, "OrganizationChartLevelService", arg, this.timeoutSeconds);
    }

    public Task<DeleteOrganizationChartLevelsResponse> DeleteOrganizationChartLevelsAsync(
      DeleteOrganizationChartLevels arg)
    {
      return Client.PostAsync<DeleteOrganizationChartLevels, DeleteOrganizationChartLevelsResponse>(this.username, this.password, this.baseuri, "OrganizationChartLevelService", arg, this.timeoutSeconds);
    }
  }
}
