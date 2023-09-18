
//.EmploymentContractNatureServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class EmploymentContractNatureServiceClient
  {
    private const string service = "EmploymentContractNatureService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public EmploymentContractNatureServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ExportEmploymentContractNatureResponse ExportEmploymentContractNature(
      ExportEmploymentContractNature arg)
    {
      return Client.Post<ExportEmploymentContractNature, ExportEmploymentContractNatureResponse>(this.username, this.password, this.baseuri, "EmploymentContractNatureService", arg, this.timeoutSeconds);
    }

    public Task<ExportEmploymentContractNatureResponse> ExportEmploymentContractNatureAsync(
      ExportEmploymentContractNature arg)
    {
      return Client.PostAsync<ExportEmploymentContractNature, ExportEmploymentContractNatureResponse>(this.username, this.password, this.baseuri, "EmploymentContractNatureService", arg, this.timeoutSeconds);
    }

    public ImportEmploymentContractNatureResponse ImportEmploymentContractNature(
      ImportEmploymentContractNature arg)
    {
      return Client.Post<ImportEmploymentContractNature, ImportEmploymentContractNatureResponse>(this.username, this.password, this.baseuri, "EmploymentContractNatureService", arg, this.timeoutSeconds);
    }

    public Task<ImportEmploymentContractNatureResponse> ImportEmploymentContractNatureAsync(
      ImportEmploymentContractNature arg)
    {
      return Client.PostAsync<ImportEmploymentContractNature, ImportEmploymentContractNatureResponse>(this.username, this.password, this.baseuri, "EmploymentContractNatureService", arg, this.timeoutSeconds);
    }
  }
}
