
//.OperatorServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class OperatorServiceClient
  {
    private const string service = "OperatorService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public OperatorServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ExportOperatorsResponse ExportOperators(ExportOperators arg)
    {
      return Client.Post<ExportOperators, ExportOperatorsResponse>(this.username, this.password, this.baseuri, "OperatorService", arg, this.timeoutSeconds);
    }

    public Task<ExportOperatorsResponse> ExportOperatorsAsync(
      ExportOperators arg)
    {
      return Client.PostAsync<ExportOperators, ExportOperatorsResponse>(this.username, this.password, this.baseuri, "OperatorService", arg, this.timeoutSeconds);
    }
  }
}
