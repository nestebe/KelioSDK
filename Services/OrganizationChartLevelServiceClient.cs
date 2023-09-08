
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
    private readonly string baseuri;

    public OrganizationChartLevelServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ImportOrganizationChartLevelsResponse ImportOrganizationChartLevels(
      ImportOrganizationChartLevels arg)
    {
      return Client.Post<ImportOrganizationChartLevels, ImportOrganizationChartLevelsResponse>(this.username, this.password, this.baseuri, "OrganizationChartLevelService", arg);
    }

    public Task<ImportOrganizationChartLevelsResponse> ImportOrganizationChartLevelsAsync(
      ImportOrganizationChartLevels arg)
    {
      return Client.PostAsync<ImportOrganizationChartLevels, ImportOrganizationChartLevelsResponse>(this.username, this.password, this.baseuri, "OrganizationChartLevelService", arg);
    }

    public ExportOrganizationChartLevelsResponse ExportOrganizationChartLevels(
      ExportOrganizationChartLevels arg)
    {
      return Client.Post<ExportOrganizationChartLevels, ExportOrganizationChartLevelsResponse>(this.username, this.password, this.baseuri, "OrganizationChartLevelService", arg);
    }

    public Task<ExportOrganizationChartLevelsResponse> ExportOrganizationChartLevelsAsync(
      ExportOrganizationChartLevels arg)
    {
      return Client.PostAsync<ExportOrganizationChartLevels, ExportOrganizationChartLevelsResponse>(this.username, this.password, this.baseuri, "OrganizationChartLevelService", arg);
    }

    public DeleteOrganizationChartLevelsResponse DeleteOrganizationChartLevels(
      DeleteOrganizationChartLevels arg)
    {
      return Client.Post<DeleteOrganizationChartLevels, DeleteOrganizationChartLevelsResponse>(this.username, this.password, this.baseuri, "OrganizationChartLevelService", arg);
    }

    public Task<DeleteOrganizationChartLevelsResponse> DeleteOrganizationChartLevelsAsync(
      DeleteOrganizationChartLevels arg)
    {
      return Client.PostAsync<DeleteOrganizationChartLevels, DeleteOrganizationChartLevelsResponse>(this.username, this.password, this.baseuri, "OrganizationChartLevelService", arg);
    }
  }
}
