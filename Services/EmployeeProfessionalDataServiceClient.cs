
//.EmployeeProfessionalDataServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class EmployeeProfessionalDataServiceClient
  {
    private const string service = "EmployeeProfessionalDataService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public EmployeeProfessionalDataServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)  
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ImportEmployeeProfessionalDataResponse ImportEmployeeProfessionalData(
      ImportEmployeeProfessionalData arg)
    {
      return Client.Post<ImportEmployeeProfessionalData, ImportEmployeeProfessionalDataResponse>(this.username, this.password, this.baseuri, "EmployeeProfessionalDataService", arg, this.timeoutSeconds);
    }

    public Task<ImportEmployeeProfessionalDataResponse> ImportEmployeeProfessionalDataAsync(
      ImportEmployeeProfessionalData arg)
    {
      return Client.PostAsync<ImportEmployeeProfessionalData, ImportEmployeeProfessionalDataResponse>(this.username, this.password, this.baseuri, "EmployeeProfessionalDataService", arg, this.timeoutSeconds);
    }

    public ExportEmployeeProfessionalDataResponse ExportEmployeeProfessionalData(
      ExportEmployeeProfessionalData arg)
    {
      return Client.Post<ExportEmployeeProfessionalData, ExportEmployeeProfessionalDataResponse>(this.username, this.password, this.baseuri, "EmployeeProfessionalDataService", arg, this.timeoutSeconds);
    }

    public Task<ExportEmployeeProfessionalDataResponse> ExportEmployeeProfessionalDataAsync(
      ExportEmployeeProfessionalData arg)
    {
      return Client.PostAsync<ExportEmployeeProfessionalData, ExportEmployeeProfessionalDataResponse>(this.username, this.password, this.baseuri, "EmployeeProfessionalDataService", arg, this.timeoutSeconds);
    }

    public ExportEmployeeProfessionalDataListResponse ExportEmployeeProfessionalDataList(
      ExportEmployeeProfessionalDataList arg)
    {
      return Client.Post<ExportEmployeeProfessionalDataList, ExportEmployeeProfessionalDataListResponse>(this.username, this.password, this.baseuri, "EmployeeProfessionalDataService", arg, this.timeoutSeconds);
    }

    public Task<ExportEmployeeProfessionalDataListResponse> ExportEmployeeProfessionalDataListAsync(
      ExportEmployeeProfessionalDataList arg)
    {
      return Client.PostAsync<ExportEmployeeProfessionalDataList, ExportEmployeeProfessionalDataListResponse>(this.username, this.password, this.baseuri, "EmployeeProfessionalDataService", arg, this.timeoutSeconds);
    }
  }
}
