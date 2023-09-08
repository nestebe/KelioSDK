
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
    private readonly string baseuri;

    public ChildServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportChildrenResponse ExportChildren(ExportChildren arg)
    {
      return Client.Post<ExportChildren, ExportChildrenResponse>(this.username, this.password, this.baseuri, "ChildService", arg);
    }

    public Task<ExportChildrenResponse> ExportChildrenAsync(
      ExportChildren arg)
    {
      return Client.PostAsync<ExportChildren, ExportChildrenResponse>(this.username, this.password, this.baseuri, "ChildService", arg);
    }

    public ExportChildrenListResponse ExportChildrenList(
      ExportChildrenList arg)
    {
      return Client.Post<ExportChildrenList, ExportChildrenListResponse>(this.username, this.password, this.baseuri, "ChildService", arg);
    }

    public Task<ExportChildrenListResponse> ExportChildrenListAsync(
      ExportChildrenList arg)
    {
      return Client.PostAsync<ExportChildrenList, ExportChildrenListResponse>(this.username, this.password, this.baseuri, "ChildService", arg);
    }

    public ImportChildrenResponse ImportChildren(ImportChildren arg)
    {
      return Client.Post<ImportChildren, ImportChildrenResponse>(this.username, this.password, this.baseuri, "ChildService", arg);
    }

    public Task<ImportChildrenResponse> ImportChildrenAsync(
      ImportChildren arg)
    {
      return Client.PostAsync<ImportChildren, ImportChildrenResponse>(this.username, this.password, this.baseuri, "ChildService", arg);
    }
  }
}
