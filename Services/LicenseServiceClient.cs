
//.LicenseServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class LicenseServiceClient
  {
    private const string service = "LicenseService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public LicenseServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportLicenseResponse ExportLicense(ExportLicense arg)
    {
      return Client.Post<ExportLicense, ExportLicenseResponse>(this.username, this.password, this.baseuri, "LicenseService", arg);
    }

    public Task<ExportLicenseResponse> ExportLicenseAsync(ExportLicense arg)
    {
      return Client.PostAsync<ExportLicense, ExportLicenseResponse>(this.username, this.password, this.baseuri, "LicenseService", arg);
    }
  }
}
