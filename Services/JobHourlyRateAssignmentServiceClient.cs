
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
    private readonly string baseuri; private readonly int timeoutSeconds;

    public JobHourlyRateAssignmentServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ExportJobHourlyRateAssignmentsListResponse ExportJobHourlyRateAssignmentsList(
      ExportJobHourlyRateAssignmentsList arg)
    {
      return Client.Post<ExportJobHourlyRateAssignmentsList, ExportJobHourlyRateAssignmentsListResponse>(this.username, this.password, this.baseuri, "JobHourlyRateAssignmentService", arg, this.timeoutSeconds);
    }

    public Task<ExportJobHourlyRateAssignmentsListResponse> ExportJobHourlyRateAssignmentsListAsync(
      ExportJobHourlyRateAssignmentsList arg)
    {
      return Client.PostAsync<ExportJobHourlyRateAssignmentsList, ExportJobHourlyRateAssignmentsListResponse>(this.username, this.password, this.baseuri, "JobHourlyRateAssignmentService", arg, this.timeoutSeconds);
    }

    public ExportJobHourlyRateAssignmentsResponse ExportJobHourlyRateAssignments(
      ExportJobHourlyRateAssignments arg)
    {
      return Client.Post<ExportJobHourlyRateAssignments, ExportJobHourlyRateAssignmentsResponse>(this.username, this.password, this.baseuri, "JobHourlyRateAssignmentService", arg, this.timeoutSeconds);
    }

    public Task<ExportJobHourlyRateAssignmentsResponse> ExportJobHourlyRateAssignmentsAsync(
      ExportJobHourlyRateAssignments arg)
    {
      return Client.PostAsync<ExportJobHourlyRateAssignments, ExportJobHourlyRateAssignmentsResponse>(this.username, this.password, this.baseuri, "JobHourlyRateAssignmentService", arg, this.timeoutSeconds);
    }

    public ImportJobHourlyRateAssignmentsResponse ImportJobHourlyRateAssignments(
      ImportJobHourlyRateAssignments arg)
    {
      return Client.Post<ImportJobHourlyRateAssignments, ImportJobHourlyRateAssignmentsResponse>(this.username, this.password, this.baseuri, "JobHourlyRateAssignmentService", arg, this.timeoutSeconds);
    }

    public Task<ImportJobHourlyRateAssignmentsResponse> ImportJobHourlyRateAssignmentsAsync(
      ImportJobHourlyRateAssignments arg)
    {
      return Client.PostAsync<ImportJobHourlyRateAssignments, ImportJobHourlyRateAssignmentsResponse>(this.username, this.password, this.baseuri, "JobHourlyRateAssignmentService", arg, this.timeoutSeconds);
    }
  }
}
