
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
    private readonly string baseuri;

    public EmployeeServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ImportEmployeesResponse ImportEmployees(ImportEmployees arg)
    {
      return Client.Post<ImportEmployees, ImportEmployeesResponse>(this.username, this.password, this.baseuri, "EmployeeService", arg);
    }

    public Task<ImportEmployeesResponse> ImportEmployeesAsync(
      ImportEmployees arg)
    {
      return Client.PostAsync<ImportEmployees, ImportEmployeesResponse>(this.username, this.password, this.baseuri, "EmployeeService", arg);
    }

    public ExportEmployeesListResponse ExportEmployeesList(
      ExportEmployeesList arg)
    {
      return Client.Post<ExportEmployeesList, ExportEmployeesListResponse>(this.username, this.password, this.baseuri, "EmployeeService", arg);
    }

    public Task<ExportEmployeesListResponse> ExportEmployeesListAsync(
      ExportEmployeesList arg)
    {
      return Client.PostAsync<ExportEmployeesList, ExportEmployeesListResponse>(this.username, this.password, this.baseuri, "EmployeeService", arg);
    }

    public ExportEmployeesResponse ExportEmployees(ExportEmployees arg)
    {
      return Client.Post<ExportEmployees, ExportEmployeesResponse>(this.username, this.password, this.baseuri, "EmployeeService", arg);
    }

    public Task<ExportEmployeesResponse> ExportEmployeesAsync(
      ExportEmployees arg)
    {
      return Client.PostAsync<ExportEmployees, ExportEmployeesResponse>(this.username, this.password, this.baseuri, "EmployeeService", arg);
    }

    public DeleteEmployeesResponse DeleteEmployees(DeleteEmployees arg)
    {
      return Client.Post<DeleteEmployees, DeleteEmployeesResponse>(this.username, this.password, this.baseuri, "EmployeeService", arg);
    }

    public Task<DeleteEmployeesResponse> DeleteEmployeesAsync(
      DeleteEmployees arg)
    {
      return Client.PostAsync<DeleteEmployees, DeleteEmployeesResponse>(this.username, this.password, this.baseuri, "EmployeeService", arg);
    }

    public ExportEmployeeInformationsResponse ExportEmployeeInformations(
      ExportEmployeeInformations arg)
    {
      return Client.Post<ExportEmployeeInformations, ExportEmployeeInformationsResponse>(this.username, this.password, this.baseuri, "EmployeeService", arg);
    }

    public Task<ExportEmployeeInformationsResponse> ExportEmployeeInformationsAsync(
      ExportEmployeeInformations arg)
    {
      return Client.PostAsync<ExportEmployeeInformations, ExportEmployeeInformationsResponse>(this.username, this.password, this.baseuri, "EmployeeService", arg);
    }

    public ExportEmployeeInformationsListResponse ExportEmployeeInformationsList(
      ExportEmployeeInformationsList arg)
    {
      return Client.Post<ExportEmployeeInformationsList, ExportEmployeeInformationsListResponse>(this.username, this.password, this.baseuri, "EmployeeService", arg);
    }

    public Task<ExportEmployeeInformationsListResponse> ExportEmployeeInformationsListAsync(
      ExportEmployeeInformationsList arg)
    {
      return Client.PostAsync<ExportEmployeeInformationsList, ExportEmployeeInformationsListResponse>(this.username, this.password, this.baseuri, "EmployeeService", arg);
    }

    public ExportEmployeeInformationsForModuleResponse ExportEmployeeInformationsForModule(
      ExportEmployeeInformationsForModule arg)
    {
      return Client.Post<ExportEmployeeInformationsForModule, ExportEmployeeInformationsForModuleResponse>(this.username, this.password, this.baseuri, "EmployeeService", arg);
    }

    public Task<ExportEmployeeInformationsForModuleResponse> ExportEmployeeInformationsForModuleAsync(
      ExportEmployeeInformationsForModule arg)
    {
      return Client.PostAsync<ExportEmployeeInformationsForModule, ExportEmployeeInformationsForModuleResponse>(this.username, this.password, this.baseuri, "EmployeeService", arg);
    }
  }
}
