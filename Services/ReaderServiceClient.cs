
//.ReaderServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class ReaderServiceClient
  {
    private const string service = "ReaderService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public ReaderServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportReadersResponse ExportReaders(ExportReaders arg)
    {
      return Client.Post<ExportReaders, ExportReadersResponse>(this.username, this.password, this.baseuri, "ReaderService", arg);
    }

    public Task<ExportReadersResponse> ExportReadersAsync(ExportReaders arg)
    {
      return Client.PostAsync<ExportReaders, ExportReadersResponse>(this.username, this.password, this.baseuri, "ReaderService", arg);
    }
  }
}
