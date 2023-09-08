
//.EmployeeTrainingHistoryServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class EmployeeTrainingHistoryServiceClient
  {
    private const string service = "EmployeeTrainingHistoryService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public EmployeeTrainingHistoryServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportEmployeeTrainingHistoryResponse ExportEmployeeTrainingHistory(
      ExportEmployeeTrainingHistory arg)
    {
      return Client.Post<ExportEmployeeTrainingHistory, ExportEmployeeTrainingHistoryResponse>(this.username, this.password, this.baseuri, "EmployeeTrainingHistoryService", arg);
    }

    public Task<ExportEmployeeTrainingHistoryResponse> ExportEmployeeTrainingHistoryAsync(
      ExportEmployeeTrainingHistory arg)
    {
      return Client.PostAsync<ExportEmployeeTrainingHistory, ExportEmployeeTrainingHistoryResponse>(this.username, this.password, this.baseuri, "EmployeeTrainingHistoryService", arg);
    }

    public ImportEmployeeTrainingHistoryResponse ImportEmployeeTrainingHistory(
      ImportEmployeeTrainingHistory arg)
    {
      return Client.Post<ImportEmployeeTrainingHistory, ImportEmployeeTrainingHistoryResponse>(this.username, this.password, this.baseuri, "EmployeeTrainingHistoryService", arg);
    }

    public Task<ImportEmployeeTrainingHistoryResponse> ImportEmployeeTrainingHistoryAsync(
      ImportEmployeeTrainingHistory arg)
    {
      return Client.PostAsync<ImportEmployeeTrainingHistory, ImportEmployeeTrainingHistoryResponse>(this.username, this.password, this.baseuri, "EmployeeTrainingHistoryService", arg);
    }
  }
}
