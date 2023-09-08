
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
    private readonly string baseuri;

    public EndOfPeriodCalendarServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ImportEndOfPeriodCalendarResponse ImportEndOfPeriodCalendar(
      ImportEndOfPeriodCalendar arg)
    {
      return Client.Post<ImportEndOfPeriodCalendar, ImportEndOfPeriodCalendarResponse>(this.username, this.password, this.baseuri, "EndOfPeriodCalendarService", arg);
    }

    public Task<ImportEndOfPeriodCalendarResponse> ImportEndOfPeriodCalendarAsync(
      ImportEndOfPeriodCalendar arg)
    {
      return Client.PostAsync<ImportEndOfPeriodCalendar, ImportEndOfPeriodCalendarResponse>(this.username, this.password, this.baseuri, "EndOfPeriodCalendarService", arg);
    }
  }
}
