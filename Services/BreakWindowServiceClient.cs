//.BreakWindowServiceClient


using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
    public class BreakWindowServiceClient
    {
        private const string service = "BreakWindowService";
        private readonly string username;
        private readonly string password;
        private readonly string baseuri;
        private readonly int timeoutSeconds;

        public BreakWindowServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
        {
            this.username = username;
            this.password = password;
            this.baseuri = baseuri;
            this.timeoutSeconds = timeoutSeconds;
        }

        public ExportBreakWindowsResponse ExportBreakWindows(
            ExportBreakWindows arg)
        {
            return Client.Post<ExportBreakWindows, ExportBreakWindowsResponse>(this.username, this.password,
                this.baseuri, "BreakWindowService", arg, this.timeoutSeconds);
        }

        public Task<ExportBreakWindowsResponse> ExportBreakWindowsAsync(
            ExportBreakWindows arg)
        {
            return Client.PostAsync<ExportBreakWindows, ExportBreakWindowsResponse>(this.username, this.password,
                this.baseuri, "BreakWindowService", arg, this.timeoutSeconds);
        }

        public ExportBreakWindowsListResponse ExportBreakWindowsList(
            ExportBreakWindowsList arg)
        {
            return Client.Post<ExportBreakWindowsList, ExportBreakWindowsListResponse>(this.username, this.password,
                this.baseuri, "BreakWindowService", arg, this.timeoutSeconds);
        }

        public Task<ExportBreakWindowsListResponse> ExportBreakWindowsListAsync(
            ExportBreakWindowsList arg)
        {
            return Client.PostAsync<ExportBreakWindowsList, ExportBreakWindowsListResponse>(this.username,
                this.password, this.baseuri, "BreakWindowService", arg, this.timeoutSeconds);
        }

        public ImportBreakWindowsResponse ImportBreakWindows(
            ImportBreakWindows arg)
        {
            return Client.Post<ImportBreakWindows, ImportBreakWindowsResponse>(this.username, this.password,
                this.baseuri, "BreakWindowService", arg, this.timeoutSeconds);
        }

        public Task<ImportBreakWindowsResponse> ImportBreakWindowsAsync(
            ImportBreakWindows arg)
        {
            return Client.PostAsync<ImportBreakWindows, ImportBreakWindowsResponse>(this.username, this.password,
                this.baseuri, "BreakWindowService", arg, this.timeoutSeconds);
        }
    }
}