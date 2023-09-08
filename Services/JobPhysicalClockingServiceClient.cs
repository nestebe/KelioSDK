
//.JobPhysicalClockingServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class JobPhysicalClockingServiceClient
  {
    private const string service = "JobPhysicalClockingService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public JobPhysicalClockingServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ImportJobPhysicalClockingsResponse ImportJobPhysicalClockings(
      ImportJobPhysicalClockings arg)
    {
      return Client.Post<ImportJobPhysicalClockings, ImportJobPhysicalClockingsResponse>(this.username, this.password, this.baseuri, "JobPhysicalClockingService", arg);
    }

    public Task<ImportJobPhysicalClockingsResponse> ImportJobPhysicalClockingsAsync(
      ImportJobPhysicalClockings arg)
    {
      return Client.PostAsync<ImportJobPhysicalClockings, ImportJobPhysicalClockingsResponse>(this.username, this.password, this.baseuri, "JobPhysicalClockingService", arg);
    }
  }
}
