//.ShiftScheduleDistributionServiceClient


using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
    public class ShiftScheduleDistributionServiceClient
    {
        private const string service = "ShiftScheduleDistributionService";
        private readonly string username;
        private readonly string password;
        private readonly string baseuri;
        private readonly int timeoutSeconds;

        public ShiftScheduleDistributionServiceClient(string username, string password, string baseuri,
            int timeoutSeconds = 60)
        {
            this.username = username;
            this.password = password;
            this.baseuri = baseuri;
            this.timeoutSeconds = timeoutSeconds;
        }

        public ExportShiftScheduleDistributionResponse ExportShiftScheduleDistribution(
            ExportShiftScheduleDistribution arg)
        {
            return Client.Post<ExportShiftScheduleDistribution, ExportShiftScheduleDistributionResponse>(this.username,
                this.password, this.baseuri, "ShiftScheduleDistributionService", arg, this.timeoutSeconds);
        }

        public Task<ExportShiftScheduleDistributionResponse> ExportShiftScheduleDistributionAsync(
            ExportShiftScheduleDistribution arg)
        {
            return Client.PostAsync<ExportShiftScheduleDistribution, ExportShiftScheduleDistributionResponse>(
                this.username, this.password, this.baseuri, "ShiftScheduleDistributionService", arg,
                this.timeoutSeconds);
        }

        public ImportShiftScheduleDistributionResponse ImportShiftScheduleDistribution(
            ImportShiftScheduleDistribution arg)
        {
            return Client.Post<ImportShiftScheduleDistribution, ImportShiftScheduleDistributionResponse>(this.username,
                this.password, this.baseuri, "ShiftScheduleDistributionService", arg, this.timeoutSeconds);
        }

        public Task<ImportShiftScheduleDistributionResponse> ImportShiftScheduleDistributionAsync(
            ImportShiftScheduleDistribution arg)
        {
            return Client.PostAsync<ImportShiftScheduleDistribution, ImportShiftScheduleDistributionResponse>(
                this.username, this.password, this.baseuri, "ShiftScheduleDistributionService", arg,
                this.timeoutSeconds);
        }
    }
}