
//.ScheduleByExceptionAssignmentServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class ScheduleByExceptionAssignmentServiceClient
  {
    private const string service = "ScheduleByExceptionAssignmentService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public ScheduleByExceptionAssignmentServiceClient(
      string username,
      string password,
      string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ExportScheduleByExceptionAssignmentsResponse ExportScheduleByExceptionAssignments(
      ExportScheduleByExceptionAssignments arg)
    {
      return Client.Post<ExportScheduleByExceptionAssignments, ExportScheduleByExceptionAssignmentsResponse>(this.username, this.password, this.baseuri, "ScheduleByExceptionAssignmentService", arg, this.timeoutSeconds);
    }

    public Task<ExportScheduleByExceptionAssignmentsResponse> ExportScheduleByExceptionAssignmentsAsync(
      ExportScheduleByExceptionAssignments arg)
    {
      return Client.PostAsync<ExportScheduleByExceptionAssignments, ExportScheduleByExceptionAssignmentsResponse>(this.username, this.password, this.baseuri, "ScheduleByExceptionAssignmentService", arg, this.timeoutSeconds);
    }

    public ExportScheduleByExceptionAssignmentsListResponse ExportScheduleByExceptionAssignmentsList(
      ExportScheduleByExceptionAssignmentsList arg)
    {
      return Client.Post<ExportScheduleByExceptionAssignmentsList, ExportScheduleByExceptionAssignmentsListResponse>(this.username, this.password, this.baseuri, "ScheduleByExceptionAssignmentService", arg, this.timeoutSeconds);
    }

    public Task<ExportScheduleByExceptionAssignmentsListResponse> ExportScheduleByExceptionAssignmentsListAsync(
      ExportScheduleByExceptionAssignmentsList arg)
    {
      return Client.PostAsync<ExportScheduleByExceptionAssignmentsList, ExportScheduleByExceptionAssignmentsListResponse>(this.username, this.password, this.baseuri, "ScheduleByExceptionAssignmentService", arg, this.timeoutSeconds);
    }

    public ImportScheduleByExceptionAssignmentsResponse ImportScheduleByExceptionAssignments(
      ImportScheduleByExceptionAssignments arg)
    {
      return Client.Post<ImportScheduleByExceptionAssignments, ImportScheduleByExceptionAssignmentsResponse>(this.username, this.password, this.baseuri, "ScheduleByExceptionAssignmentService", arg, this.timeoutSeconds);
    }

    public Task<ImportScheduleByExceptionAssignmentsResponse> ImportScheduleByExceptionAssignmentsAsync(
      ImportScheduleByExceptionAssignments arg)
    {
      return Client.PostAsync<ImportScheduleByExceptionAssignments, ImportScheduleByExceptionAssignmentsResponse>(this.username, this.password, this.baseuri, "ScheduleByExceptionAssignmentService", arg, this.timeoutSeconds);
    }
  }
}
