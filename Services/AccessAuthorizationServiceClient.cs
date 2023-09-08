
//.AccessAuthorizationServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class AccessAuthorizationServiceClient
  {
    private const string service = "AccessAuthorizationService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public AccessAuthorizationServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportAccessAuthorizationListResponse ExportAccessAuthorizationList(
      ExportAccessAuthorizationList arg)
    {
      return Client.Post<ExportAccessAuthorizationList, ExportAccessAuthorizationListResponse>(this.username, this.password, this.baseuri, "AccessAuthorizationService", arg);
    }

    public Task<ExportAccessAuthorizationListResponse> ExportAccessAuthorizationListAsync(
      ExportAccessAuthorizationList arg)
    {
      return Client.PostAsync<ExportAccessAuthorizationList, ExportAccessAuthorizationListResponse>(this.username, this.password, this.baseuri, "AccessAuthorizationService", arg);
    }

    public ExportAccessAuthorizationResponse ExportAccessAuthorization(
      ExportAccessAuthorization arg)
    {
      return Client.Post<ExportAccessAuthorization, ExportAccessAuthorizationResponse>(this.username, this.password, this.baseuri, "AccessAuthorizationService", arg);
    }

    public Task<ExportAccessAuthorizationResponse> ExportAccessAuthorizationAsync(
      ExportAccessAuthorization arg)
    {
      return Client.PostAsync<ExportAccessAuthorization, ExportAccessAuthorizationResponse>(this.username, this.password, this.baseuri, "AccessAuthorizationService", arg);
    }

    public ImportAccessAuthorizationResponse ImportAccessAuthorization(
      ImportAccessAuthorization arg)
    {
      return Client.Post<ImportAccessAuthorization, ImportAccessAuthorizationResponse>(this.username, this.password, this.baseuri, "AccessAuthorizationService", arg);
    }

    public Task<ImportAccessAuthorizationResponse> ImportAccessAuthorizationAsync(
      ImportAccessAuthorization arg)
    {
      return Client.PostAsync<ImportAccessAuthorization, ImportAccessAuthorizationResponse>(this.username, this.password, this.baseuri, "AccessAuthorizationService", arg);
    }

    public DeleteAccessAuthorizationResponse DeleteAccessAuthorization(
      DeleteAccessAuthorization arg)
    {
      return Client.Post<DeleteAccessAuthorization, DeleteAccessAuthorizationResponse>(this.username, this.password, this.baseuri, "AccessAuthorizationService", arg);
    }

    public Task<DeleteAccessAuthorizationResponse> DeleteAccessAuthorizationAsync(
      DeleteAccessAuthorization arg)
    {
      return Client.PostAsync<DeleteAccessAuthorization, DeleteAccessAuthorizationResponse>(this.username, this.password, this.baseuri, "AccessAuthorizationService", arg);
    }
  }
}
