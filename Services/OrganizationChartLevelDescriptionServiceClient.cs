
//.OrganizationChartLevelDescriptionServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class OrganizationChartLevelDescriptionServiceClient
  {
    private const string service = "OrganizationChartLevelDescriptionService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public OrganizationChartLevelDescriptionServiceClient(
      string username,
      string password,
      string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ExportOrganizationChartLevelDescriptionsForLevelResponse ExportOrganizationChartLevelDescriptionsForLevel(
      ExportOrganizationChartLevelDescriptionsForLevel arg)
    {
      return Client.Post<ExportOrganizationChartLevelDescriptionsForLevel, ExportOrganizationChartLevelDescriptionsForLevelResponse>(this.username, this.password, this.baseuri, "OrganizationChartLevelDescriptionService", arg, this.timeoutSeconds);
    }

    public Task<ExportOrganizationChartLevelDescriptionsForLevelResponse> ExportOrganizationChartLevelDescriptionsForLevelAsync(
      ExportOrganizationChartLevelDescriptionsForLevel arg)
    {
      return Client.PostAsync<ExportOrganizationChartLevelDescriptionsForLevel, ExportOrganizationChartLevelDescriptionsForLevelResponse>(this.username, this.password, this.baseuri, "OrganizationChartLevelDescriptionService", arg, this.timeoutSeconds);
    }

    public ExportOrganizationChartLevelDescriptionsResponse ExportOrganizationChartLevelDescriptions(
      ExportOrganizationChartLevelDescriptions arg)
    {
      return Client.Post<ExportOrganizationChartLevelDescriptions, ExportOrganizationChartLevelDescriptionsResponse>(this.username, this.password, this.baseuri, "OrganizationChartLevelDescriptionService", arg, this.timeoutSeconds);
    }

    public Task<ExportOrganizationChartLevelDescriptionsResponse> ExportOrganizationChartLevelDescriptionsAsync(
      ExportOrganizationChartLevelDescriptions arg)
    {
      return Client.PostAsync<ExportOrganizationChartLevelDescriptions, ExportOrganizationChartLevelDescriptionsResponse>(this.username, this.password, this.baseuri, "OrganizationChartLevelDescriptionService", arg, this.timeoutSeconds);
    }
  }
}
