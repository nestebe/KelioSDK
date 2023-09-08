
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
    private readonly string baseuri;

    public EndOfPeriodDateServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ImportEndOfPeriodDateResponse ImportEndOfPeriodDate(
      ImportEndOfPeriodDate arg)
    {
      return Client.Post<ImportEndOfPeriodDate, ImportEndOfPeriodDateResponse>(this.username, this.password, this.baseuri, "EndOfPeriodDateService", arg);
    }

    public Task<ImportEndOfPeriodDateResponse> ImportEndOfPeriodDateAsync(
      ImportEndOfPeriodDate arg)
    {
      return Client.PostAsync<ImportEndOfPeriodDate, ImportEndOfPeriodDateResponse>(this.username, this.password, this.baseuri, "EndOfPeriodDateService", arg);
    }
  }
}
