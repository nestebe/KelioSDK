
//.AssignmentPublicHolServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class AssignmentPublicHolServiceClient
  {
    private const string service = "AssignmentPublicHolService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public AssignmentPublicHolServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportAssignmentPublicHolListResponse ExportAssignmentPublicHolList(
      ExportAssignmentPublicHolList arg)
    {
      return Client.Post<ExportAssignmentPublicHolList, ExportAssignmentPublicHolListResponse>(this.username, this.password, this.baseuri, "AssignmentPublicHolService", arg);
    }

    public Task<ExportAssignmentPublicHolListResponse> ExportAssignmentPublicHolListAsync(
      ExportAssignmentPublicHolList arg)
    {
      return Client.PostAsync<ExportAssignmentPublicHolList, ExportAssignmentPublicHolListResponse>(this.username, this.password, this.baseuri, "AssignmentPublicHolService", arg);
    }

    public ExportAssignmentPublicHolFromEmployeeListResponse ExportAssignmentPublicHolFromEmployeeList(
      ExportAssignmentPublicHolFromEmployeeList arg)
    {
      return Client.Post<ExportAssignmentPublicHolFromEmployeeList, ExportAssignmentPublicHolFromEmployeeListResponse>(this.username, this.password, this.baseuri, "AssignmentPublicHolService", arg);
    }

    public Task<ExportAssignmentPublicHolFromEmployeeListResponse> ExportAssignmentPublicHolFromEmployeeListAsync(
      ExportAssignmentPublicHolFromEmployeeList arg)
    {
      return Client.PostAsync<ExportAssignmentPublicHolFromEmployeeList, ExportAssignmentPublicHolFromEmployeeListResponse>(this.username, this.password, this.baseuri, "AssignmentPublicHolService", arg);
    }

    public ExportAssignmentPublicHolResponse ExportAssignmentPublicHol(
      ExportAssignmentPublicHol arg)
    {
      return Client.Post<ExportAssignmentPublicHol, ExportAssignmentPublicHolResponse>(this.username, this.password, this.baseuri, "AssignmentPublicHolService", arg);
    }

    public Task<ExportAssignmentPublicHolResponse> ExportAssignmentPublicHolAsync(
      ExportAssignmentPublicHol arg)
    {
      return Client.PostAsync<ExportAssignmentPublicHol, ExportAssignmentPublicHolResponse>(this.username, this.password, this.baseuri, "AssignmentPublicHolService", arg);
    }
  }
}
