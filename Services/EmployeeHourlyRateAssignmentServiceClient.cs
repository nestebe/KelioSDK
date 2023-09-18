
//.EmployeeHourlyRateAssignmentServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class EmployeeHourlyRateAssignmentServiceClient
  {
    private const string service = "EmployeeHourlyRateAssignmentService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public EmployeeHourlyRateAssignmentServiceClient(
      string username,
      string password,
      string baseuri, int timeoutSeconds = 60) 
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ImportEmployeeHourlyRateAssignmentsResponse ImportEmployeeHourlyRateAssignments(
      ImportEmployeeHourlyRateAssignments arg)
    {
      return Client.Post<ImportEmployeeHourlyRateAssignments, ImportEmployeeHourlyRateAssignmentsResponse>(this.username, this.password, this.baseuri, "EmployeeHourlyRateAssignmentService", arg, this.timeoutSeconds);
    }

    public Task<ImportEmployeeHourlyRateAssignmentsResponse> ImportEmployeeHourlyRateAssignmentsAsync(
      ImportEmployeeHourlyRateAssignments arg)
    {
      return Client.PostAsync<ImportEmployeeHourlyRateAssignments, ImportEmployeeHourlyRateAssignmentsResponse>(this.username, this.password, this.baseuri, "EmployeeHourlyRateAssignmentService", arg, this.timeoutSeconds);
    }

    public ExportEmployeeHourlyRateAssignmentsResponse ExportEmployeeHourlyRateAssignments(
      ExportEmployeeHourlyRateAssignments arg)
    {
      return Client.Post<ExportEmployeeHourlyRateAssignments, ExportEmployeeHourlyRateAssignmentsResponse>(this.username, this.password, this.baseuri, "EmployeeHourlyRateAssignmentService", arg, this.timeoutSeconds);
    }

    public Task<ExportEmployeeHourlyRateAssignmentsResponse> ExportEmployeeHourlyRateAssignmentsAsync(
      ExportEmployeeHourlyRateAssignments arg)
    {
      return Client.PostAsync<ExportEmployeeHourlyRateAssignments, ExportEmployeeHourlyRateAssignmentsResponse>(this.username, this.password, this.baseuri, "EmployeeHourlyRateAssignmentService", arg, this.timeoutSeconds);
    }

    public ExportEmployeeHourlyRateAssignmentsListResponse ExportEmployeeHourlyRateAssignmentsList(
      ExportEmployeeHourlyRateAssignmentsList arg)
    {
      return Client.Post<ExportEmployeeHourlyRateAssignmentsList, ExportEmployeeHourlyRateAssignmentsListResponse>(this.username, this.password, this.baseuri, "EmployeeHourlyRateAssignmentService", arg, this.timeoutSeconds);
    }

    public Task<ExportEmployeeHourlyRateAssignmentsListResponse> ExportEmployeeHourlyRateAssignmentsListAsync(
      ExportEmployeeHourlyRateAssignmentsList arg)
    {
      return Client.PostAsync<ExportEmployeeHourlyRateAssignmentsList, ExportEmployeeHourlyRateAssignmentsListResponse>(this.username, this.password, this.baseuri, "EmployeeHourlyRateAssignmentService", arg, this.timeoutSeconds);
    }
  }
}
