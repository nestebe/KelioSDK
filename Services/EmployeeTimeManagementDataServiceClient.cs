
//.EmployeeTimeManagementDataServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class EmployeeTimeManagementDataServiceClient
  {
    private const string service = "EmployeeTimeManagementDataService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public EmployeeTimeManagementDataServiceClient(
      string username,
      string password,
      string baseuri, int timeoutSeconds = 60) 
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ImportEmployeeTimeManagementDataResponse ImportEmployeeTimeManagementData(
      ImportEmployeeTimeManagementData arg)
    {
      return Client.Post<ImportEmployeeTimeManagementData, ImportEmployeeTimeManagementDataResponse>(this.username, this.password, this.baseuri, "EmployeeTimeManagementDataService", arg, this.timeoutSeconds);
    }

    public Task<ImportEmployeeTimeManagementDataResponse> ImportEmployeeTimeManagementDataAsync(
      ImportEmployeeTimeManagementData arg)
    {
      return Client.PostAsync<ImportEmployeeTimeManagementData, ImportEmployeeTimeManagementDataResponse>(this.username, this.password, this.baseuri, "EmployeeTimeManagementDataService", arg, this.timeoutSeconds);
    }

    public ExportEmployeesTimeManagementDataResponse ExportEmployeesTimeManagementData(
      ExportEmployeesTimeManagementData arg)
    {
      return Client.Post<ExportEmployeesTimeManagementData, ExportEmployeesTimeManagementDataResponse>(this.username, this.password, this.baseuri, "EmployeeTimeManagementDataService", arg, this.timeoutSeconds);
    }

    public Task<ExportEmployeesTimeManagementDataResponse> ExportEmployeesTimeManagementDataAsync(
      ExportEmployeesTimeManagementData arg)
    {
      return Client.PostAsync<ExportEmployeesTimeManagementData, ExportEmployeesTimeManagementDataResponse>(this.username, this.password, this.baseuri, "EmployeeTimeManagementDataService", arg, this.timeoutSeconds);
    }

    public ExportEmployeesTimeManagementDataListResponse ExportEmployeesTimeManagementDataList(
      ExportEmployeesTimeManagementDataList arg)
    {
      return Client.Post<ExportEmployeesTimeManagementDataList, ExportEmployeesTimeManagementDataListResponse>(this.username, this.password, this.baseuri, "EmployeeTimeManagementDataService", arg, this.timeoutSeconds);
    }

    public Task<ExportEmployeesTimeManagementDataListResponse> ExportEmployeesTimeManagementDataListAsync(
      ExportEmployeesTimeManagementDataList arg)
    {
      return Client.PostAsync<ExportEmployeesTimeManagementDataList, ExportEmployeesTimeManagementDataListResponse>(this.username, this.password, this.baseuri, "EmployeeTimeManagementDataService", arg, this.timeoutSeconds);
    }
  }
}
