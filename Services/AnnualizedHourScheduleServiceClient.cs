//.AnnualizedHourScheduleServiceClient


using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
    public class AnnualizedHourScheduleServiceClient
    {
        private const string service = "AnnualizedHourScheduleService";
        private readonly string username;
        private readonly string password;
        private readonly string baseuri;
        private readonly int timeoutSeconds;

        public AnnualizedHourScheduleServiceClient(string username, string password, string baseuri,
            int timeoutSeconds = 60)
        {
            this.username = username;
            this.password = password;
            this.baseuri = baseuri;
            this.timeoutSeconds = timeoutSeconds;
        }

        public ImportAnnualizedHourSchedulesResponse ImportAnnualizedHourSchedules(
            ImportAnnualizedHourSchedules arg)
        {
            return Client.Post<ImportAnnualizedHourSchedules, ImportAnnualizedHourSchedulesResponse>(this.username,
                this.password, this.baseuri, "AnnualizedHourScheduleService", arg, this.timeoutSeconds);
        }

        public Task<ImportAnnualizedHourSchedulesResponse> ImportAnnualizedHourSchedulesAsync(
            ImportAnnualizedHourSchedules arg)
        {
            return Client.PostAsync<ImportAnnualizedHourSchedules, ImportAnnualizedHourSchedulesResponse>(this.username,
                this.password, this.baseuri, "AnnualizedHourScheduleService", arg, this.timeoutSeconds);
        }

        public ExportAnnualizedHourSchedulesResponse ExportAnnualizedHourSchedules(
            ExportAnnualizedHourSchedules arg)
        {
            return Client.Post<ExportAnnualizedHourSchedules, ExportAnnualizedHourSchedulesResponse>(this.username,
                this.password, this.baseuri, "AnnualizedHourScheduleService", arg, this.timeoutSeconds);
        }

        public Task<ExportAnnualizedHourSchedulesResponse> ExportAnnualizedHourSchedulesAsync(
            ExportAnnualizedHourSchedules arg)
        {
            return Client.PostAsync<ExportAnnualizedHourSchedules, ExportAnnualizedHourSchedulesResponse>(this.username,
                this.password, this.baseuri, "AnnualizedHourScheduleService", arg, this.timeoutSeconds);
        }
    }
}