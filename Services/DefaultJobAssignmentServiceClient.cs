
//.DefaultJobAssignmentServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class DefaultJobAssignmentServiceClient
  {
    private const string service = "DefaultJobAssignmentService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public DefaultJobAssignmentServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportDefaultJobAssignmentResponse ExportDefaultJobAssignment(
      ExportDefaultJobAssignment arg)
    {
      return Client.Post<ExportDefaultJobAssignment, ExportDefaultJobAssignmentResponse>(this.username, this.password, this.baseuri, "DefaultJobAssignmentService", arg);
    }

    public Task<ExportDefaultJobAssignmentResponse> ExportDefaultJobAssignmentAsync(
      ExportDefaultJobAssignment arg)
    {
      return Client.PostAsync<ExportDefaultJobAssignment, ExportDefaultJobAssignmentResponse>(this.username, this.password, this.baseuri, "DefaultJobAssignmentService", arg);
    }

    public ExportDefaultJobAssignmentListResponse ExportDefaultJobAssignmentList(
      ExportDefaultJobAssignmentList arg)
    {
      return Client.Post<ExportDefaultJobAssignmentList, ExportDefaultJobAssignmentListResponse>(this.username, this.password, this.baseuri, "DefaultJobAssignmentService", arg);
    }

    public Task<ExportDefaultJobAssignmentListResponse> ExportDefaultJobAssignmentListAsync(
      ExportDefaultJobAssignmentList arg)
    {
      return Client.PostAsync<ExportDefaultJobAssignmentList, ExportDefaultJobAssignmentListResponse>(this.username, this.password, this.baseuri, "DefaultJobAssignmentService", arg);
    }
  }
}
