
//.HourlyContractServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class HourlyContractServiceClient
  {
    private const string service = "HourlyContractService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public HourlyContractServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public DeleteHourlyContractResponse DeleteHourlyContract(
      DeleteHourlyContract arg)
    {
      return Client.Post<DeleteHourlyContract, DeleteHourlyContractResponse>(this.username, this.password, this.baseuri, "HourlyContractService", arg);
    }

    public Task<DeleteHourlyContractResponse> DeleteHourlyContractAsync(
      DeleteHourlyContract arg)
    {
      return Client.PostAsync<DeleteHourlyContract, DeleteHourlyContractResponse>(this.username, this.password, this.baseuri, "HourlyContractService", arg);
    }

    public ExportHourlyContractResponse ExportHourlyContract(
      ExportHourlyContract arg)
    {
      return Client.Post<ExportHourlyContract, ExportHourlyContractResponse>(this.username, this.password, this.baseuri, "HourlyContractService", arg);
    }

    public Task<ExportHourlyContractResponse> ExportHourlyContractAsync(
      ExportHourlyContract arg)
    {
      return Client.PostAsync<ExportHourlyContract, ExportHourlyContractResponse>(this.username, this.password, this.baseuri, "HourlyContractService", arg);
    }

    public ImportHourlyContractResponse ImportHourlyContract(
      ImportHourlyContract arg)
    {
      return Client.Post<ImportHourlyContract, ImportHourlyContractResponse>(this.username, this.password, this.baseuri, "HourlyContractService", arg);
    }

    public Task<ImportHourlyContractResponse> ImportHourlyContractAsync(
      ImportHourlyContract arg)
    {
      return Client.PostAsync<ImportHourlyContract, ImportHourlyContractResponse>(this.username, this.password, this.baseuri, "HourlyContractService", arg);
    }
  }
}
