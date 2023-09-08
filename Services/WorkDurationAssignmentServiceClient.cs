
//.WorkDurationAssignmentServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class WorkDurationAssignmentServiceClient
  {
    private const string service = "WorkDurationAssignmentService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public WorkDurationAssignmentServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportWorkDurationAssignmentsResponse ExportWorkDurationAssignments(
      ExportWorkDurationAssignments arg)
    {
      return Client.Post<ExportWorkDurationAssignments, ExportWorkDurationAssignmentsResponse>(this.username, this.password, this.baseuri, "WorkDurationAssignmentService", arg);
    }

    public Task<ExportWorkDurationAssignmentsResponse> ExportWorkDurationAssignmentsAsync(
      ExportWorkDurationAssignments arg)
    {
      return Client.PostAsync<ExportWorkDurationAssignments, ExportWorkDurationAssignmentsResponse>(this.username, this.password, this.baseuri, "WorkDurationAssignmentService", arg);
    }

    public DeleteWorkDurationAssignmentsResponse DeleteWorkDurationAssignments(
      DeleteWorkDurationAssignments arg)
    {
      return Client.Post<DeleteWorkDurationAssignments, DeleteWorkDurationAssignmentsResponse>(this.username, this.password, this.baseuri, "WorkDurationAssignmentService", arg);
    }

    public Task<DeleteWorkDurationAssignmentsResponse> DeleteWorkDurationAssignmentsAsync(
      DeleteWorkDurationAssignments arg)
    {
      return Client.PostAsync<DeleteWorkDurationAssignments, DeleteWorkDurationAssignmentsResponse>(this.username, this.password, this.baseuri, "WorkDurationAssignmentService", arg);
    }

    public ImportWorkDurationAssignmentsResponse ImportWorkDurationAssignments(
      ImportWorkDurationAssignments arg)
    {
      return Client.Post<ImportWorkDurationAssignments, ImportWorkDurationAssignmentsResponse>(this.username, this.password, this.baseuri, "WorkDurationAssignmentService", arg);
    }

    public Task<ImportWorkDurationAssignmentsResponse> ImportWorkDurationAssignmentsAsync(
      ImportWorkDurationAssignments arg)
    {
      return Client.PostAsync<ImportWorkDurationAssignments, ImportWorkDurationAssignmentsResponse>(this.username, this.password, this.baseuri, "WorkDurationAssignmentService", arg);
    }
  }
}
