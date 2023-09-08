
//.ReaderGroupServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class ReaderGroupServiceClient
  {
    private const string service = "ReaderGroupService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public ReaderGroupServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportReaderGroupContentsResponse ExportReaderGroupContents(
      ExportReaderGroupContents arg)
    {
      return Client.Post<ExportReaderGroupContents, ExportReaderGroupContentsResponse>(this.username, this.password, this.baseuri, "ReaderGroupService", arg);
    }

    public Task<ExportReaderGroupContentsResponse> ExportReaderGroupContentsAsync(
      ExportReaderGroupContents arg)
    {
      return Client.PostAsync<ExportReaderGroupContents, ExportReaderGroupContentsResponse>(this.username, this.password, this.baseuri, "ReaderGroupService", arg);
    }

    public ImportReaderGroupsResponse ImportReaderGroups(
      ImportReaderGroups arg)
    {
      return Client.Post<ImportReaderGroups, ImportReaderGroupsResponse>(this.username, this.password, this.baseuri, "ReaderGroupService", arg);
    }

    public Task<ImportReaderGroupsResponse> ImportReaderGroupsAsync(
      ImportReaderGroups arg)
    {
      return Client.PostAsync<ImportReaderGroups, ImportReaderGroupsResponse>(this.username, this.password, this.baseuri, "ReaderGroupService", arg);
    }
  }
}
