
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
    private readonly string baseuri;

    public EmployeeFieldAssignmentServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ImportEmployeePredefinedFieldAssignmentsResponse ImportEmployeePredefinedFieldAssignments(
      ImportEmployeePredefinedFieldAssignments arg)
    {
      return Client.Post<ImportEmployeePredefinedFieldAssignments, ImportEmployeePredefinedFieldAssignmentsResponse>(this.username, this.password, this.baseuri, "EmployeeFieldAssignmentService", arg);
    }

    public Task<ImportEmployeePredefinedFieldAssignmentsResponse> ImportEmployeePredefinedFieldAssignmentsAsync(
      ImportEmployeePredefinedFieldAssignments arg)
    {
      return Client.PostAsync<ImportEmployeePredefinedFieldAssignments, ImportEmployeePredefinedFieldAssignmentsResponse>(this.username, this.password, this.baseuri, "EmployeeFieldAssignmentService", arg);
    }

    public ExportEmployeePredefinedFieldAssignmentsListResponse ExportEmployeePredefinedFieldAssignmentsList(
      ExportEmployeePredefinedFieldAssignmentsList arg)
    {
      return Client.Post<ExportEmployeePredefinedFieldAssignmentsList, ExportEmployeePredefinedFieldAssignmentsListResponse>(this.username, this.password, this.baseuri, "EmployeeFieldAssignmentService", arg);
    }

    public Task<ExportEmployeePredefinedFieldAssignmentsListResponse> ExportEmployeePredefinedFieldAssignmentsListAsync(
      ExportEmployeePredefinedFieldAssignmentsList arg)
    {
      return Client.PostAsync<ExportEmployeePredefinedFieldAssignmentsList, ExportEmployeePredefinedFieldAssignmentsListResponse>(this.username, this.password, this.baseuri, "EmployeeFieldAssignmentService", arg);
    }

    public ExportEmployeePredefinedFieldAssignmentsResponse ExportEmployeePredefinedFieldAssignments(
      ExportEmployeePredefinedFieldAssignments arg)
    {
      return Client.Post<ExportEmployeePredefinedFieldAssignments, ExportEmployeePredefinedFieldAssignmentsResponse>(this.username, this.password, this.baseuri, "EmployeeFieldAssignmentService", arg);
    }

    public Task<ExportEmployeePredefinedFieldAssignmentsResponse> ExportEmployeePredefinedFieldAssignmentsAsync(
      ExportEmployeePredefinedFieldAssignments arg)
    {
      return Client.PostAsync<ExportEmployeePredefinedFieldAssignments, ExportEmployeePredefinedFieldAssignmentsResponse>(this.username, this.password, this.baseuri, "EmployeeFieldAssignmentService", arg);
    }

    public ImportEmployeeFreeFieldAssignmentsResponse ImportEmployeeFreeFieldAssignments(
      ImportEmployeeFreeFieldAssignments arg)
    {
      return Client.Post<ImportEmployeeFreeFieldAssignments, ImportEmployeeFreeFieldAssignmentsResponse>(this.username, this.password, this.baseuri, "EmployeeFieldAssignmentService", arg);
    }

    public Task<ImportEmployeeFreeFieldAssignmentsResponse> ImportEmployeeFreeFieldAssignmentsAsync(
      ImportEmployeeFreeFieldAssignments arg)
    {
      return Client.PostAsync<ImportEmployeeFreeFieldAssignments, ImportEmployeeFreeFieldAssignmentsResponse>(this.username, this.password, this.baseuri, "EmployeeFieldAssignmentService", arg);
    }

    public ExportEmployeeFreeFieldAssignmentsResponse ExportEmployeeFreeFieldAssignments(
      ExportEmployeeFreeFieldAssignments arg)
    {
      return Client.Post<ExportEmployeeFreeFieldAssignments, ExportEmployeeFreeFieldAssignmentsResponse>(this.username, this.password, this.baseuri, "EmployeeFieldAssignmentService", arg);
    }

    public Task<ExportEmployeeFreeFieldAssignmentsResponse> ExportEmployeeFreeFieldAssignmentsAsync(
      ExportEmployeeFreeFieldAssignments arg)
    {
      return Client.PostAsync<ExportEmployeeFreeFieldAssignments, ExportEmployeeFreeFieldAssignmentsResponse>(this.username, this.password, this.baseuri, "EmployeeFieldAssignmentService", arg);
    }

    public ExportEmployeeFreeFieldAssignmentsListResponse ExportEmployeeFreeFieldAssignmentsList(
      ExportEmployeeFreeFieldAssignmentsList arg)
    {
      return Client.Post<ExportEmployeeFreeFieldAssignmentsList, ExportEmployeeFreeFieldAssignmentsListResponse>(this.username, this.password, this.baseuri, "EmployeeFieldAssignmentService", arg);
    }

    public Task<ExportEmployeeFreeFieldAssignmentsListResponse> ExportEmployeeFreeFieldAssignmentsListAsync(
      ExportEmployeeFreeFieldAssignmentsList arg)
    {
      return Client.PostAsync<ExportEmployeeFreeFieldAssignmentsList, ExportEmployeeFreeFieldAssignmentsListResponse>(this.username, this.password, this.baseuri, "EmployeeFieldAssignmentService", arg);
    }
  }
}
