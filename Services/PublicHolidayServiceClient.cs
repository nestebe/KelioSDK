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
        private readonly int timeoutSeconds;

        public PublicHolidayServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
        {
            this.username = username;
            this.password = password;
            this.baseuri = baseuri;
            this.timeoutSeconds = timeoutSeconds;
        }

        public ImportPublicHolidaySetupResponse ImportPublicHolidaySetup(
            ImportPublicHolidaySetup arg)
        {
            return Client.Post<ImportPublicHolidaySetup, ImportPublicHolidaySetupResponse>(this.username, this.password,
                this.baseuri, "PublicHolidayService", arg, this.timeoutSeconds);
        }

        public Task<ImportPublicHolidaySetupResponse> ImportPublicHolidaySetupAsync(
            ImportPublicHolidaySetup arg)
        {
            return Client.PostAsync<ImportPublicHolidaySetup, ImportPublicHolidaySetupResponse>(this.username,
                this.password, this.baseuri, "PublicHolidayService", arg, this.timeoutSeconds);
        }

        public ImportPublicHolidaysResponse ImportPublicHolidays(
            ImportPublicHolidays arg)
        {
            return Client.Post<ImportPublicHolidays, ImportPublicHolidaysResponse>(this.username, this.password,
                this.baseuri, "PublicHolidayService", arg, this.timeoutSeconds);
        }

        public Task<ImportPublicHolidaysResponse> ImportPublicHolidaysAsync(
            ImportPublicHolidays arg)
        {
            return Client.PostAsync<ImportPublicHolidays, ImportPublicHolidaysResponse>(this.username, this.password,
                this.baseuri, "PublicHolidayService", arg, this.timeoutSeconds);
        }
    }
}