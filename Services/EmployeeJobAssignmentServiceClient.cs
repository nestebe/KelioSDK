
//.EmployeeJobAssignmentServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class EmployeeJobAssignmentServiceClient
  {
    private const string service = "EmployeeJobAssignmentService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public EmployeeJobAssignmentServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportEmployeeJobAssignmentsResponse ExportEmployeeJobAssignments(
      ExportEmployeeJobAssignments arg)
    {
      return Client.Post<ExportEmployeeJobAssignments, ExportEmployeeJobAssignmentsResponse>(this.username, this.password, this.baseuri, "EmployeeJobAssignmentService", arg);
    }

    public Task<ExportEmployeeJobAssignmentsResponse> ExportEmployeeJobAssignmentsAsync(
      ExportEmployeeJobAssignments arg)
    {
      return Client.PostAsync<ExportEmployeeJobAssignments, ExportEmployeeJobAssignmentsResponse>(this.username, this.password, this.baseuri, "EmployeeJobAssignmentService", arg);
    }

    public ExportEmployeeJobAssignmentsListResponse ExportEmployeeJobAssignmentsList(
      ExportEmployeeJobAssignmentsList arg)
    {
      return Client.Post<ExportEmployeeJobAssignmentsList, ExportEmployeeJobAssignmentsListResponse>(this.username, this.password, this.baseuri, "EmployeeJobAssignmentService", arg);
    }

    public Task<ExportEmployeeJobAssignmentsListResponse> ExportEmployeeJobAssignmentsListAsync(
      ExportEmployeeJobAssignmentsList arg)
    {
      return Client.PostAsync<ExportEmployeeJobAssignmentsList, ExportEmployeeJobAssignmentsListResponse>(this.username, this.password, this.baseuri, "EmployeeJobAssignmentService", arg);
    }

    public ImportEmployeeJobAssignmentsResponse ImportEmployeeJobAssignments(
      ImportEmployeeJobAssignments arg)
    {
      return Client.Post<ImportEmployeeJobAssignments, ImportEmployeeJobAssignmentsResponse>(this.username, this.password, this.baseuri, "EmployeeJobAssignmentService", arg);
    }

    public Task<ImportEmployeeJobAssignmentsResponse> ImportEmployeeJobAssignmentsAsync(
      ImportEmployeeJobAssignments arg)
    {
      return Client.PostAsync<ImportEmployeeJobAssignments, ImportEmployeeJobAssignmentsResponse>(this.username, this.password, this.baseuri, "EmployeeJobAssignmentService", arg);
    }
  }
}
