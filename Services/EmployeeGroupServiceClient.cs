
//.EmployeeGroupServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class EmployeeGroupServiceClient
  {
    private const string service = "EmployeeGroupService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public EmployeeGroupServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportEmployeeGroupDescriptionsResponse ExportEmployeeGroupDescriptions(
      ExportEmployeeGroupDescriptions arg)
    {
      return Client.Post<ExportEmployeeGroupDescriptions, ExportEmployeeGroupDescriptionsResponse>(this.username, this.password, this.baseuri, "EmployeeGroupService", arg);
    }

    public Task<ExportEmployeeGroupDescriptionsResponse> ExportEmployeeGroupDescriptionsAsync(
      ExportEmployeeGroupDescriptions arg)
    {
      return Client.PostAsync<ExportEmployeeGroupDescriptions, ExportEmployeeGroupDescriptionsResponse>(this.username, this.password, this.baseuri, "EmployeeGroupService", arg);
    }

    public ExportEmployeeGroupsResponse ExportEmployeeGroups(
      ExportEmployeeGroups arg)
    {
      return Client.Post<ExportEmployeeGroups, ExportEmployeeGroupsResponse>(this.username, this.password, this.baseuri, "EmployeeGroupService", arg);
    }

    public Task<ExportEmployeeGroupsResponse> ExportEmployeeGroupsAsync(
      ExportEmployeeGroups arg)
    {
      return Client.PostAsync<ExportEmployeeGroups, ExportEmployeeGroupsResponse>(this.username, this.password, this.baseuri, "EmployeeGroupService", arg);
    }
  }
}
