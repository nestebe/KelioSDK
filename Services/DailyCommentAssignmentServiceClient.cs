
//.DailyCommentAssignmentServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class DailyCommentAssignmentServiceClient
  {
    private const string service = "DailyCommentAssignmentService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public DailyCommentAssignmentServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ExportDailyCommentAssignmentsListResponse ExportDailyCommentAssignmentsList(
      ExportDailyCommentAssignmentsList arg)
    {
      return Client.Post<ExportDailyCommentAssignmentsList, ExportDailyCommentAssignmentsListResponse>(this.username, this.password, this.baseuri, "DailyCommentAssignmentService", arg, this.timeoutSeconds);
    }

    public Task<ExportDailyCommentAssignmentsListResponse> ExportDailyCommentAssignmentsListAsync(
      ExportDailyCommentAssignmentsList arg)
    {
      return Client.PostAsync<ExportDailyCommentAssignmentsList, ExportDailyCommentAssignmentsListResponse>(this.username, this.password, this.baseuri, "DailyCommentAssignmentService", arg, this.timeoutSeconds);
    }

    public DeleteDailyCommentAssignmentsResponse DeleteDailyCommentAssignments(
      DeleteDailyCommentAssignments arg)
    {
      return Client.Post<DeleteDailyCommentAssignments, DeleteDailyCommentAssignmentsResponse>(this.username, this.password, this.baseuri, "DailyCommentAssignmentService", arg, this.timeoutSeconds);
    }

    public Task<DeleteDailyCommentAssignmentsResponse> DeleteDailyCommentAssignmentsAsync(
      DeleteDailyCommentAssignments arg)
    {
      return Client.PostAsync<DeleteDailyCommentAssignments, DeleteDailyCommentAssignmentsResponse>(this.username, this.password, this.baseuri, "DailyCommentAssignmentService", arg, this.timeoutSeconds);
    }

    public ImportDailyCommentAssignmentsResponse ImportDailyCommentAssignments(
      ImportDailyCommentAssignments arg)
    {
      return Client.Post<ImportDailyCommentAssignments, ImportDailyCommentAssignmentsResponse>(this.username, this.password, this.baseuri, "DailyCommentAssignmentService", arg, this.timeoutSeconds);
    }

    public Task<ImportDailyCommentAssignmentsResponse> ImportDailyCommentAssignmentsAsync(
      ImportDailyCommentAssignments arg)
    {
      return Client.PostAsync<ImportDailyCommentAssignments, ImportDailyCommentAssignmentsResponse>(this.username, this.password, this.baseuri, "DailyCommentAssignmentService", arg, this.timeoutSeconds);
    }
  }
}
