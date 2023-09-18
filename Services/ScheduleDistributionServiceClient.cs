//.ScheduleDistributionServiceClient


using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
    public class ScheduleDistributionServiceClient
    {
        private const string service = "ScheduleDistributionService";
        private readonly string username;
        private readonly string password;
        private readonly string baseuri;
        private readonly int timeoutSeconds;

        public ScheduleDistributionServiceClient(string username, string password, string baseuri,
            int timeoutSeconds = 60)
        {
            this.username = username;
            this.password = password;
            this.baseuri = baseuri;
            this.timeoutSeconds = timeoutSeconds;
        }

        public ExportScheduleDistributionsResponse ExportScheduleDistributions(
            ExportScheduleDistributions arg)
        {
            return Client.Post<ExportScheduleDistributions, ExportScheduleDistributionsResponse>(this.username,
                this.password, this.baseuri, "ScheduleDistributionService", arg, this.timeoutSeconds);
        }

        public Task<ExportScheduleDistributionsResponse> ExportScheduleDistributionsAsync(
            ExportScheduleDistributions arg)
        {
            return Client.PostAsync<ExportScheduleDistributions, ExportScheduleDistributionsResponse>(this.username,
                this.password, this.baseuri, "ScheduleDistributionService", arg, this.timeoutSeconds);
        }

        public ImportScheduleDistributionsResponse ImportScheduleDistributions(
            ImportScheduleDistributions arg)
        {
            return Client.Post<ImportScheduleDistributions, ImportScheduleDistributionsResponse>(this.username,
                this.password, this.baseuri, "ScheduleDistributionService", arg, this.timeoutSeconds);
        }

        public Task<ImportScheduleDistributionsResponse> ImportScheduleDistributionsAsync(
            ImportScheduleDistributions arg)
        {
            return Client.PostAsync<ImportScheduleDistributions, ImportScheduleDistributionsResponse>(this.username,
                this.password, this.baseuri, "ScheduleDistributionService", arg, this.timeoutSeconds);
        }
    }
}