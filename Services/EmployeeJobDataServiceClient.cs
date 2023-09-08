
//.EmployeeJobDataServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class EmployeeJobDataServiceClient
  {
    private const string service = "EmployeeJobDataService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public EmployeeJobDataServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ImportEmployeeJobDataResponse ImportEmployeeJobData(
      ImportEmployeeJobData arg)
    {
      return Client.Post<ImportEmployeeJobData, ImportEmployeeJobDataResponse>(this.username, this.password, this.baseuri, "EmployeeJobDataService", arg);
    }

    public Task<ImportEmployeeJobDataResponse> ImportEmployeeJobDataAsync(
      ImportEmployeeJobData arg)
    {
      return Client.PostAsync<ImportEmployeeJobData, ImportEmployeeJobDataResponse>(this.username, this.password, this.baseuri, "EmployeeJobDataService", arg);
    }

    public ExportEmployeeJobDataResponse ExportEmployeeJobData(
      ExportEmployeeJobData arg)
    {
      return Client.Post<ExportEmployeeJobData, ExportEmployeeJobDataResponse>(this.username, this.password, this.baseuri, "EmployeeJobDataService", arg);
    }

    public Task<ExportEmployeeJobDataResponse> ExportEmployeeJobDataAsync(
      ExportEmployeeJobData arg)
    {
      return Client.PostAsync<ExportEmployeeJobData, ExportEmployeeJobDataResponse>(this.username, this.password, this.baseuri, "EmployeeJobDataService", arg);
    }

    public ExportEmployeeJobDataListResponse ExportEmployeeJobDataList(
      ExportEmployeeJobDataList arg)
    {
      return Client.Post<ExportEmployeeJobDataList, ExportEmployeeJobDataListResponse>(this.username, this.password, this.baseuri, "EmployeeJobDataService", arg);
    }

    public Task<ExportEmployeeJobDataListResponse> ExportEmployeeJobDataListAsync(
      ExportEmployeeJobDataList arg)
    {
      return Client.PostAsync<ExportEmployeeJobDataList, ExportEmployeeJobDataListResponse>(this.username, this.password, this.baseuri, "EmployeeJobDataService", arg);
    }
  }
}
