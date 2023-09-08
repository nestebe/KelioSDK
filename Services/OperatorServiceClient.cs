
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
    private readonly string baseuri;

    public OperatorServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportOperatorsResponse ExportOperators(ExportOperators arg)
    {
      return Client.Post<ExportOperators, ExportOperatorsResponse>(this.username, this.password, this.baseuri, "OperatorService", arg);
    }

    public Task<ExportOperatorsResponse> ExportOperatorsAsync(
      ExportOperators arg)
    {
      return Client.PostAsync<ExportOperators, ExportOperatorsResponse>(this.username, this.password, this.baseuri, "OperatorService", arg);
    }
  }
}
