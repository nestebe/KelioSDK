
//.AccessProfileServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class AccessProfileServiceClient
  {
    private const string service = "AccessProfileService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public AccessProfileServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportAccessProfilesResponse ExportAccessProfiles(
      ExportAccessProfiles arg)
    {
      return Client.Post<ExportAccessProfiles, ExportAccessProfilesResponse>(this.username, this.password, this.baseuri, "AccessProfileService", arg);
    }

    public Task<ExportAccessProfilesResponse> ExportAccessProfilesAsync(
      ExportAccessProfiles arg)
    {
      return Client.PostAsync<ExportAccessProfiles, ExportAccessProfilesResponse>(this.username, this.password, this.baseuri, "AccessProfileService", arg);
    }

    public ImportAccessProfilesResponse ImportAccessProfiles(
      ImportAccessProfiles arg)
    {
      return Client.Post<ImportAccessProfiles, ImportAccessProfilesResponse>(this.username, this.password, this.baseuri, "AccessProfileService", arg);
    }

    public Task<ImportAccessProfilesResponse> ImportAccessProfilesAsync(
      ImportAccessProfiles arg)
    {
      return Client.PostAsync<ImportAccessProfiles, ImportAccessProfilesResponse>(this.username, this.password, this.baseuri, "AccessProfileService", arg);
    }
  }
}
