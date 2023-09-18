
//.EmployeeTrainingAndCareerDataServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class EmployeeTrainingAndCareerDataServiceClient
  {
    private const string service = "EmployeeTrainingAndCareerDataService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public EmployeeTrainingAndCareerDataServiceClient(
      string username,
      string password,
      string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ImportEmployeeTrainingAndCareerDataResponse ImportEmployeeTrainingAndCareerData(
      ImportEmployeeTrainingAndCareerData arg)
    {
      return Client.Post<ImportEmployeeTrainingAndCareerData, ImportEmployeeTrainingAndCareerDataResponse>(this.username, this.password, this.baseuri, "EmployeeTrainingAndCareerDataService", arg, this.timeoutSeconds);
    }

    public Task<ImportEmployeeTrainingAndCareerDataResponse> ImportEmployeeTrainingAndCareerDataAsync(
      ImportEmployeeTrainingAndCareerData arg)
    {
      return Client.PostAsync<ImportEmployeeTrainingAndCareerData, ImportEmployeeTrainingAndCareerDataResponse>(this.username, this.password, this.baseuri, "EmployeeTrainingAndCareerDataService", arg, this.timeoutSeconds);
    }

    public ExportEmployeeTrainingAndCareerDataResponse ExportEmployeeTrainingAndCareerData(
      ExportEmployeeTrainingAndCareerData arg)
    {
      return Client.Post<ExportEmployeeTrainingAndCareerData, ExportEmployeeTrainingAndCareerDataResponse>(this.username, this.password, this.baseuri, "EmployeeTrainingAndCareerDataService", arg, this.timeoutSeconds);
    }

    public Task<ExportEmployeeTrainingAndCareerDataResponse> ExportEmployeeTrainingAndCareerDataAsync(
      ExportEmployeeTrainingAndCareerData arg)
    {
      return Client.PostAsync<ExportEmployeeTrainingAndCareerData, ExportEmployeeTrainingAndCareerDataResponse>(this.username, this.password, this.baseuri, "EmployeeTrainingAndCareerDataService", arg, this.timeoutSeconds);
    }

    public ExportEmployeeTrainingAndCareerDataListResponse ExportEmployeeTrainingAndCareerDataList(
      ExportEmployeeTrainingAndCareerDataList arg)
    {
      return Client.Post<ExportEmployeeTrainingAndCareerDataList, ExportEmployeeTrainingAndCareerDataListResponse>(this.username, this.password, this.baseuri, "EmployeeTrainingAndCareerDataService", arg, this.timeoutSeconds);
    }

    public Task<ExportEmployeeTrainingAndCareerDataListResponse> ExportEmployeeTrainingAndCareerDataListAsync(
      ExportEmployeeTrainingAndCareerDataList arg)
    {
      return Client.PostAsync<ExportEmployeeTrainingAndCareerDataList, ExportEmployeeTrainingAndCareerDataListResponse>(this.username, this.password, this.baseuri, "EmployeeTrainingAndCareerDataService", arg, this.timeoutSeconds);
    }
  }
}
