//.DailyScheduleServiceClient


using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
    public class DailyScheduleServiceClient
    {
        private const string service = "DailyScheduleService";
        private readonly string username;
        private readonly string password;
        private readonly string baseuri;
        private readonly int timeoutSeconds;

        public DailyScheduleServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
        {
            this.username = username;
            this.password = password;
            this.baseuri = baseuri;
            this.timeoutSeconds = timeoutSeconds;
        }

        public ImportDailySchedulesResponse ImportDailySchedules(
            ImportDailySchedules arg)
        {
            return Client.Post<ImportDailySchedules, ImportDailySchedulesResponse>(this.username, this.password,
                this.baseuri, "DailyScheduleService", arg, this.timeoutSeconds);
        }

        public Task<ImportDailySchedulesResponse> ImportDailySchedulesAsync(
            ImportDailySchedules arg)
        {
            return Client.PostAsync<ImportDailySchedules, ImportDailySchedulesResponse>(this.username, this.password,
                this.baseuri, "DailyScheduleService", arg, this.timeoutSeconds);
        }

        public ExportDailySchedulesResponse ExportDailySchedules(
            ExportDailySchedules arg)
        {
            return Client.Post<ExportDailySchedules, ExportDailySchedulesResponse>(this.username, this.password,
                this.baseuri, "DailyScheduleService", arg, this.timeoutSeconds);
        }

        public Task<ExportDailySchedulesResponse> ExportDailySchedulesAsync(
            ExportDailySchedules arg)
        {
            return Client.PostAsync<ExportDailySchedules, ExportDailySchedulesResponse>(this.username, this.password,
                this.baseuri, "DailyScheduleService", arg, this.timeoutSeconds);
        }
    }
}