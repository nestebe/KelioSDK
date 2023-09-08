
//.PublicHolidayServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class PublicHolidayServiceClient
  {
    private const string service = "PublicHolidayService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public PublicHolidayServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ImportPublicHolidaySetupResponse ImportPublicHolidaySetup(
      ImportPublicHolidaySetup arg)
    {
      return Client.Post<ImportPublicHolidaySetup, ImportPublicHolidaySetupResponse>(this.username, this.password, this.baseuri, "PublicHolidayService", arg);
    }

    public Task<ImportPublicHolidaySetupResponse> ImportPublicHolidaySetupAsync(
      ImportPublicHolidaySetup arg)
    {
      return Client.PostAsync<ImportPublicHolidaySetup, ImportPublicHolidaySetupResponse>(this.username, this.password, this.baseuri, "PublicHolidayService", arg);
    }

    public ImportPublicHolidaysResponse ImportPublicHolidays(
      ImportPublicHolidays arg)
    {
      return Client.Post<ImportPublicHolidays, ImportPublicHolidaysResponse>(this.username, this.password, this.baseuri, "PublicHolidayService", arg);
    }

    public Task<ImportPublicHolidaysResponse> ImportPublicHolidaysAsync(
      ImportPublicHolidays arg)
    {
      return Client.PostAsync<ImportPublicHolidays, ImportPublicHolidaysResponse>(this.username, this.password, this.baseuri, "PublicHolidayService", arg);
    }
  }
}
