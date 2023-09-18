
//.EmployeeAdministrativeDataServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class EmployeeAdministrativeDataServiceClient
  {
    private const string service = "EmployeeAdministrativeDataService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public EmployeeAdministrativeDataServiceClient(
      string username,
      string password,
      string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ImportEmployeeAdministrativeDataResponse ImportEmployeeAdministrativeData(
      ImportEmployeeAdministrativeData arg)
    {
      return Client.Post<ImportEmployeeAdministrativeData, ImportEmployeeAdministrativeDataResponse>(this.username, this.password, this.baseuri, "EmployeeAdministrativeDataService", arg, this.timeoutSeconds);
    }

    public Task<ImportEmployeeAdministrativeDataResponse> ImportEmployeeAdministrativeDataAsync(
      ImportEmployeeAdministrativeData arg)
    {
      return Client.PostAsync<ImportEmployeeAdministrativeData, ImportEmployeeAdministrativeDataResponse>(this.username, this.password, this.baseuri, "EmployeeAdministrativeDataService", arg, this.timeoutSeconds);
    }

    public ExportEmployeeAdministrativeDataResponse ExportEmployeeAdministrativeData(
      ExportEmployeeAdministrativeData arg)
    {
      return Client.Post<ExportEmployeeAdministrativeData, ExportEmployeeAdministrativeDataResponse>(this.username, this.password, this.baseuri, "EmployeeAdministrativeDataService", arg, this.timeoutSeconds);
    }

    public Task<ExportEmployeeAdministrativeDataResponse> ExportEmployeeAdministrativeDataAsync(
      ExportEmployeeAdministrativeData arg)
    {
      return Client.PostAsync<ExportEmployeeAdministrativeData, ExportEmployeeAdministrativeDataResponse>(this.username, this.password, this.baseuri, "EmployeeAdministrativeDataService", arg, this.timeoutSeconds);
    }

    public ExportEmployeeAdministrativeDataListResponse ExportEmployeeAdministrativeDataList(
      ExportEmployeeAdministrativeDataList arg)
    {
      return Client.Post<ExportEmployeeAdministrativeDataList, ExportEmployeeAdministrativeDataListResponse>(this.username, this.password, this.baseuri, "EmployeeAdministrativeDataService", arg, this.timeoutSeconds);
    }

    public Task<ExportEmployeeAdministrativeDataListResponse> ExportEmployeeAdministrativeDataListAsync(
      ExportEmployeeAdministrativeDataList arg)
    {
      return Client.PostAsync<ExportEmployeeAdministrativeDataList, ExportEmployeeAdministrativeDataListResponse>(this.username, this.password, this.baseuri, "EmployeeAdministrativeDataService", arg, this.timeoutSeconds);
    }
  }
}
