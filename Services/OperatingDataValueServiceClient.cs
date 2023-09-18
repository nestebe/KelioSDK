
//.OperatingDataValueServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class OperatingDataValueServiceClient
  {
    private const string service = "OperatingDataValueService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public OperatingDataValueServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ExportOperatingDataValueResponse ExportOperatingDataValue(
      ExportOperatingDataValue arg)
    {
      return Client.Post<ExportOperatingDataValue, ExportOperatingDataValueResponse>(this.username, this.password, this.baseuri, "OperatingDataValueService", arg, this.timeoutSeconds);
    }

    public Task<ExportOperatingDataValueResponse> ExportOperatingDataValueAsync(
      ExportOperatingDataValue arg)
    {
      return Client.PostAsync<ExportOperatingDataValue, ExportOperatingDataValueResponse>(this.username, this.password, this.baseuri, "OperatingDataValueService", arg, this.timeoutSeconds);
    }

    public ImportOperatingDataValueResponse ImportOperatingDataValue(
      ImportOperatingDataValue arg)
    {
      return Client.Post<ImportOperatingDataValue, ImportOperatingDataValueResponse>(this.username, this.password, this.baseuri, "OperatingDataValueService", arg, this.timeoutSeconds);
    }

    public Task<ImportOperatingDataValueResponse> ImportOperatingDataValueAsync(
      ImportOperatingDataValue arg)
    {
      return Client.PostAsync<ImportOperatingDataValue, ImportOperatingDataValueResponse>(this.username, this.password, this.baseuri, "OperatingDataValueService", arg, this.timeoutSeconds);
    }
  }
}
