
//.LightEmployeeServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class LightEmployeeServiceClient
  {
    private const string service = "LightEmployeeService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public LightEmployeeServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public DeleteLightEmployeesResponse DeleteLightEmployees(
      DeleteLightEmployees arg)
    {
      return Client.Post<DeleteLightEmployees, DeleteLightEmployeesResponse>(this.username, this.password, this.baseuri, "LightEmployeeService", arg, this.timeoutSeconds);
    }

    public Task<DeleteLightEmployeesResponse> DeleteLightEmployeesAsync(
      DeleteLightEmployees arg)
    {
      return Client.PostAsync<DeleteLightEmployees, DeleteLightEmployeesResponse>(this.username, this.password, this.baseuri, "LightEmployeeService", arg, this.timeoutSeconds);
    }

    public ImportLightEmployeesResponse ImportLightEmployees(
      ImportLightEmployees arg)
    {
      return Client.Post<ImportLightEmployees, ImportLightEmployeesResponse>(this.username, this.password, this.baseuri, "LightEmployeeService", arg, this.timeoutSeconds);
    }

    public Task<ImportLightEmployeesResponse> ImportLightEmployeesAsync(
      ImportLightEmployees arg)
    {
      return Client.PostAsync<ImportLightEmployees, ImportLightEmployeesResponse>(this.username, this.password, this.baseuri, "LightEmployeeService", arg, this.timeoutSeconds);
    }

    public ExportLightEmployeesListResponse ExportLightEmployeesList(
      ExportLightEmployeesList arg)
    {
      return Client.Post<ExportLightEmployeesList, ExportLightEmployeesListResponse>(this.username, this.password, this.baseuri, "LightEmployeeService", arg, this.timeoutSeconds);
    }

    public Task<ExportLightEmployeesListResponse> ExportLightEmployeesListAsync(
      ExportLightEmployeesList arg)
    {
      return Client.PostAsync<ExportLightEmployeesList, ExportLightEmployeesListResponse>(this.username, this.password, this.baseuri, "LightEmployeeService", arg, this.timeoutSeconds);
    }

    public ExportLightEmployeesResponse ExportLightEmployees(
      ExportLightEmployees arg)
    {
      return Client.Post<ExportLightEmployees, ExportLightEmployeesResponse>(this.username, this.password, this.baseuri, "LightEmployeeService", arg, this.timeoutSeconds);
    }

    public Task<ExportLightEmployeesResponse> ExportLightEmployeesAsync(
      ExportLightEmployees arg)
    {
      return Client.PostAsync<ExportLightEmployees, ExportLightEmployeesResponse>(this.username, this.password, this.baseuri, "LightEmployeeService", arg, this.timeoutSeconds);
    }
  }
}
