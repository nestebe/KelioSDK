
//.EmployeeFieldAssignmentServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class EmployeeFieldAssignmentServiceClient
  {
    private const string service = "EmployeeFieldAssignmentService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public EmployeeFieldAssignmentServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)  
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ImportEmployeePredefinedFieldAssignmentsResponse ImportEmployeePredefinedFieldAssignments(
      ImportEmployeePredefinedFieldAssignments arg)
    {
      return Client.Post<ImportEmployeePredefinedFieldAssignments, ImportEmployeePredefinedFieldAssignmentsResponse>(this.username, this.password, this.baseuri, "EmployeeFieldAssignmentService", arg, this.timeoutSeconds);
    }

    public Task<ImportEmployeePredefinedFieldAssignmentsResponse> ImportEmployeePredefinedFieldAssignmentsAsync(
      ImportEmployeePredefinedFieldAssignments arg)
    {
      return Client.PostAsync<ImportEmployeePredefinedFieldAssignments, ImportEmployeePredefinedFieldAssignmentsResponse>(this.username, this.password, this.baseuri, "EmployeeFieldAssignmentService", arg, this.timeoutSeconds);
    }

    public ExportEmployeePredefinedFieldAssignmentsListResponse ExportEmployeePredefinedFieldAssignmentsList(
      ExportEmployeePredefinedFieldAssignmentsList arg)
    {
      return Client.Post<ExportEmployeePredefinedFieldAssignmentsList, ExportEmployeePredefinedFieldAssignmentsListResponse>(this.username, this.password, this.baseuri, "EmployeeFieldAssignmentService", arg, this.timeoutSeconds);
    }

    public Task<ExportEmployeePredefinedFieldAssignmentsListResponse> ExportEmployeePredefinedFieldAssignmentsListAsync(
      ExportEmployeePredefinedFieldAssignmentsList arg)
    {
      return Client.PostAsync<ExportEmployeePredefinedFieldAssignmentsList, ExportEmployeePredefinedFieldAssignmentsListResponse>(this.username, this.password, this.baseuri, "EmployeeFieldAssignmentService", arg, this.timeoutSeconds);
    }

    public ExportEmployeePredefinedFieldAssignmentsResponse ExportEmployeePredefinedFieldAssignments(
      ExportEmployeePredefinedFieldAssignments arg)
    {
      return Client.Post<ExportEmployeePredefinedFieldAssignments, ExportEmployeePredefinedFieldAssignmentsResponse>(this.username, this.password, this.baseuri, "EmployeeFieldAssignmentService", arg, this.timeoutSeconds);
    }

    public Task<ExportEmployeePredefinedFieldAssignmentsResponse> ExportEmployeePredefinedFieldAssignmentsAsync(
      ExportEmployeePredefinedFieldAssignments arg)
    {
      return Client.PostAsync<ExportEmployeePredefinedFieldAssignments, ExportEmployeePredefinedFieldAssignmentsResponse>(this.username, this.password, this.baseuri, "EmployeeFieldAssignmentService", arg, this.timeoutSeconds);
    }

    public ImportEmployeeFreeFieldAssignmentsResponse ImportEmployeeFreeFieldAssignments(
      ImportEmployeeFreeFieldAssignments arg)
    {
      return Client.Post<ImportEmployeeFreeFieldAssignments, ImportEmployeeFreeFieldAssignmentsResponse>(this.username, this.password, this.baseuri, "EmployeeFieldAssignmentService", arg, this.timeoutSeconds);
    }

    public Task<ImportEmployeeFreeFieldAssignmentsResponse> ImportEmployeeFreeFieldAssignmentsAsync(
      ImportEmployeeFreeFieldAssignments arg)
    {
      return Client.PostAsync<ImportEmployeeFreeFieldAssignments, ImportEmployeeFreeFieldAssignmentsResponse>(this.username, this.password, this.baseuri, "EmployeeFieldAssignmentService", arg, this.timeoutSeconds);
    }

    public ExportEmployeeFreeFieldAssignmentsResponse ExportEmployeeFreeFieldAssignments(
      ExportEmployeeFreeFieldAssignments arg)
    {
      return Client.Post<ExportEmployeeFreeFieldAssignments, ExportEmployeeFreeFieldAssignmentsResponse>(this.username, this.password, this.baseuri, "EmployeeFieldAssignmentService", arg, this.timeoutSeconds);
    }

    public Task<ExportEmployeeFreeFieldAssignmentsResponse> ExportEmployeeFreeFieldAssignmentsAsync(
      ExportEmployeeFreeFieldAssignments arg)
    {
      return Client.PostAsync<ExportEmployeeFreeFieldAssignments, ExportEmployeeFreeFieldAssignmentsResponse>(this.username, this.password, this.baseuri, "EmployeeFieldAssignmentService", arg, this.timeoutSeconds);
    }

    public ExportEmployeeFreeFieldAssignmentsListResponse ExportEmployeeFreeFieldAssignmentsList(
      ExportEmployeeFreeFieldAssignmentsList arg)
    {
      return Client.Post<ExportEmployeeFreeFieldAssignmentsList, ExportEmployeeFreeFieldAssignmentsListResponse>(this.username, this.password, this.baseuri, "EmployeeFieldAssignmentService", arg, this.timeoutSeconds);
    }

    public Task<ExportEmployeeFreeFieldAssignmentsListResponse> ExportEmployeeFreeFieldAssignmentsListAsync(
      ExportEmployeeFreeFieldAssignmentsList arg)
    {
      return Client.PostAsync<ExportEmployeeFreeFieldAssignmentsList, ExportEmployeeFreeFieldAssignmentsListResponse>(this.username, this.password, this.baseuri, "EmployeeFieldAssignmentService", arg, this.timeoutSeconds);
    }
  }
}
