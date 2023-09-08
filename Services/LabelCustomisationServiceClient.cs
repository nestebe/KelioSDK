
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
    private readonly string baseuri;

    public LabelCustomisationServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportLabelCustomisationResponse ExportLabelCustomisation(
      ExportLabelCustomisation arg)
    {
      return Client.Post<ExportLabelCustomisation, ExportLabelCustomisationResponse>(this.username, this.password, this.baseuri, "LabelCustomisationService", arg);
    }

    public Task<ExportLabelCustomisationResponse> ExportLabelCustomisationAsync(
      ExportLabelCustomisation arg)
    {
      return Client.PostAsync<ExportLabelCustomisation, ExportLabelCustomisationResponse>(this.username, this.password, this.baseuri, "LabelCustomisationService", arg);
    }
  }
}
