
//.EndOfPeriodCalendarServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class EndOfPeriodCalendarServiceClient
  {
    private const string service = "EndOfPeriodCalendarService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public EndOfPeriodCalendarServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ImportEndOfPeriodCalendarResponse ImportEndOfPeriodCalendar(
      ImportEndOfPeriodCalendar arg)
    {
      return Client.Post<ImportEndOfPeriodCalendar, ImportEndOfPeriodCalendarResponse>(this.username, this.password, this.baseuri, "EndOfPeriodCalendarService", arg, this.timeoutSeconds);
    }

    public Task<ImportEndOfPeriodCalendarResponse> ImportEndOfPeriodCalendarAsync(
      ImportEndOfPeriodCalendar arg)
    {
      return Client.PostAsync<ImportEndOfPeriodCalendar, ImportEndOfPeriodCalendarResponse>(this.username, this.password, this.baseuri, "EndOfPeriodCalendarService", arg, this.timeoutSeconds);
    }
  }
}
