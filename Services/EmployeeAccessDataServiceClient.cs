
//.EmployeeAccessDataServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class EmployeeAccessDataServiceClient
  {
    private const string service = "EmployeeAccessDataService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public EmployeeAccessDataServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ImportEmployeeAccessDataResponse ImportEmployeeAccessData(
      ImportEmployeeAccessData arg)
    {
      return Client.Post<ImportEmployeeAccessData, ImportEmployeeAccessDataResponse>(this.username, this.password, this.baseuri, "EmployeeAccessDataService", arg);
    }

    public Task<ImportEmployeeAccessDataResponse> ImportEmployeeAccessDataAsync(
      ImportEmployeeAccessData arg)
    {
      return Client.PostAsync<ImportEmployeeAccessData, ImportEmployeeAccessDataResponse>(this.username, this.password, this.baseuri, "EmployeeAccessDataService", arg);
    }

    public ExportEmployeeAccessDataResponse ExportEmployeeAccessData(
      ExportEmployeeAccessData arg)
    {
      return Client.Post<ExportEmployeeAccessData, ExportEmployeeAccessDataResponse>(this.username, this.password, this.baseuri, "EmployeeAccessDataService", arg);
    }

    public Task<ExportEmployeeAccessDataResponse> ExportEmployeeAccessDataAsync(
      ExportEmployeeAccessData arg)
    {
      return Client.PostAsync<ExportEmployeeAccessData, ExportEmployeeAccessDataResponse>(this.username, this.password, this.baseuri, "EmployeeAccessDataService", arg);
    }

    public ExportEmployeeAccessDataListResponse ExportEmployeeAccessDataList(
      ExportEmployeeAccessDataList arg)
    {
      return Client.Post<ExportEmployeeAccessDataList, ExportEmployeeAccessDataListResponse>(this.username, this.password, this.baseuri, "EmployeeAccessDataService", arg);
    }

    public Task<ExportEmployeeAccessDataListResponse> ExportEmployeeAccessDataListAsync(
      ExportEmployeeAccessDataList arg)
    {
      return Client.PostAsync<ExportEmployeeAccessDataList, ExportEmployeeAccessDataListResponse>(this.username, this.password, this.baseuri, "EmployeeAccessDataService", arg);
    }
  }
}
