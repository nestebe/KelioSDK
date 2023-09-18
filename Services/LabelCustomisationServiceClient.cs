
//.LabelCustomisationServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class LabelCustomisationServiceClient
  {
    private const string service = "LabelCustomisationService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public LabelCustomisationServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ExportLabelCustomisationResponse ExportLabelCustomisation(
      ExportLabelCustomisation arg)
    {
      return Client.Post<ExportLabelCustomisation, ExportLabelCustomisationResponse>(this.username, this.password, this.baseuri, "LabelCustomisationService", arg, this.timeoutSeconds);
    }

    public Task<ExportLabelCustomisationResponse> ExportLabelCustomisationAsync(
      ExportLabelCustomisation arg)
    {
      return Client.PostAsync<ExportLabelCustomisation, ExportLabelCustomisationResponse>(this.username, this.password, this.baseuri, "LabelCustomisationService", arg, this.timeoutSeconds);
    }
  }
}
