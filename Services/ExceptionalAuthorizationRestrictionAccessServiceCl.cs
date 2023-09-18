
//.ExceptionalAuthorizationRestrictionAccessServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class ExceptionalAuthorizationRestrictionAccessServiceClient
  {
    private const string service = "ExceptionalAuthorizationRestrictionAccessService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public ExceptionalAuthorizationRestrictionAccessServiceClient(
      string username,
      string password,
      string baseuri, int timeoutSeconds = 60) 
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ExportExceptionalAuthorizationRestrictionAccessListResponse ExportExceptionalAuthorizationRestrictionAccessList(
      ExportExceptionalAuthorizationRestrictionAccessList arg)
    {
      return Client.Post<ExportExceptionalAuthorizationRestrictionAccessList, ExportExceptionalAuthorizationRestrictionAccessListResponse>(this.username, this.password, this.baseuri, "ExceptionalAuthorizationRestrictionAccessService", arg, this.timeoutSeconds);
    }

    public Task<ExportExceptionalAuthorizationRestrictionAccessListResponse> ExportExceptionalAuthorizationRestrictionAccessListAsync(
      ExportExceptionalAuthorizationRestrictionAccessList arg)
    {
      return Client.PostAsync<ExportExceptionalAuthorizationRestrictionAccessList, ExportExceptionalAuthorizationRestrictionAccessListResponse>(this.username, this.password, this.baseuri, "ExceptionalAuthorizationRestrictionAccessService", arg, this.timeoutSeconds);
    }

    public ImportExceptionalAuthorizationRestrictionAccessResponse ImportExceptionalAuthorizationRestrictionAccess(
      ImportExceptionalAuthorizationRestrictionAccess arg)
    {
      return Client.Post<ImportExceptionalAuthorizationRestrictionAccess, ImportExceptionalAuthorizationRestrictionAccessResponse>(this.username, this.password, this.baseuri, "ExceptionalAuthorizationRestrictionAccessService", arg, this.timeoutSeconds);
    }

    public Task<ImportExceptionalAuthorizationRestrictionAccessResponse> ImportExceptionalAuthorizationRestrictionAccessAsync(
      ImportExceptionalAuthorizationRestrictionAccess arg)
    {
      return Client.PostAsync<ImportExceptionalAuthorizationRestrictionAccess, ImportExceptionalAuthorizationRestrictionAccessResponse>(this.username, this.password, this.baseuri, "ExceptionalAuthorizationRestrictionAccessService", arg, this.timeoutSeconds);
    }

    public ExportExceptionalAuthorizationRestrictionAccessResponse ExportExceptionalAuthorizationRestrictionAccess(
      ExportExceptionalAuthorizationRestrictionAccess arg)
    {
      return Client.Post<ExportExceptionalAuthorizationRestrictionAccess, ExportExceptionalAuthorizationRestrictionAccessResponse>(this.username, this.password, this.baseuri, "ExceptionalAuthorizationRestrictionAccessService", arg, this.timeoutSeconds);
    }

    public Task<ExportExceptionalAuthorizationRestrictionAccessResponse> ExportExceptionalAuthorizationRestrictionAccessAsync(
      ExportExceptionalAuthorizationRestrictionAccess arg)
    {
      return Client.PostAsync<ExportExceptionalAuthorizationRestrictionAccess, ExportExceptionalAuthorizationRestrictionAccessResponse>(this.username, this.password, this.baseuri, "ExceptionalAuthorizationRestrictionAccessService", arg, this.timeoutSeconds);
    }

    public DeleteExceptionalAuthorizationRestrictionAccessResponse DeleteExceptionalAuthorizationRestrictionAccess(
      DeleteExceptionalAuthorizationRestrictionAccess arg)
    {
      return Client.Post<DeleteExceptionalAuthorizationRestrictionAccess, DeleteExceptionalAuthorizationRestrictionAccessResponse>(this.username, this.password, this.baseuri, "ExceptionalAuthorizationRestrictionAccessService", arg, this.timeoutSeconds);
    }

    public Task<DeleteExceptionalAuthorizationRestrictionAccessResponse> DeleteExceptionalAuthorizationRestrictionAccessAsync(
      DeleteExceptionalAuthorizationRestrictionAccess arg)
    {
      return Client.PostAsync<DeleteExceptionalAuthorizationRestrictionAccess, DeleteExceptionalAuthorizationRestrictionAccessResponse>(this.username, this.password, this.baseuri, "ExceptionalAuthorizationRestrictionAccessService", arg, this.timeoutSeconds);
    }
  }
}
