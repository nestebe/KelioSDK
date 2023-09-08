
//.CorrelationTableRiskAccountServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class CorrelationTableRiskAccountServiceClient
  {
    private const string service = "CorrelationTableRiskAccountService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public CorrelationTableRiskAccountServiceClient(
      string username,
      string password,
      string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportCorrelationTableRiskAccountResponse ExportCorrelationTableRiskAccount(
      ExportCorrelationTableRiskAccount arg)
    {
      return Client.Post<ExportCorrelationTableRiskAccount, ExportCorrelationTableRiskAccountResponse>(this.username, this.password, this.baseuri, "CorrelationTableRiskAccountService", arg);
    }

    public Task<ExportCorrelationTableRiskAccountResponse> ExportCorrelationTableRiskAccountAsync(
      ExportCorrelationTableRiskAccount arg)
    {
      return Client.PostAsync<ExportCorrelationTableRiskAccount, ExportCorrelationTableRiskAccountResponse>(this.username, this.password, this.baseuri, "CorrelationTableRiskAccountService", arg);
    }
  }
}
