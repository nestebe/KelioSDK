
//.JobAssignmentServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class JobAssignmentServiceClient
  {
    private const string service = "JobAssignmentService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public JobAssignmentServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ImportJobAssignmentsResponse ImportJobAssignments(
      ImportJobAssignments arg)
    {
      return Client.Post<ImportJobAssignments, ImportJobAssignmentsResponse>(this.username, this.password, this.baseuri, "JobAssignmentService", arg);
    }

    public Task<ImportJobAssignmentsResponse> ImportJobAssignmentsAsync(
      ImportJobAssignments arg)
    {
      return Client.PostAsync<ImportJobAssignments, ImportJobAssignmentsResponse>(this.username, this.password, this.baseuri, "JobAssignmentService", arg);
    }

    public ExportJobAssignmentsFromEmployeeListResponse ExportJobAssignmentsFromEmployeeList(
      ExportJobAssignmentsFromEmployeeList arg)
    {
      return Client.Post<ExportJobAssignmentsFromEmployeeList, ExportJobAssignmentsFromEmployeeListResponse>(this.username, this.password, this.baseuri, "JobAssignmentService", arg);
    }

    public Task<ExportJobAssignmentsFromEmployeeListResponse> ExportJobAssignmentsFromEmployeeListAsync(
      ExportJobAssignmentsFromEmployeeList arg)
    {
      return Client.PostAsync<ExportJobAssignmentsFromEmployeeList, ExportJobAssignmentsFromEmployeeListResponse>(this.username, this.password, this.baseuri, "JobAssignmentService", arg);
    }

    public ExportJobAssignmentsResponse ExportJobAssignments(
      ExportJobAssignments arg)
    {
      return Client.Post<ExportJobAssignments, ExportJobAssignmentsResponse>(this.username, this.password, this.baseuri, "JobAssignmentService", arg);
    }

    public Task<ExportJobAssignmentsResponse> ExportJobAssignmentsAsync(
      ExportJobAssignments arg)
    {
      return Client.PostAsync<ExportJobAssignments, ExportJobAssignmentsResponse>(this.username, this.password, this.baseuri, "JobAssignmentService", arg);
    }

    public DeleteJobAssignmentsResponse DeleteJobAssignments(
      DeleteJobAssignments arg)
    {
      return Client.Post<DeleteJobAssignments, DeleteJobAssignmentsResponse>(this.username, this.password, this.baseuri, "JobAssignmentService", arg);
    }

    public Task<DeleteJobAssignmentsResponse> DeleteJobAssignmentsAsync(
      DeleteJobAssignments arg)
    {
      return Client.PostAsync<DeleteJobAssignments, DeleteJobAssignmentsResponse>(this.username, this.password, this.baseuri, "JobAssignmentService", arg);
    }

    public ExportJobAssignmentsListResponse ExportJobAssignmentsList(
      ExportJobAssignmentsList arg)
    {
      return Client.Post<ExportJobAssignmentsList, ExportJobAssignmentsListResponse>(this.username, this.password, this.baseuri, "JobAssignmentService", arg);
    }

    public Task<ExportJobAssignmentsListResponse> ExportJobAssignmentsListAsync(
      ExportJobAssignmentsList arg)
    {
      return Client.PostAsync<ExportJobAssignmentsList, ExportJobAssignmentsListResponse>(this.username, this.password, this.baseuri, "JobAssignmentService", arg);
    }

    public ExportComputedJobAssignmentsListResponse ExportComputedJobAssignmentsList(
      ExportComputedJobAssignmentsList arg)
    {
      return Client.Post<ExportComputedJobAssignmentsList, ExportComputedJobAssignmentsListResponse>(this.username, this.password, this.baseuri, "JobAssignmentService", arg);
    }

    public Task<ExportComputedJobAssignmentsListResponse> ExportComputedJobAssignmentsListAsync(
      ExportComputedJobAssignmentsList arg)
    {
      return Client.PostAsync<ExportComputedJobAssignmentsList, ExportComputedJobAssignmentsListResponse>(this.username, this.password, this.baseuri, "JobAssignmentService", arg);
    }
  }
}
