
//.EmployeeServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class EmployeeServiceClient
  {
    private const string service = "EmployeeService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public EmployeeServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ImportEmployeesResponse ImportEmployees(ImportEmployees arg)
    {
      return Client.Post<ImportEmployees, ImportEmployeesResponse>(this.username, this.password, this.baseuri, "EmployeeService", arg, this.timeoutSeconds);
    }

    public Task<ImportEmployeesResponse> ImportEmployeesAsync(
      ImportEmployees arg)
    {
      return Client.PostAsync<ImportEmployees, ImportEmployeesResponse>(this.username, this.password, this.baseuri, "EmployeeService", arg, this.timeoutSeconds);
    }

    public ExportEmployeesListResponse ExportEmployeesList(
      ExportEmployeesList arg)
    {
      return Client.Post<ExportEmployeesList, ExportEmployeesListResponse>(this.username, this.password, this.baseuri, "EmployeeService", arg, this.timeoutSeconds);
    }

    public Task<ExportEmployeesListResponse> ExportEmployeesListAsync(
      ExportEmployeesList arg)
    {
      return Client.PostAsync<ExportEmployeesList, ExportEmployeesListResponse>(this.username, this.password, this.baseuri, "EmployeeService", arg, this.timeoutSeconds);
    }

    public ExportEmployeesResponse ExportEmployees(ExportEmployees arg)
    {
      return Client.Post<ExportEmployees, ExportEmployeesResponse>(this.username, this.password, this.baseuri, "EmployeeService", arg, this.timeoutSeconds);
    }

    public Task<ExportEmployeesResponse> ExportEmployeesAsync(
      ExportEmployees arg)
    {
      return Client.PostAsync<ExportEmployees, ExportEmployeesResponse>(this.username, this.password, this.baseuri, "EmployeeService", arg, this.timeoutSeconds);
    }

    public DeleteEmployeesResponse DeleteEmployees(DeleteEmployees arg)
    {
      return Client.Post<DeleteEmployees, DeleteEmployeesResponse>(this.username, this.password, this.baseuri, "EmployeeService", arg, this.timeoutSeconds);
    }

    public Task<DeleteEmployeesResponse> DeleteEmployeesAsync(
      DeleteEmployees arg)
    {
      return Client.PostAsync<DeleteEmployees, DeleteEmployeesResponse>(this.username, this.password, this.baseuri, "EmployeeService", arg, this.timeoutSeconds);
    }

    public ExportEmployeeInformationsResponse ExportEmployeeInformations(
      ExportEmployeeInformations arg)
    {
      return Client.Post<ExportEmployeeInformations, ExportEmployeeInformationsResponse>(this.username, this.password, this.baseuri, "EmployeeService", arg, this.timeoutSeconds);
    }

    public Task<ExportEmployeeInformationsResponse> ExportEmployeeInformationsAsync(
      ExportEmployeeInformations arg)
    {
      return Client.PostAsync<ExportEmployeeInformations, ExportEmployeeInformationsResponse>(this.username, this.password, this.baseuri, "EmployeeService", arg, this.timeoutSeconds);
    }

    public ExportEmployeeInformationsListResponse ExportEmployeeInformationsList(
      ExportEmployeeInformationsList arg)
    {
      return Client.Post<ExportEmployeeInformationsList, ExportEmployeeInformationsListResponse>(this.username, this.password, this.baseuri, "EmployeeService", arg, this.timeoutSeconds);
    }

    public Task<ExportEmployeeInformationsListResponse> ExportEmployeeInformationsListAsync(
      ExportEmployeeInformationsList arg)
    {
      return Client.PostAsync<ExportEmployeeInformationsList, ExportEmployeeInformationsListResponse>(this.username, this.password, this.baseuri, "EmployeeService", arg, this.timeoutSeconds);
    }

    public ExportEmployeeInformationsForModuleResponse ExportEmployeeInformationsForModule(
      ExportEmployeeInformationsForModule arg)
    {
      return Client.Post<ExportEmployeeInformationsForModule, ExportEmployeeInformationsForModuleResponse>(this.username, this.password, this.baseuri, "EmployeeService", arg, this.timeoutSeconds);
    }

    public Task<ExportEmployeeInformationsForModuleResponse> ExportEmployeeInformationsForModuleAsync(
      ExportEmployeeInformationsForModule arg)
    {
      return Client.PostAsync<ExportEmployeeInformationsForModule, ExportEmployeeInformationsForModuleResponse>(this.username, this.password, this.baseuri, "EmployeeService", arg, this.timeoutSeconds);
    }
  }
}
