
//.AccountTypeAuthorizationServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class AccountTypeAuthorizationServiceClient
  {
    private const string service = "AccountTypeAuthorizationService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public AccountTypeAuthorizationServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ExportSpecialHourTypeAuthorizationsListResponse ExportSpecialHourTypeAuthorizationsList(
      ExportSpecialHourTypeAuthorizationsList arg)
    {
      return Client.Post<ExportSpecialHourTypeAuthorizationsList, ExportSpecialHourTypeAuthorizationsListResponse>(this.username, this.password, this.baseuri, "AccountTypeAuthorizationService", arg, this.timeoutSeconds);
    }

    public Task<ExportSpecialHourTypeAuthorizationsListResponse> ExportSpecialHourTypeAuthorizationsListAsync(
      ExportSpecialHourTypeAuthorizationsList arg)
    {
      return Client.PostAsync<ExportSpecialHourTypeAuthorizationsList, ExportSpecialHourTypeAuthorizationsListResponse>(this.username, this.password, this.baseuri, "AccountTypeAuthorizationService", arg, this.timeoutSeconds);
    }

    public ExportSpecialHourTypeAuthorizationsResponse ExportSpecialHourTypeAuthorizations(
      ExportSpecialHourTypeAuthorizations arg)
    {
      return Client.Post<ExportSpecialHourTypeAuthorizations, ExportSpecialHourTypeAuthorizationsResponse>(this.username, this.password, this.baseuri, "AccountTypeAuthorizationService", arg, this.timeoutSeconds);
    }

    public Task<ExportSpecialHourTypeAuthorizationsResponse> ExportSpecialHourTypeAuthorizationsAsync(
      ExportSpecialHourTypeAuthorizations arg)
    {
      return Client.PostAsync<ExportSpecialHourTypeAuthorizations, ExportSpecialHourTypeAuthorizationsResponse>(this.username, this.password, this.baseuri, "AccountTypeAuthorizationService", arg, this.timeoutSeconds);
    }

    public ImportOvertimeHourTypeAuthorizationsResponse ImportOvertimeHourTypeAuthorizations(
      ImportOvertimeHourTypeAuthorizations arg)
    {
      return Client.Post<ImportOvertimeHourTypeAuthorizations, ImportOvertimeHourTypeAuthorizationsResponse>(this.username, this.password, this.baseuri, "AccountTypeAuthorizationService", arg, this.timeoutSeconds);
    }

    public Task<ImportOvertimeHourTypeAuthorizationsResponse> ImportOvertimeHourTypeAuthorizationsAsync(
      ImportOvertimeHourTypeAuthorizations arg)
    {
      return Client.PostAsync<ImportOvertimeHourTypeAuthorizations, ImportOvertimeHourTypeAuthorizationsResponse>(this.username, this.password, this.baseuri, "AccountTypeAuthorizationService", arg, this.timeoutSeconds);
    }

    public DeleteSpecialHourTypeAuthorizationsResponse DeleteSpecialHourTypeAuthorizations(
      DeleteSpecialHourTypeAuthorizations arg)
    {
      return Client.Post<DeleteSpecialHourTypeAuthorizations, DeleteSpecialHourTypeAuthorizationsResponse>(this.username, this.password, this.baseuri, "AccountTypeAuthorizationService", arg, this.timeoutSeconds);
    }

    public Task<DeleteSpecialHourTypeAuthorizationsResponse> DeleteSpecialHourTypeAuthorizationsAsync(
      DeleteSpecialHourTypeAuthorizations arg)
    {
      return Client.PostAsync<DeleteSpecialHourTypeAuthorizations, DeleteSpecialHourTypeAuthorizationsResponse>(this.username, this.password, this.baseuri, "AccountTypeAuthorizationService", arg, this.timeoutSeconds);
    }

    public ExportOvertimeHourTypeAuthorizationsListResponse ExportOvertimeHourTypeAuthorizationsList(
      ExportOvertimeHourTypeAuthorizationsList arg)
    {
      return Client.Post<ExportOvertimeHourTypeAuthorizationsList, ExportOvertimeHourTypeAuthorizationsListResponse>(this.username, this.password, this.baseuri, "AccountTypeAuthorizationService", arg, this.timeoutSeconds);
    }

    public Task<ExportOvertimeHourTypeAuthorizationsListResponse> ExportOvertimeHourTypeAuthorizationsListAsync(
      ExportOvertimeHourTypeAuthorizationsList arg)
    {
      return Client.PostAsync<ExportOvertimeHourTypeAuthorizationsList, ExportOvertimeHourTypeAuthorizationsListResponse>(this.username, this.password, this.baseuri, "AccountTypeAuthorizationService", arg, this.timeoutSeconds);
    }

    public ExportOvertimeHourTypeAuthorizationsResponse ExportOvertimeHourTypeAuthorizations(
      ExportOvertimeHourTypeAuthorizations arg)
    {
      return Client.Post<ExportOvertimeHourTypeAuthorizations, ExportOvertimeHourTypeAuthorizationsResponse>(this.username, this.password, this.baseuri, "AccountTypeAuthorizationService", arg, this.timeoutSeconds);
    }

    public Task<ExportOvertimeHourTypeAuthorizationsResponse> ExportOvertimeHourTypeAuthorizationsAsync(
      ExportOvertimeHourTypeAuthorizations arg)
    {
      return Client.PostAsync<ExportOvertimeHourTypeAuthorizations, ExportOvertimeHourTypeAuthorizationsResponse>(this.username, this.password, this.baseuri, "AccountTypeAuthorizationService", arg, this.timeoutSeconds);
    }

    public ImportSpecialHourTypeAuthorizationsResponse ImportSpecialHourTypeAuthorizations(
      ImportSpecialHourTypeAuthorizations arg)
    {
      return Client.Post<ImportSpecialHourTypeAuthorizations, ImportSpecialHourTypeAuthorizationsResponse>(this.username, this.password, this.baseuri, "AccountTypeAuthorizationService", arg, this.timeoutSeconds);
    }

    public Task<ImportSpecialHourTypeAuthorizationsResponse> ImportSpecialHourTypeAuthorizationsAsync(
      ImportSpecialHourTypeAuthorizations arg)
    {
      return Client.PostAsync<ImportSpecialHourTypeAuthorizations, ImportSpecialHourTypeAuthorizationsResponse>(this.username, this.password, this.baseuri, "AccountTypeAuthorizationService", arg, this.timeoutSeconds);
    }

    public DeleteOvertimeHourTypeAuthorizationsResponse DeleteOvertimeHourTypeAuthorizations(
      DeleteOvertimeHourTypeAuthorizations arg)
    {
      return Client.Post<DeleteOvertimeHourTypeAuthorizations, DeleteOvertimeHourTypeAuthorizationsResponse>(this.username, this.password, this.baseuri, "AccountTypeAuthorizationService", arg, this.timeoutSeconds);
    }

    public Task<DeleteOvertimeHourTypeAuthorizationsResponse> DeleteOvertimeHourTypeAuthorizationsAsync(
      DeleteOvertimeHourTypeAuthorizations arg)
    {
      return Client.PostAsync<DeleteOvertimeHourTypeAuthorizations, DeleteOvertimeHourTypeAuthorizationsResponse>(this.username, this.password, this.baseuri, "AccountTypeAuthorizationService", arg, this.timeoutSeconds);
    }

    public ExportBonusTypeAuthorizationsResponse ExportBonusTypeAuthorizations(
      ExportBonusTypeAuthorizations arg)
    {
      return Client.Post<ExportBonusTypeAuthorizations, ExportBonusTypeAuthorizationsResponse>(this.username, this.password, this.baseuri, "AccountTypeAuthorizationService", arg, this.timeoutSeconds);
    }

    public Task<ExportBonusTypeAuthorizationsResponse> ExportBonusTypeAuthorizationsAsync(
      ExportBonusTypeAuthorizations arg)
    {
      return Client.PostAsync<ExportBonusTypeAuthorizations, ExportBonusTypeAuthorizationsResponse>(this.username, this.password, this.baseuri, "AccountTypeAuthorizationService", arg, this.timeoutSeconds);
    }

    public ExportBonusTypeAuthorizationsListResponse ExportBonusTypeAuthorizationsList(
      ExportBonusTypeAuthorizationsList arg)
    {
      return Client.Post<ExportBonusTypeAuthorizationsList, ExportBonusTypeAuthorizationsListResponse>(this.username, this.password, this.baseuri, "AccountTypeAuthorizationService", arg, this.timeoutSeconds);
    }

    public Task<ExportBonusTypeAuthorizationsListResponse> ExportBonusTypeAuthorizationsListAsync(
      ExportBonusTypeAuthorizationsList arg)
    {
      return Client.PostAsync<ExportBonusTypeAuthorizationsList, ExportBonusTypeAuthorizationsListResponse>(this.username, this.password, this.baseuri, "AccountTypeAuthorizationService", arg, this.timeoutSeconds);
    }

    public ImportBonusTypeAuthorizationsResponse ImportBonusTypeAuthorizations(
      ImportBonusTypeAuthorizations arg)
    {
      return Client.Post<ImportBonusTypeAuthorizations, ImportBonusTypeAuthorizationsResponse>(this.username, this.password, this.baseuri, "AccountTypeAuthorizationService", arg, this.timeoutSeconds);
    }

    public Task<ImportBonusTypeAuthorizationsResponse> ImportBonusTypeAuthorizationsAsync(
      ImportBonusTypeAuthorizations arg)
    {
      return Client.PostAsync<ImportBonusTypeAuthorizations, ImportBonusTypeAuthorizationsResponse>(this.username, this.password, this.baseuri, "AccountTypeAuthorizationService", arg, this.timeoutSeconds);
    }

    public DeleteBonusTypeAuthorizationsResponse DeleteBonusTypeAuthorizations(
      DeleteBonusTypeAuthorizations arg)
    {
      return Client.Post<DeleteBonusTypeAuthorizations, DeleteBonusTypeAuthorizationsResponse>(this.username, this.password, this.baseuri, "AccountTypeAuthorizationService", arg, this.timeoutSeconds);
    }

    public Task<DeleteBonusTypeAuthorizationsResponse> DeleteBonusTypeAuthorizationsAsync(
      DeleteBonusTypeAuthorizations arg)
    {
      return Client.PostAsync<DeleteBonusTypeAuthorizations, DeleteBonusTypeAuthorizationsResponse>(this.username, this.password, this.baseuri, "AccountTypeAuthorizationService", arg, this.timeoutSeconds);
    }
  }
}
