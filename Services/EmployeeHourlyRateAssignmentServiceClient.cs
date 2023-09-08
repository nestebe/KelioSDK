
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
    private readonly string baseuri;

    public EmployeeHourlyRateAssignmentServiceClient(
      string username,
      string password,
      string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ImportEmployeeHourlyRateAssignmentsResponse ImportEmployeeHourlyRateAssignments(
      ImportEmployeeHourlyRateAssignments arg)
    {
      return Client.Post<ImportEmployeeHourlyRateAssignments, ImportEmployeeHourlyRateAssignmentsResponse>(this.username, this.password, this.baseuri, "EmployeeHourlyRateAssignmentService", arg);
    }

    public Task<ImportEmployeeHourlyRateAssignmentsResponse> ImportEmployeeHourlyRateAssignmentsAsync(
      ImportEmployeeHourlyRateAssignments arg)
    {
      return Client.PostAsync<ImportEmployeeHourlyRateAssignments, ImportEmployeeHourlyRateAssignmentsResponse>(this.username, this.password, this.baseuri, "EmployeeHourlyRateAssignmentService", arg);
    }

    public ExportEmployeeHourlyRateAssignmentsResponse ExportEmployeeHourlyRateAssignments(
      ExportEmployeeHourlyRateAssignments arg)
    {
      return Client.Post<ExportEmployeeHourlyRateAssignments, ExportEmployeeHourlyRateAssignmentsResponse>(this.username, this.password, this.baseuri, "EmployeeHourlyRateAssignmentService", arg);
    }

    public Task<ExportEmployeeHourlyRateAssignmentsResponse> ExportEmployeeHourlyRateAssignmentsAsync(
      ExportEmployeeHourlyRateAssignments arg)
    {
      return Client.PostAsync<ExportEmployeeHourlyRateAssignments, ExportEmployeeHourlyRateAssignmentsResponse>(this.username, this.password, this.baseuri, "EmployeeHourlyRateAssignmentService", arg);
    }

    public ExportEmployeeHourlyRateAssignmentsListResponse ExportEmployeeHourlyRateAssignmentsList(
      ExportEmployeeHourlyRateAssignmentsList arg)
    {
      return Client.Post<ExportEmployeeHourlyRateAssignmentsList, ExportEmployeeHourlyRateAssignmentsListResponse>(this.username, this.password, this.baseuri, "EmployeeHourlyRateAssignmentService", arg);
    }

    public Task<ExportEmployeeHourlyRateAssignmentsListResponse> ExportEmployeeHourlyRateAssignmentsListAsync(
      ExportEmployeeHourlyRateAssignmentsList arg)
    {
      return Client.PostAsync<ExportEmployeeHourlyRateAssignmentsList, ExportEmployeeHourlyRateAssignmentsListResponse>(this.username, this.password, this.baseuri, "EmployeeHourlyRateAssignmentService", arg);
    }
  }
}
