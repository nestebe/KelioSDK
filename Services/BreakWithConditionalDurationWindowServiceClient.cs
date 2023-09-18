//.BreakWithConditionalDurationWindowServiceClient


using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
    public class BreakWithConditionalDurationWindowServiceClient
    {
        private const string service = "BreakWithConditionalDurationWindowService";
        private readonly string username;
        private readonly string password;
        private readonly string baseuri;
        private readonly int timeoutSeconds;

        public BreakWithConditionalDurationWindowServiceClient(
            string username,
            string password,
            string baseuri, int timeoutSeconds = 60)
        {
            this.username = username;
            this.password = password;
            this.baseuri = baseuri;
            this.timeoutSeconds = timeoutSeconds;
        }

        public ExportBreakWithConditionalDurationWindowsResponse ExportBreakWithConditionalDurationWindows(
            ExportBreakWithConditionalDurationWindows arg)
        {
            return Client
                .Post<ExportBreakWithConditionalDurationWindows, ExportBreakWithConditionalDurationWindowsResponse>(
                    this.username, this.password, this.baseuri, "BreakWithConditionalDurationWindowService", arg,
                    this.timeoutSeconds);
        }

        public Task<ExportBreakWithConditionalDurationWindowsResponse> ExportBreakWithConditionalDurationWindowsAsync(
            ExportBreakWithConditionalDurationWindows arg)
        {
            return Client
                .PostAsync<ExportBreakWithConditionalDurationWindows,
                    ExportBreakWithConditionalDurationWindowsResponse>(this.username, this.password, this.baseuri,
                    "BreakWithConditionalDurationWindowService", arg, this.timeoutSeconds);
        }

        public ExportBreakWithConditionalDurationWindowsListResponse ExportBreakWithConditionalDurationWindowsList(
            ExportBreakWithConditionalDurationWindowsList arg)
        {
            return Client
                .Post<ExportBreakWithConditionalDurationWindowsList,
                    ExportBreakWithConditionalDurationWindowsListResponse>(this.username, this.password, this.baseuri,
                    "BreakWithConditionalDurationWindowService", arg, this.timeoutSeconds);
        }

        public Task<ExportBreakWithConditionalDurationWindowsListResponse>
            ExportBreakWithConditionalDurationWindowsListAsync(
                ExportBreakWithConditionalDurationWindowsList arg)
        {
            return Client
                .PostAsync<ExportBreakWithConditionalDurationWindowsList,
                    ExportBreakWithConditionalDurationWindowsListResponse>(this.username, this.password, this.baseuri,
                    "BreakWithConditionalDurationWindowService", arg, this.timeoutSeconds);
        }

        public ImportBreakWithConditionalDurationWindowsResponse ImportBreakWithConditionalDurationWindows(
            ImportBreakWithConditionalDurationWindows arg)
        {
            return Client
                .Post<ImportBreakWithConditionalDurationWindows, ImportBreakWithConditionalDurationWindowsResponse>(
                    this.username, this.password, this.baseuri, "BreakWithConditionalDurationWindowService", arg,
                    this.timeoutSeconds);
        }

        public Task<ImportBreakWithConditionalDurationWindowsResponse> ImportBreakWithConditionalDurationWindowsAsync(
            ImportBreakWithConditionalDurationWindows arg)
        {
            return Client
                .PostAsync<ImportBreakWithConditionalDurationWindows,
                    ImportBreakWithConditionalDurationWindowsResponse>(this.username, this.password, this.baseuri,
                    "BreakWithConditionalDurationWindowService", arg, this.timeoutSeconds);
        }
    }
}