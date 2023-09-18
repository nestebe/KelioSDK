//.PaidBreakWithConditionalDurationWindowServiceClient


using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
    public class PaidBreakWithConditionalDurationWindowServiceClient
    {
        private const string service = "PaidBreakWithConditionalDurationWindowService";
        private readonly string username;
        private readonly string password;
        private readonly string baseuri;
        private readonly int timeoutSeconds;

        public PaidBreakWithConditionalDurationWindowServiceClient(
            string username,
            string password,
            string baseuri, int timeoutSeconds = 60)
        {
            this.username = username;
            this.password = password;
            this.baseuri = baseuri;
            this.timeoutSeconds = timeoutSeconds;
        }

        public ExportPaidBreakWithConditionalDurationWindowsResponse ExportPaidBreakWithConditionalDurationWindows(
            ExportPaidBreakWithConditionalDurationWindows arg)
        {
            return Client
                .Post<ExportPaidBreakWithConditionalDurationWindows,
                    ExportPaidBreakWithConditionalDurationWindowsResponse>(this.username, this.password, this.baseuri,
                    "PaidBreakWithConditionalDurationWindowService", arg, this.timeoutSeconds);
        }

        public Task<ExportPaidBreakWithConditionalDurationWindowsResponse>
            ExportPaidBreakWithConditionalDurationWindowsAsync(
                ExportPaidBreakWithConditionalDurationWindows arg)
        {
            return Client
                .PostAsync<ExportPaidBreakWithConditionalDurationWindows,
                    ExportPaidBreakWithConditionalDurationWindowsResponse>(this.username, this.password, this.baseuri,
                    "PaidBreakWithConditionalDurationWindowService", arg, this.timeoutSeconds);
        }

        public ExportPaidBreakWithConditionalDurationWindowsListResponse
            ExportPaidBreakWithConditionalDurationWindowsList(
                ExportPaidBreakWithConditionalDurationWindowsList arg)
        {
            return Client
                .Post<ExportPaidBreakWithConditionalDurationWindowsList,
                    ExportPaidBreakWithConditionalDurationWindowsListResponse>(this.username, this.password,
                    this.baseuri, "PaidBreakWithConditionalDurationWindowService", arg, this.timeoutSeconds);
        }

        public Task<ExportPaidBreakWithConditionalDurationWindowsListResponse>
            ExportPaidBreakWithConditionalDurationWindowsListAsync(
                ExportPaidBreakWithConditionalDurationWindowsList arg)
        {
            return Client
                .PostAsync<ExportPaidBreakWithConditionalDurationWindowsList,
                    ExportPaidBreakWithConditionalDurationWindowsListResponse>(this.username, this.password,
                    this.baseuri, "PaidBreakWithConditionalDurationWindowService", arg, this.timeoutSeconds);
        }

        public ImportPaidBreakWithConditionalDurationWindowsResponse ImportPaidBreakWithConditionalDurationWindows(
            ImportPaidBreakWithConditionalDurationWindows arg)
        {
            return Client
                .Post<ImportPaidBreakWithConditionalDurationWindows,
                    ImportPaidBreakWithConditionalDurationWindowsResponse>(this.username, this.password, this.baseuri,
                    "PaidBreakWithConditionalDurationWindowService", arg, this.timeoutSeconds);
        }

        public Task<ImportPaidBreakWithConditionalDurationWindowsResponse>
            ImportPaidBreakWithConditionalDurationWindowsAsync(
                ImportPaidBreakWithConditionalDurationWindows arg)
        {
            return Client
                .PostAsync<ImportPaidBreakWithConditionalDurationWindows,
                    ImportPaidBreakWithConditionalDurationWindowsResponse>(this.username, this.password, this.baseuri,
                    "PaidBreakWithConditionalDurationWindowService", arg, this.timeoutSeconds);
        }
    }
}