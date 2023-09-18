
//.CoefficientServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class CoefficientServiceClient
  {
    private const string service = "CoefficientService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public CoefficientServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ImportCoefficientsResponse ImportCoefficients(
      ImportCoefficients arg)
    {
      return Client.Post<ImportCoefficients, ImportCoefficientsResponse>(this.username, this.password, this.baseuri, "CoefficientService", arg, this.timeoutSeconds);
    }

    public Task<ImportCoefficientsResponse> ImportCoefficientsAsync(
      ImportCoefficients arg)
    {
      return Client.PostAsync<ImportCoefficients, ImportCoefficientsResponse>(this.username, this.password, this.baseuri, "CoefficientService", arg, this.timeoutSeconds);
    }

    public ExportCoefficientsResponse ExportCoefficients(
      ExportCoefficients arg)
    {
      return Client.Post<ExportCoefficients, ExportCoefficientsResponse>(this.username, this.password, this.baseuri, "CoefficientService", arg, this.timeoutSeconds);
    }

    public Task<ExportCoefficientsResponse> ExportCoefficientsAsync(
      ExportCoefficients arg)
    {
      return Client.PostAsync<ExportCoefficients, ExportCoefficientsResponse>(this.username, this.password, this.baseuri, "CoefficientService", arg, this.timeoutSeconds);
    }
  }
}
