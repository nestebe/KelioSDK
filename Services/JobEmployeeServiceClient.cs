
//.JobEmployeeServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class JobEmployeeServiceClient
  {
    private const string service = "JobEmployeeService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public JobEmployeeServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ImportJobsEmployeesResponse ImportJobsEmployees(
      ImportJobsEmployees arg)
    {
      return Client.Post<ImportJobsEmployees, ImportJobsEmployeesResponse>(this.username, this.password, this.baseuri, "JobEmployeeService", arg);
    }

    public Task<ImportJobsEmployeesResponse> ImportJobsEmployeesAsync(
      ImportJobsEmployees arg)
    {
      return Client.PostAsync<ImportJobsEmployees, ImportJobsEmployeesResponse>(this.username, this.password, this.baseuri, "JobEmployeeService", arg);
    }

    public ExportJobsEmployeesResponse ExportJobsEmployees(
      ExportJobsEmployees arg)
    {
      return Client.Post<ExportJobsEmployees, ExportJobsEmployeesResponse>(this.username, this.password, this.baseuri, "JobEmployeeService", arg);
    }

    public Task<ExportJobsEmployeesResponse> ExportJobsEmployeesAsync(
      ExportJobsEmployees arg)
    {
      return Client.PostAsync<ExportJobsEmployees, ExportJobsEmployeesResponse>(this.username, this.password, this.baseuri, "JobEmployeeService", arg);
    }
  }
}
