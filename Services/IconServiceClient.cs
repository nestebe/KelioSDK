
//.IconServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class IconServiceClient
  {
    private const string service = "IconService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public IconServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ExportIconsResponse ExportIcons(ExportIcons arg)
    {
      return Client.Post<ExportIcons, ExportIconsResponse>(this.username, this.password, this.baseuri, "IconService", arg, this.timeoutSeconds);
    }

    public Task<ExportIconsResponse> ExportIconsAsync(ExportIcons arg)
    {
      return Client.PostAsync<ExportIcons, ExportIconsResponse>(this.username, this.password, this.baseuri, "IconService", arg, this.timeoutSeconds);
    }
  }
}
