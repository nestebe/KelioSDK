
//.DailyScheduleAssignmentServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class DailyScheduleAssignmentServiceClient
  {
    private const string service = "DailyScheduleAssignmentService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public DailyScheduleAssignmentServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportDailyScheduleAssignmentsListResponse ExportDailyScheduleAssignmentsList(
      ExportDailyScheduleAssignmentsList arg)
    {
      return Client.Post<ExportDailyScheduleAssignmentsList, ExportDailyScheduleAssignmentsListResponse>(this.username, this.password, this.baseuri, "DailyScheduleAssignmentService", arg);
    }

    public Task<ExportDailyScheduleAssignmentsListResponse> ExportDailyScheduleAssignmentsListAsync(
      ExportDailyScheduleAssignmentsList arg)
    {
      return Client.PostAsync<ExportDailyScheduleAssignmentsList, ExportDailyScheduleAssignmentsListResponse>(this.username, this.password, this.baseuri, "DailyScheduleAssignmentService", arg);
    }

    public ExportDailyScheduleAssignmentsFromEmployeeListResponse ExportDailyScheduleAssignmentsFromEmployeeList(
      ExportDailyScheduleAssignmentsFromEmployeeList arg)
    {
      return Client.Post<ExportDailyScheduleAssignmentsFromEmployeeList, ExportDailyScheduleAssignmentsFromEmployeeListResponse>(this.username, this.password, this.baseuri, "DailyScheduleAssignmentService", arg);
    }

    public Task<ExportDailyScheduleAssignmentsFromEmployeeListResponse> ExportDailyScheduleAssignmentsFromEmployeeListAsync(
      ExportDailyScheduleAssignmentsFromEmployeeList arg)
    {
      return Client.PostAsync<ExportDailyScheduleAssignmentsFromEmployeeList, ExportDailyScheduleAssignmentsFromEmployeeListResponse>(this.username, this.password, this.baseuri, "DailyScheduleAssignmentService", arg);
    }

    public ExportDailyScheduleAssignmentsResponse ExportDailyScheduleAssignments(
      ExportDailyScheduleAssignments arg)
    {
      return Client.Post<ExportDailyScheduleAssignments, ExportDailyScheduleAssignmentsResponse>(this.username, this.password, this.baseuri, "DailyScheduleAssignmentService", arg);
    }

    public Task<ExportDailyScheduleAssignmentsResponse> ExportDailyScheduleAssignmentsAsync(
      ExportDailyScheduleAssignments arg)
    {
      return Client.PostAsync<ExportDailyScheduleAssignments, ExportDailyScheduleAssignmentsResponse>(this.username, this.password, this.baseuri, "DailyScheduleAssignmentService", arg);
    }

    public ImportDailyScheduleAssignmentsResponse ImportDailyScheduleAssignments(
      ImportDailyScheduleAssignments arg)
    {
      return Client.Post<ImportDailyScheduleAssignments, ImportDailyScheduleAssignmentsResponse>(this.username, this.password, this.baseuri, "DailyScheduleAssignmentService", arg);
    }

    public Task<ImportDailyScheduleAssignmentsResponse> ImportDailyScheduleAssignmentsAsync(
      ImportDailyScheduleAssignments arg)
    {
      return Client.PostAsync<ImportDailyScheduleAssignments, ImportDailyScheduleAssignmentsResponse>(this.username, this.password, this.baseuri, "DailyScheduleAssignmentService", arg);
    }

    public DeleteDailyScheduleAssignmentsResponse DeleteDailyScheduleAssignments(
      DeleteDailyScheduleAssignments arg)
    {
      return Client.Post<DeleteDailyScheduleAssignments, DeleteDailyScheduleAssignmentsResponse>(this.username, this.password, this.baseuri, "DailyScheduleAssignmentService", arg);
    }

    public Task<DeleteDailyScheduleAssignmentsResponse> DeleteDailyScheduleAssignmentsAsync(
      DeleteDailyScheduleAssignments arg)
    {
      return Client.PostAsync<DeleteDailyScheduleAssignments, DeleteDailyScheduleAssignmentsResponse>(this.username, this.password, this.baseuri, "DailyScheduleAssignmentService", arg);
    }
  }
}
