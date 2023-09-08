
//.SpecificInterfaceParameterServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class SpecificInterfaceParameterServiceClient
  {
    private const string service = "SpecificInterfaceParameterService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public SpecificInterfaceParameterServiceClient(
      string username,
      string password,
      string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportSpecificInterfaceParametersResponse ExportSpecificInterfaceParameters(
      ExportSpecificInterfaceParameters arg)
    {
      return Client.Post<ExportSpecificInterfaceParameters, ExportSpecificInterfaceParametersResponse>(this.username, this.password, this.baseuri, "SpecificInterfaceParameterService", arg);
    }

    public Task<ExportSpecificInterfaceParametersResponse> ExportSpecificInterfaceParametersAsync(
      ExportSpecificInterfaceParameters arg)
    {
      return Client.PostAsync<ExportSpecificInterfaceParameters, ExportSpecificInterfaceParametersResponse>(this.username, this.password, this.baseuri, "SpecificInterfaceParameterService", arg);
    }
  }
}
