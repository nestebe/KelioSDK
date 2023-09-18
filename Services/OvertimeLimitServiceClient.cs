//.OvertimeLimitServiceClient


using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
    public class OvertimeLimitServiceClient
    {
        private const string service = "OvertimeLimitService";
        private readonly string username;
        private readonly string password;
        private readonly string baseuri;
        private readonly int timeoutSeconds;

        public OvertimeLimitServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
        {
            this.username = username;
            this.password = password;
            this.baseuri = baseuri;
            this.timeoutSeconds = timeoutSeconds;
        }

        public ExportOvertimeLimitsResponse ExportOvertimeLimits(
            ExportOvertimeLimits arg)
        {
            return Client.Post<ExportOvertimeLimits, ExportOvertimeLimitsResponse>(this.username, this.password,
                this.baseuri, "OvertimeLimitService", arg, this.timeoutSeconds);
        }

        public Task<ExportOvertimeLimitsResponse> ExportOvertimeLimitsAsync(
            ExportOvertimeLimits arg)
        {
            return Client.PostAsync<ExportOvertimeLimits, ExportOvertimeLimitsResponse>(this.username, this.password,
                this.baseuri, "OvertimeLimitService", arg, this.timeoutSeconds);
        }

        public ImportOvertimeLimitsResponse ImportOvertimeLimits(
            ImportOvertimeLimits arg)
        {
            return Client.Post<ImportOvertimeLimits, ImportOvertimeLimitsResponse>(this.username, this.password,
                this.baseuri, "OvertimeLimitService", arg, this.timeoutSeconds);
        }

        public Task<ImportOvertimeLimitsResponse> ImportOvertimeLimitsAsync(
            ImportOvertimeLimits arg)
        {
            return Client.PostAsync<ImportOvertimeLimits, ImportOvertimeLimitsResponse>(this.username, this.password,
                this.baseuri, "OvertimeLimitService", arg, this.timeoutSeconds);
        }
    }
}