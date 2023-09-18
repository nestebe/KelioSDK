//.AutomaticScheduleServiceClient


using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
    public class AutomaticScheduleServiceClient
    {
        private const string service = "AutomaticScheduleService";
        private readonly string username;
        private readonly string password;
        private readonly string baseuri;
        private readonly int timeoutSeconds;

        public AutomaticScheduleServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
        {
            this.username = username;
            this.password = password;
            this.baseuri = baseuri;
            this.timeoutSeconds = timeoutSeconds;
        }

        public ImportAutomaticSchedulesResponse ImportAutomaticSchedules(
            ImportAutomaticSchedules arg)
        {
            return Client.Post<ImportAutomaticSchedules, ImportAutomaticSchedulesResponse>(this.username, this.password,
                this.baseuri, "AutomaticScheduleService", arg, this.timeoutSeconds);
        }

        public Task<ImportAutomaticSchedulesResponse> ImportAutomaticSchedulesAsync(
            ImportAutomaticSchedules arg)
        {
            return Client.PostAsync<ImportAutomaticSchedules, ImportAutomaticSchedulesResponse>(this.username,
                this.password, this.baseuri, "AutomaticScheduleService", arg, this.timeoutSeconds);
        }

        public ExportAutomaticSchedulesResponse ExportAutomaticSchedules(
            ExportAutomaticSchedules arg)
        {
            return Client.Post<ExportAutomaticSchedules, ExportAutomaticSchedulesResponse>(this.username, this.password,
                this.baseuri, "AutomaticScheduleService", arg, this.timeoutSeconds);
        }

        public Task<ExportAutomaticSchedulesResponse> ExportAutomaticSchedulesAsync(
            ExportAutomaticSchedules arg)
        {
            return Client.PostAsync<ExportAutomaticSchedules, ExportAutomaticSchedulesResponse>(this.username,
                this.password, this.baseuri, "AutomaticScheduleService", arg, this.timeoutSeconds);
        }
    }
}