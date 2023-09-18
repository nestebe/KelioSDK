
//.TransferFileServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class TransferFileServiceClient
  {
    private const string service = "TransferFileService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public TransferFileServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ExportBalanceInitializationsResponse ExportBalanceInitializations(
      ExportBalanceInitializations arg)
    {
      return Client.Post<ExportBalanceInitializations, ExportBalanceInitializationsResponse>(this.username, this.password, this.baseuri, "TransferFileService", arg, this.timeoutSeconds);
    }

    public Task<ExportBalanceInitializationsResponse> ExportBalanceInitializationsAsync(
      ExportBalanceInitializations arg)
    {
      return Client.PostAsync<ExportBalanceInitializations, ExportBalanceInitializationsResponse>(this.username, this.password, this.baseuri, "TransferFileService", arg, this.timeoutSeconds);
    }

    public ImportBalanceInitializationsResponse ImportBalanceInitializations(
      ImportBalanceInitializations arg)
    {
      return Client.Post<ImportBalanceInitializations, ImportBalanceInitializationsResponse>(this.username, this.password, this.baseuri, "TransferFileService", arg, this.timeoutSeconds);
    }

    public Task<ImportBalanceInitializationsResponse> ImportBalanceInitializationsAsync(
      ImportBalanceInitializations arg)
    {
      return Client.PostAsync<ImportBalanceInitializations, ImportBalanceInitializationsResponse>(this.username, this.password, this.baseuri, "TransferFileService", arg, this.timeoutSeconds);
    }

    public ImportAccountInitializationsResponse ImportAccountInitializations(
      ImportAccountInitializations arg)
    {
      return Client.Post<ImportAccountInitializations, ImportAccountInitializationsResponse>(this.username, this.password, this.baseuri, "TransferFileService", arg, this.timeoutSeconds);
    }

    public Task<ImportAccountInitializationsResponse> ImportAccountInitializationsAsync(
      ImportAccountInitializations arg)
    {
      return Client.PostAsync<ImportAccountInitializations, ImportAccountInitializationsResponse>(this.username, this.password, this.baseuri, "TransferFileService", arg, this.timeoutSeconds);
    }

    public ExportAccountInitializationsResponse ExportAccountInitializations(
      ExportAccountInitializations arg)
    {
      return Client.Post<ExportAccountInitializations, ExportAccountInitializationsResponse>(this.username, this.password, this.baseuri, "TransferFileService", arg, this.timeoutSeconds);
    }

    public Task<ExportAccountInitializationsResponse> ExportAccountInitializationsAsync(
      ExportAccountInitializations arg)
    {
      return Client.PostAsync<ExportAccountInitializations, ExportAccountInitializationsResponse>(this.username, this.password, this.baseuri, "TransferFileService", arg, this.timeoutSeconds);
    }

    public ExportAddDeductsListResponse ExportAddDeductsList(
      ExportAddDeductsList arg)
    {
      return Client.Post<ExportAddDeductsList, ExportAddDeductsListResponse>(this.username, this.password, this.baseuri, "TransferFileService", arg, this.timeoutSeconds);
    }

    public Task<ExportAddDeductsListResponse> ExportAddDeductsListAsync(
      ExportAddDeductsList arg)
    {
      return Client.PostAsync<ExportAddDeductsList, ExportAddDeductsListResponse>(this.username, this.password, this.baseuri, "TransferFileService", arg, this.timeoutSeconds);
    }

    public ExportAddDeductsResponse ExportAddDeducts(ExportAddDeducts arg)
    {
      return Client.Post<ExportAddDeducts, ExportAddDeductsResponse>(this.username, this.password, this.baseuri, "TransferFileService", arg, this.timeoutSeconds);
    }

    public Task<ExportAddDeductsResponse> ExportAddDeductsAsync(
      ExportAddDeducts arg)
    {
      return Client.PostAsync<ExportAddDeducts, ExportAddDeductsResponse>(this.username, this.password, this.baseuri, "TransferFileService", arg, this.timeoutSeconds);
    }

    public ImportAddDeductsResponse ImportAddDeducts(ImportAddDeducts arg)
    {
      return Client.Post<ImportAddDeducts, ImportAddDeductsResponse>(this.username, this.password, this.baseuri, "TransferFileService", arg, this.timeoutSeconds);
    }

    public Task<ImportAddDeductsResponse> ImportAddDeductsAsync(
      ImportAddDeducts arg)
    {
      return Client.PostAsync<ImportAddDeducts, ImportAddDeductsResponse>(this.username, this.password, this.baseuri, "TransferFileService", arg, this.timeoutSeconds);
    }
  }
}
