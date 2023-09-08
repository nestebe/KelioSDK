
//.JobHourlyRateAssignmentServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class JobHourlyRateAssignmentServiceClient
  {
    private const string service = "JobHourlyRateAssignmentService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public JobHourlyRateAssignmentServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportJobHourlyRateAssignmentsListResponse ExportJobHourlyRateAssignmentsList(
      ExportJobHourlyRateAssignmentsList arg)
    {
      return Client.Post<ExportJobHourlyRateAssignmentsList, ExportJobHourlyRateAssignmentsListResponse>(this.username, this.password, this.baseuri, "JobHourlyRateAssignmentService", arg);
    }

    public Task<ExportJobHourlyRateAssignmentsListResponse> ExportJobHourlyRateAssignmentsListAsync(
      ExportJobHourlyRateAssignmentsList arg)
    {
      return Client.PostAsync<ExportJobHourlyRateAssignmentsList, ExportJobHourlyRateAssignmentsListResponse>(this.username, this.password, this.baseuri, "JobHourlyRateAssignmentService", arg);
    }

    public ExportJobHourlyRateAssignmentsResponse ExportJobHourlyRateAssignments(
      ExportJobHourlyRateAssignments arg)
    {
      return Client.Post<ExportJobHourlyRateAssignments, ExportJobHourlyRateAssignmentsResponse>(this.username, this.password, this.baseuri, "JobHourlyRateAssignmentService", arg);
    }

    public Task<ExportJobHourlyRateAssignmentsResponse> ExportJobHourlyRateAssignmentsAsync(
      ExportJobHourlyRateAssignments arg)
    {
      return Client.PostAsync<ExportJobHourlyRateAssignments, ExportJobHourlyRateAssignmentsResponse>(this.username, this.password, this.baseuri, "JobHourlyRateAssignmentService", arg);
    }

    public ImportJobHourlyRateAssignmentsResponse ImportJobHourlyRateAssignments(
      ImportJobHourlyRateAssignments arg)
    {
      return Client.Post<ImportJobHourlyRateAssignments, ImportJobHourlyRateAssignmentsResponse>(this.username, this.password, this.baseuri, "JobHourlyRateAssignmentService", arg);
    }

    public Task<ImportJobHourlyRateAssignmentsResponse> ImportJobHourlyRateAssignmentsAsync(
      ImportJobHourlyRateAssignments arg)
    {
      return Client.PostAsync<ImportJobHourlyRateAssignments, ImportJobHourlyRateAssignmentsResponse>(this.username, this.password, this.baseuri, "JobHourlyRateAssignmentService", arg);
    }
  }
}
