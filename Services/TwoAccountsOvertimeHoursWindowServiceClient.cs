//.TwoAccountsOvertimeHoursWindowServiceClient


using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
    public class TwoAccountsOvertimeHoursWindowServiceClient
    {
        private const string service = "TwoAccountsOvertimeHoursWindowService";
        private readonly string username;
        private readonly string password;
        private readonly string baseuri;
        private readonly int timeoutSeconds;

        public TwoAccountsOvertimeHoursWindowServiceClient(
            string username,
            string password,
            string baseuri, int timeoutSeconds = 60)
        {
            this.username = username;
            this.password = password;
            this.baseuri = baseuri;
            this.timeoutSeconds = timeoutSeconds;
        }

        public ImportTwoAccountsOvertimeHoursWindowsResponse ImportTwoAccountsOvertimeHoursWindows(
            ImportTwoAccountsOvertimeHoursWindows arg)
        {
            return Client.Post<ImportTwoAccountsOvertimeHoursWindows, ImportTwoAccountsOvertimeHoursWindowsResponse>(
                this.username, this.password, this.baseuri, "TwoAccountsOvertimeHoursWindowService", arg,
                this.timeoutSeconds);
        }

        public Task<ImportTwoAccountsOvertimeHoursWindowsResponse> ImportTwoAccountsOvertimeHoursWindowsAsync(
            ImportTwoAccountsOvertimeHoursWindows arg)
        {
            return Client
                .PostAsync<ImportTwoAccountsOvertimeHoursWindows, ImportTwoAccountsOvertimeHoursWindowsResponse>(
                    this.username, this.password, this.baseuri, "TwoAccountsOvertimeHoursWindowService", arg,
                    this.timeoutSeconds);
        }

        public ExportTwoAccountsOvertimeHoursWindowsListResponse ExportTwoAccountsOvertimeHoursWindowsList(
            ExportTwoAccountsOvertimeHoursWindowsList arg)
        {
            return Client
                .Post<ExportTwoAccountsOvertimeHoursWindowsList, ExportTwoAccountsOvertimeHoursWindowsListResponse>(
                    this.username, this.password, this.baseuri, "TwoAccountsOvertimeHoursWindowService", arg,
                    this.timeoutSeconds);
        }

        public Task<ExportTwoAccountsOvertimeHoursWindowsListResponse> ExportTwoAccountsOvertimeHoursWindowsListAsync(
            ExportTwoAccountsOvertimeHoursWindowsList arg)
        {
            return Client
                .PostAsync<ExportTwoAccountsOvertimeHoursWindowsList,
                    ExportTwoAccountsOvertimeHoursWindowsListResponse>(this.username, this.password, this.baseuri,
                    "TwoAccountsOvertimeHoursWindowService", arg, this.timeoutSeconds);
        }

        public ExportTwoAccountsOvertimeHoursWindowsResponse ExportTwoAccountsOvertimeHoursWindows(
            ExportTwoAccountsOvertimeHoursWindows arg)
        {
            return Client.Post<ExportTwoAccountsOvertimeHoursWindows, ExportTwoAccountsOvertimeHoursWindowsResponse>(
                this.username, this.password, this.baseuri, "TwoAccountsOvertimeHoursWindowService", arg,
                this.timeoutSeconds);
        }

        public Task<ExportTwoAccountsOvertimeHoursWindowsResponse> ExportTwoAccountsOvertimeHoursWindowsAsync(
            ExportTwoAccountsOvertimeHoursWindows arg)
        {
            return Client
                .PostAsync<ExportTwoAccountsOvertimeHoursWindows, ExportTwoAccountsOvertimeHoursWindowsResponse>(
                    this.username, this.password, this.baseuri, "TwoAccountsOvertimeHoursWindowService", arg,
                    this.timeoutSeconds);
        }
    }
}