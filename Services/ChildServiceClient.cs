
//.ChildServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class ChildServiceClient
  {
    private const string service = "ChildService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public ChildServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ExportChildrenResponse ExportChildren(ExportChildren arg)
    {
      return Client.Post<ExportChildren, ExportChildrenResponse>(this.username, this.password, this.baseuri, "ChildService", arg, this.timeoutSeconds);
    }

    public Task<ExportChildrenResponse> ExportChildrenAsync(
      ExportChildren arg)
    {
      return Client.PostAsync<ExportChildren, ExportChildrenResponse>(this.username, this.password, this.baseuri, "ChildService", arg, this.timeoutSeconds);
    }

    public ExportChildrenListResponse ExportChildrenList(
      ExportChildrenList arg)
    {
      return Client.Post<ExportChildrenList, ExportChildrenListResponse>(this.username, this.password, this.baseuri, "ChildService", arg, this.timeoutSeconds);
    }

    public Task<ExportChildrenListResponse> ExportChildrenListAsync(
      ExportChildrenList arg)
    {
      return Client.PostAsync<ExportChildrenList, ExportChildrenListResponse>(this.username, this.password, this.baseuri, "ChildService", arg, this.timeoutSeconds);
    }

    public ImportChildrenResponse ImportChildren(ImportChildren arg)
    {
      return Client.Post<ImportChildren, ImportChildrenResponse>(this.username, this.password, this.baseuri, "ChildService", arg, this.timeoutSeconds);
    }

    public Task<ImportChildrenResponse> ImportChildrenAsync(
      ImportChildren arg)
    {
      return Client.PostAsync<ImportChildren, ImportChildrenResponse>(this.username, this.password, this.baseuri, "ChildService", arg, this.timeoutSeconds);
    }
  }
}
