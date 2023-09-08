
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
    private readonly string baseuri;

    public AccountTypeAuthorizationServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportSpecialHourTypeAuthorizationsListResponse ExportSpecialHourTypeAuthorizationsList(
      ExportSpecialHourTypeAuthorizationsList arg)
    {
      return Client.Post<ExportSpecialHourTypeAuthorizationsList, ExportSpecialHourTypeAuthorizationsListResponse>(this.username, this.password, this.baseuri, "AccountTypeAuthorizationService", arg);
    }

    public Task<ExportSpecialHourTypeAuthorizationsListResponse> ExportSpecialHourTypeAuthorizationsListAsync(
      ExportSpecialHourTypeAuthorizationsList arg)
    {
      return Client.PostAsync<ExportSpecialHourTypeAuthorizationsList, ExportSpecialHourTypeAuthorizationsListResponse>(this.username, this.password, this.baseuri, "AccountTypeAuthorizationService", arg);
    }

    public ExportSpecialHourTypeAuthorizationsResponse ExportSpecialHourTypeAuthorizations(
      ExportSpecialHourTypeAuthorizations arg)
    {
      return Client.Post<ExportSpecialHourTypeAuthorizations, ExportSpecialHourTypeAuthorizationsResponse>(this.username, this.password, this.baseuri, "AccountTypeAuthorizationService", arg);
    }

    public Task<ExportSpecialHourTypeAuthorizationsResponse> ExportSpecialHourTypeAuthorizationsAsync(
      ExportSpecialHourTypeAuthorizations arg)
    {
      return Client.PostAsync<ExportSpecialHourTypeAuthorizations, ExportSpecialHourTypeAuthorizationsResponse>(this.username, this.password, this.baseuri, "AccountTypeAuthorizationService", arg);
    }

    public ImportOvertimeHourTypeAuthorizationsResponse ImportOvertimeHourTypeAuthorizations(
      ImportOvertimeHourTypeAuthorizations arg)
    {
      return Client.Post<ImportOvertimeHourTypeAuthorizations, ImportOvertimeHourTypeAuthorizationsResponse>(this.username, this.password, this.baseuri, "AccountTypeAuthorizationService", arg);
    }

    public Task<ImportOvertimeHourTypeAuthorizationsResponse> ImportOvertimeHourTypeAuthorizationsAsync(
      ImportOvertimeHourTypeAuthorizations arg)
    {
      return Client.PostAsync<ImportOvertimeHourTypeAuthorizations, ImportOvertimeHourTypeAuthorizationsResponse>(this.username, this.password, this.baseuri, "AccountTypeAuthorizationService", arg);
    }

    public DeleteSpecialHourTypeAuthorizationsResponse DeleteSpecialHourTypeAuthorizations(
      DeleteSpecialHourTypeAuthorizations arg)
    {
      return Client.Post<DeleteSpecialHourTypeAuthorizations, DeleteSpecialHourTypeAuthorizationsResponse>(this.username, this.password, this.baseuri, "AccountTypeAuthorizationService", arg);
    }

    public Task<DeleteSpecialHourTypeAuthorizationsResponse> DeleteSpecialHourTypeAuthorizationsAsync(
      DeleteSpecialHourTypeAuthorizations arg)
    {
      return Client.PostAsync<DeleteSpecialHourTypeAuthorizations, DeleteSpecialHourTypeAuthorizationsResponse>(this.username, this.password, this.baseuri, "AccountTypeAuthorizationService", arg);
    }

    public ExportOvertimeHourTypeAuthorizationsListResponse ExportOvertimeHourTypeAuthorizationsList(
      ExportOvertimeHourTypeAuthorizationsList arg)
    {
      return Client.Post<ExportOvertimeHourTypeAuthorizationsList, ExportOvertimeHourTypeAuthorizationsListResponse>(this.username, this.password, this.baseuri, "AccountTypeAuthorizationService", arg);
    }

    public Task<ExportOvertimeHourTypeAuthorizationsListResponse> ExportOvertimeHourTypeAuthorizationsListAsync(
      ExportOvertimeHourTypeAuthorizationsList arg)
    {
      return Client.PostAsync<ExportOvertimeHourTypeAuthorizationsList, ExportOvertimeHourTypeAuthorizationsListResponse>(this.username, this.password, this.baseuri, "AccountTypeAuthorizationService", arg);
    }

    public ExportOvertimeHourTypeAuthorizationsResponse ExportOvertimeHourTypeAuthorizations(
      ExportOvertimeHourTypeAuthorizations arg)
    {
      return Client.Post<ExportOvertimeHourTypeAuthorizations, ExportOvertimeHourTypeAuthorizationsResponse>(this.username, this.password, this.baseuri, "AccountTypeAuthorizationService", arg);
    }

    public Task<ExportOvertimeHourTypeAuthorizationsResponse> ExportOvertimeHourTypeAuthorizationsAsync(
      ExportOvertimeHourTypeAuthorizations arg)
    {
      return Client.PostAsync<ExportOvertimeHourTypeAuthorizations, ExportOvertimeHourTypeAuthorizationsResponse>(this.username, this.password, this.baseuri, "AccountTypeAuthorizationService", arg);
    }

    public ImportSpecialHourTypeAuthorizationsResponse ImportSpecialHourTypeAuthorizations(
      ImportSpecialHourTypeAuthorizations arg)
    {
      return Client.Post<ImportSpecialHourTypeAuthorizations, ImportSpecialHourTypeAuthorizationsResponse>(this.username, this.password, this.baseuri, "AccountTypeAuthorizationService", arg);
    }

    public Task<ImportSpecialHourTypeAuthorizationsResponse> ImportSpecialHourTypeAuthorizationsAsync(
      ImportSpecialHourTypeAuthorizations arg)
    {
      return Client.PostAsync<ImportSpecialHourTypeAuthorizations, ImportSpecialHourTypeAuthorizationsResponse>(this.username, this.password, this.baseuri, "AccountTypeAuthorizationService", arg);
    }

    public DeleteOvertimeHourTypeAuthorizationsResponse DeleteOvertimeHourTypeAuthorizations(
      DeleteOvertimeHourTypeAuthorizations arg)
    {
      return Client.Post<DeleteOvertimeHourTypeAuthorizations, DeleteOvertimeHourTypeAuthorizationsResponse>(this.username, this.password, this.baseuri, "AccountTypeAuthorizationService", arg);
    }

    public Task<DeleteOvertimeHourTypeAuthorizationsResponse> DeleteOvertimeHourTypeAuthorizationsAsync(
      DeleteOvertimeHourTypeAuthorizations arg)
    {
      return Client.PostAsync<DeleteOvertimeHourTypeAuthorizations, DeleteOvertimeHourTypeAuthorizationsResponse>(this.username, this.password, this.baseuri, "AccountTypeAuthorizationService", arg);
    }

    public ExportBonusTypeAuthorizationsResponse ExportBonusTypeAuthorizations(
      ExportBonusTypeAuthorizations arg)
    {
      return Client.Post<ExportBonusTypeAuthorizations, ExportBonusTypeAuthorizationsResponse>(this.username, this.password, this.baseuri, "AccountTypeAuthorizationService", arg);
    }

    public Task<ExportBonusTypeAuthorizationsResponse> ExportBonusTypeAuthorizationsAsync(
      ExportBonusTypeAuthorizations arg)
    {
      return Client.PostAsync<ExportBonusTypeAuthorizations, ExportBonusTypeAuthorizationsResponse>(this.username, this.password, this.baseuri, "AccountTypeAuthorizationService", arg);
    }

    public ExportBonusTypeAuthorizationsListResponse ExportBonusTypeAuthorizationsList(
      ExportBonusTypeAuthorizationsList arg)
    {
      return Client.Post<ExportBonusTypeAuthorizationsList, ExportBonusTypeAuthorizationsListResponse>(this.username, this.password, this.baseuri, "AccountTypeAuthorizationService", arg);
    }

    public Task<ExportBonusTypeAuthorizationsListResponse> ExportBonusTypeAuthorizationsListAsync(
      ExportBonusTypeAuthorizationsList arg)
    {
      return Client.PostAsync<ExportBonusTypeAuthorizationsList, ExportBonusTypeAuthorizationsListResponse>(this.username, this.password, this.baseuri, "AccountTypeAuthorizationService", arg);
    }

    public ImportBonusTypeAuthorizationsResponse ImportBonusTypeAuthorizations(
      ImportBonusTypeAuthorizations arg)
    {
      return Client.Post<ImportBonusTypeAuthorizations, ImportBonusTypeAuthorizationsResponse>(this.username, this.password, this.baseuri, "AccountTypeAuthorizationService", arg);
    }

    public Task<ImportBonusTypeAuthorizationsResponse> ImportBonusTypeAuthorizationsAsync(
      ImportBonusTypeAuthorizations arg)
    {
      return Client.PostAsync<ImportBonusTypeAuthorizations, ImportBonusTypeAuthorizationsResponse>(this.username, this.password, this.baseuri, "AccountTypeAuthorizationService", arg);
    }

    public DeleteBonusTypeAuthorizationsResponse DeleteBonusTypeAuthorizations(
      DeleteBonusTypeAuthorizations arg)
    {
      return Client.Post<DeleteBonusTypeAuthorizations, DeleteBonusTypeAuthorizationsResponse>(this.username, this.password, this.baseuri, "AccountTypeAuthorizationService", arg);
    }

    public Task<DeleteBonusTypeAuthorizationsResponse> DeleteBonusTypeAuthorizationsAsync(
      DeleteBonusTypeAuthorizations arg)
    {
      return Client.PostAsync<DeleteBonusTypeAuthorizations, DeleteBonusTypeAuthorizationsResponse>(this.username, this.password, this.baseuri, "AccountTypeAuthorizationService", arg);
    }
  }
}
