
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
    private readonly string baseuri; private readonly int timeoutSeconds;

    public ClearingServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ExportClearingResponse ExportClearing(ExportClearing arg)
    {
      return Client.Post<ExportClearing, ExportClearingResponse>(this.username, this.password, this.baseuri, "ClearingService", arg, this.timeoutSeconds);
    }

    public Task<ExportClearingResponse> ExportClearingAsync(
      ExportClearing arg)
    {
      return Client.PostAsync<ExportClearing, ExportClearingResponse>(this.username, this.password, this.baseuri, "ClearingService", arg, this.timeoutSeconds);
    }

    public ImportClearingResponse ImportClearing(ImportClearing arg)
    {
      return Client.Post<ImportClearing, ImportClearingResponse>(this.username, this.password, this.baseuri, "ClearingService", arg, this.timeoutSeconds);
    }

    public Task<ImportClearingResponse> ImportClearingAsync(
      ImportClearing arg)
    {
      return Client.PostAsync<ImportClearing, ImportClearingResponse>(this.username, this.password, this.baseuri, "ClearingService", arg, this.timeoutSeconds);
    }
  }
}
