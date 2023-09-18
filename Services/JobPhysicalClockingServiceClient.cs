//.JobPhysicalClockingServiceClient


using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
    public class JobPhysicalClockingServiceClient
    {
        private const string service = "JobPhysicalClockingService";
        private readonly string username;
        private readonly string password;
        private readonly string baseuri;
        private readonly int timeoutSeconds;

        public JobPhysicalClockingServiceClient(string username, string password, string baseuri,
            int timeoutSeconds = 60)
        {
            this.username = username;
            this.password = password;
            this.baseuri = baseuri;
            this.timeoutSeconds = timeoutSeconds;
        }

        public ImportJobPhysicalClockingsResponse ImportJobPhysicalClockings(
            ImportJobPhysicalClockings arg)
        {
            return Client.Post<ImportJobPhysicalClockings, ImportJobPhysicalClockingsResponse>(this.username,
                this.password, this.baseuri, "JobPhysicalClockingService", arg, this.timeoutSeconds);
        }

        public Task<ImportJobPhysicalClockingsResponse> ImportJobPhysicalClockingsAsync(
            ImportJobPhysicalClockings arg)
        {
            return Client.PostAsync<ImportJobPhysicalClockings, ImportJobPhysicalClockingsResponse>(this.username,
                this.password, this.baseuri, "JobPhysicalClockingService", arg, this.timeoutSeconds);
        }
    }
}