
//.ClearingServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class ClearingServiceClient
  {
    private const string service = "ClearingService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public ClearingServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportClearingResponse ExportClearing(ExportClearing arg)
    {
      return Client.Post<ExportClearing, ExportClearingResponse>(this.username, this.password, this.baseuri, "ClearingService", arg);
    }

    public Task<ExportClearingResponse> ExportClearingAsync(
      ExportClearing arg)
    {
      return Client.PostAsync<ExportClearing, ExportClearingResponse>(this.username, this.password, this.baseuri, "ClearingService", arg);
    }

    public ImportClearingResponse ImportClearing(ImportClearing arg)
    {
      return Client.Post<ImportClearing, ImportClearingResponse>(this.username, this.password, this.baseuri, "ClearingService", arg);
    }

    public Task<ImportClearingResponse> ImportClearingAsync(
      ImportClearing arg)
    {
      return Client.PostAsync<ImportClearing, ImportClearingResponse>(this.username, this.password, this.baseuri, "ClearingService", arg);
    }
  }
}
