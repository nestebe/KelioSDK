//.WeekConditionedOvertimeHoursWindowServiceClient


using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
    public class WeekConditionedOvertimeHoursWindowServiceClient
    {
        private const string service = "WeekConditionedOvertimeHoursWindowService";
        private readonly string username;
        private readonly string password;
        private readonly string baseuri;
        private readonly int timeoutSeconds;

        public WeekConditionedOvertimeHoursWindowServiceClient(
            string username,
            string password,
            string baseuri, int timeoutSeconds = 60)
        {
            this.username = username;
            this.password = password;
            this.baseuri = baseuri;
            this.timeoutSeconds = timeoutSeconds;
        }

        public ExportWeekConditionedOvertimeHoursWindowsResponse ExportWeekConditionedOvertimeHoursWindows(
            ExportWeekConditionedOvertimeHoursWindows arg)
        {
            return Client
                .Post<ExportWeekConditionedOvertimeHoursWindows, ExportWeekConditionedOvertimeHoursWindowsResponse>(
                    this.username, this.password, this.baseuri, "WeekConditionedOvertimeHoursWindowService", arg,
                    this.timeoutSeconds);
        }

        public Task<ExportWeekConditionedOvertimeHoursWindowsResponse> ExportWeekConditionedOvertimeHoursWindowsAsync(
            ExportWeekConditionedOvertimeHoursWindows arg)
        {
            return Client
                .PostAsync<ExportWeekConditionedOvertimeHoursWindows,
                    ExportWeekConditionedOvertimeHoursWindowsResponse>(this.username, this.password, this.baseuri,
                    "WeekConditionedOvertimeHoursWindowService", arg, this.timeoutSeconds);
        }

        public ExportWeekConditionedOvertimeHoursWindowsListResponse ExportWeekConditionedOvertimeHoursWindowsList(
            ExportWeekConditionedOvertimeHoursWindowsList arg)
        {
            return Client
                .Post<ExportWeekConditionedOvertimeHoursWindowsList,
                    ExportWeekConditionedOvertimeHoursWindowsListResponse>(this.username, this.password, this.baseuri,
                    "WeekConditionedOvertimeHoursWindowService", arg, this.timeoutSeconds);
        }

        public Task<ExportWeekConditionedOvertimeHoursWindowsListResponse>
            ExportWeekConditionedOvertimeHoursWindowsListAsync(
                ExportWeekConditionedOvertimeHoursWindowsList arg)
        {
            return Client
                .PostAsync<ExportWeekConditionedOvertimeHoursWindowsList,
                    ExportWeekConditionedOvertimeHoursWindowsListResponse>(this.username, this.password, this.baseuri,
                    "WeekConditionedOvertimeHoursWindowService", arg, this.timeoutSeconds);
        }

        public ImportWeekConditionedOvertimeHoursWindowsResponse ImportWeekConditionedOvertimeHoursWindows(
            ImportWeekConditionedOvertimeHoursWindows arg)
        {
            return Client
                .Post<ImportWeekConditionedOvertimeHoursWindows, ImportWeekConditionedOvertimeHoursWindowsResponse>(
                    this.username, this.password, this.baseuri, "WeekConditionedOvertimeHoursWindowService", arg,
                    this.timeoutSeconds);
        }

        public Task<ImportWeekConditionedOvertimeHoursWindowsResponse> ImportWeekConditionedOvertimeHoursWindowsAsync(
            ImportWeekConditionedOvertimeHoursWindows arg)
        {
            return Client
                .PostAsync<ImportWeekConditionedOvertimeHoursWindows,
                    ImportWeekConditionedOvertimeHoursWindowsResponse>(this.username, this.password, this.baseuri,
                    "WeekConditionedOvertimeHoursWindowService", arg, this.timeoutSeconds);
        }
    }
}