
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
    private readonly string baseuri;

    public EmployeeProfessionalDataServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ImportEmployeeProfessionalDataResponse ImportEmployeeProfessionalData(
      ImportEmployeeProfessionalData arg)
    {
      return Client.Post<ImportEmployeeProfessionalData, ImportEmployeeProfessionalDataResponse>(this.username, this.password, this.baseuri, "EmployeeProfessionalDataService", arg);
    }

    public Task<ImportEmployeeProfessionalDataResponse> ImportEmployeeProfessionalDataAsync(
      ImportEmployeeProfessionalData arg)
    {
      return Client.PostAsync<ImportEmployeeProfessionalData, ImportEmployeeProfessionalDataResponse>(this.username, this.password, this.baseuri, "EmployeeProfessionalDataService", arg);
    }

    public ExportEmployeeProfessionalDataResponse ExportEmployeeProfessionalData(
      ExportEmployeeProfessionalData arg)
    {
      return Client.Post<ExportEmployeeProfessionalData, ExportEmployeeProfessionalDataResponse>(this.username, this.password, this.baseuri, "EmployeeProfessionalDataService", arg);
    }

    public Task<ExportEmployeeProfessionalDataResponse> ExportEmployeeProfessionalDataAsync(
      ExportEmployeeProfessionalData arg)
    {
      return Client.PostAsync<ExportEmployeeProfessionalData, ExportEmployeeProfessionalDataResponse>(this.username, this.password, this.baseuri, "EmployeeProfessionalDataService", arg);
    }

    public ExportEmployeeProfessionalDataListResponse ExportEmployeeProfessionalDataList(
      ExportEmployeeProfessionalDataList arg)
    {
      return Client.Post<ExportEmployeeProfessionalDataList, ExportEmployeeProfessionalDataListResponse>(this.username, this.password, this.baseuri, "EmployeeProfessionalDataService", arg);
    }

    public Task<ExportEmployeeProfessionalDataListResponse> ExportEmployeeProfessionalDataListAsync(
      ExportEmployeeProfessionalDataList arg)
    {
      return Client.PostAsync<ExportEmployeeProfessionalDataList, ExportEmployeeProfessionalDataListResponse>(this.username, this.password, this.baseuri, "EmployeeProfessionalDataService", arg);
    }
  }
}
