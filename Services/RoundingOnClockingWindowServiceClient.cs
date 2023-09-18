//.RoundingOnClockingWindowServiceClient


using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
    public class RoundingOnClockingWindowServiceClient
    {
        private const string service = "RoundingOnClockingWindowService";
        private readonly string username;
        private readonly string password;
        private readonly string baseuri;
        private readonly int timeoutSeconds;

        public RoundingOnClockingWindowServiceClient(string username, string password, string baseuri,
            int timeoutSeconds = 60)
        {
            this.username = username;
            this.password = password;
            this.baseuri = baseuri;
            this.timeoutSeconds = timeoutSeconds;
        }

        public ExportRoundingOnClockingWindowsResponse ExportRoundingOnClockingWindows(
            ExportRoundingOnClockingWindows arg)
        {
            return Client.Post<ExportRoundingOnClockingWindows, ExportRoundingOnClockingWindowsResponse>(this.username,
                this.password, this.baseuri, "RoundingOnClockingWindowService", arg, this.timeoutSeconds);
        }

        public Task<ExportRoundingOnClockingWindowsResponse> ExportRoundingOnClockingWindowsAsync(
            ExportRoundingOnClockingWindows arg)
        {
            return Client.PostAsync<ExportRoundingOnClockingWindows, ExportRoundingOnClockingWindowsResponse>(
                this.username, this.password, this.baseuri, "RoundingOnClockingWindowService", arg,
                this.timeoutSeconds);
        }

        public ExportRoundingOnClockingWindowsListResponse ExportRoundingOnClockingWindowsList(
            ExportRoundingOnClockingWindowsList arg)
        {
            return Client.Post<ExportRoundingOnClockingWindowsList, ExportRoundingOnClockingWindowsListResponse>(
                this.username, this.password, this.baseuri, "RoundingOnClockingWindowService", arg,
                this.timeoutSeconds);
        }

        public Task<ExportRoundingOnClockingWindowsListResponse> ExportRoundingOnClockingWindowsListAsync(
            ExportRoundingOnClockingWindowsList arg)
        {
            return Client.PostAsync<ExportRoundingOnClockingWindowsList, ExportRoundingOnClockingWindowsListResponse>(
                this.username, this.password, this.baseuri, "RoundingOnClockingWindowService", arg,
                this.timeoutSeconds);
        }

        public ImportRoundingOnClockingWindowsResponse ImportRoundingOnClockingWindows(
            ImportRoundingOnClockingWindows arg)
        {
            return Client.Post<ImportRoundingOnClockingWindows, ImportRoundingOnClockingWindowsResponse>(this.username,
                this.password, this.baseuri, "RoundingOnClockingWindowService", arg, this.timeoutSeconds);
        }

        public Task<ImportRoundingOnClockingWindowsResponse> ImportRoundingOnClockingWindowsAsync(
            ImportRoundingOnClockingWindows arg)
        {
            return Client.PostAsync<ImportRoundingOnClockingWindows, ImportRoundingOnClockingWindowsResponse>(
                this.username, this.password, this.baseuri, "RoundingOnClockingWindowService", arg,
                this.timeoutSeconds);
        }
    }
}