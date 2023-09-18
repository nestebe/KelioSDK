
//.EndOfPeriodDateServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class EndOfPeriodDateServiceClient
  {
    private const string service = "EndOfPeriodDateService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public EndOfPeriodDateServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ImportEndOfPeriodDateResponse ImportEndOfPeriodDate(
      ImportEndOfPeriodDate arg)
    {
      return Client.Post<ImportEndOfPeriodDate, ImportEndOfPeriodDateResponse>(this.username, this.password, this.baseuri, "EndOfPeriodDateService", arg, this.timeoutSeconds);
    }

    public Task<ImportEndOfPeriodDateResponse> ImportEndOfPeriodDateAsync(
      ImportEndOfPeriodDate arg)
    {
      return Client.PostAsync<ImportEndOfPeriodDate, ImportEndOfPeriodDateResponse>(this.username, this.password, this.baseuri, "EndOfPeriodDateService", arg, this.timeoutSeconds);
    }
  }
}
