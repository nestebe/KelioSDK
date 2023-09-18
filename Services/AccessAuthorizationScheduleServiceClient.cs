//.AccessAuthorizationScheduleServiceClient


using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
    public class AccessAuthorizationScheduleServiceClient
    {
        private const string service = "AccessAuthorizationScheduleService";
        private readonly string username;
        private readonly string password;
        private readonly string baseuri;
        private readonly int timeoutSeconds;

        public AccessAuthorizationScheduleServiceClient(
            string username,
            string password,
            string baseuri, int timeoutSeconds = 60)
        {
            this.username = username;
            this.password = password;
            this.baseuri = baseuri;
            this.timeoutSeconds = timeoutSeconds;
        }

        public ImportAccessWeeklyAuthorizationSchedulesResponse ImportAccessWeeklyAuthorizationSchedules(
            ImportAccessWeeklyAuthorizationSchedules arg)
        {
            return Client
                .Post<ImportAccessWeeklyAuthorizationSchedules, ImportAccessWeeklyAuthorizationSchedulesResponse>(
                    this.username, this.password, this.baseuri, "AccessAuthorizationScheduleService", arg,
                    this.timeoutSeconds);
        }

        public Task<ImportAccessWeeklyAuthorizationSchedulesResponse> ImportAccessWeeklyAuthorizationSchedulesAsync(
            ImportAccessWeeklyAuthorizationSchedules arg)
        {
            return Client
                .PostAsync<ImportAccessWeeklyAuthorizationSchedules, ImportAccessWeeklyAuthorizationSchedulesResponse>(
                    this.username, this.password, this.baseuri, "AccessAuthorizationScheduleService", arg,
                    this.timeoutSeconds);
        }

        public ImportAuthorizationWindowsResponse ImportAuthorizationWindows(
            ImportAuthorizationWindows arg)
        {
            return Client.Post<ImportAuthorizationWindows, ImportAuthorizationWindowsResponse>(this.username,
                this.password, this.baseuri, "AccessAuthorizationScheduleService", arg, this.timeoutSeconds);
        }

        public Task<ImportAuthorizationWindowsResponse> ImportAuthorizationWindowsAsync(
            ImportAuthorizationWindows arg)
        {
            return Client.PostAsync<ImportAuthorizationWindows, ImportAuthorizationWindowsResponse>(this.username,
                this.password, this.baseuri, "AccessAuthorizationScheduleService", arg, this.timeoutSeconds);
        }
    }
}