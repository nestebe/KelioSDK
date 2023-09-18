//.AbsenceWindowServiceClient


using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
    public class AbsenceWindowServiceClient
    {
        private const string service = "AbsenceWindowService";
        private readonly string username;
        private readonly string password;
        private readonly string baseuri;
        private readonly int timeoutSeconds;

        public AbsenceWindowServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
        {
            this.username = username;
            this.password = password;
            this.baseuri = baseuri;
            this.timeoutSeconds = timeoutSeconds;
        }

        public ExportAbsenceWindowsResponse ExportAbsenceWindows(
            ExportAbsenceWindows arg)
        {
            return Client.Post<ExportAbsenceWindows, ExportAbsenceWindowsResponse>(this.username, this.password,
                this.baseuri, "AbsenceWindowService", arg, this.timeoutSeconds);
        }

        public Task<ExportAbsenceWindowsResponse> ExportAbsenceWindowsAsync(
            ExportAbsenceWindows arg)
        {
            return Client.PostAsync<ExportAbsenceWindows, ExportAbsenceWindowsResponse>(this.username, this.password,
                this.baseuri, "AbsenceWindowService", arg, this.timeoutSeconds);
        }

        public ExportAbsenceWindowsListResponse ExportAbsenceWindowsList(
            ExportAbsenceWindowsList arg)
        {
            return Client.Post<ExportAbsenceWindowsList, ExportAbsenceWindowsListResponse>(this.username, this.password,
                this.baseuri, "AbsenceWindowService", arg, this.timeoutSeconds);
        }

        public Task<ExportAbsenceWindowsListResponse> ExportAbsenceWindowsListAsync(
            ExportAbsenceWindowsList arg)
        {
            return Client.PostAsync<ExportAbsenceWindowsList, ExportAbsenceWindowsListResponse>(this.username,
                this.password, this.baseuri, "AbsenceWindowService", arg, this.timeoutSeconds);
        }

        public ImportAbsenceWindowsResponse ImportAbsenceWindows(
            ImportAbsenceWindows arg)
        {
            return Client.Post<ImportAbsenceWindows, ImportAbsenceWindowsResponse>(this.username, this.password,
                this.baseuri, "AbsenceWindowService", arg, this.timeoutSeconds);
        }

        public Task<ImportAbsenceWindowsResponse> ImportAbsenceWindowsAsync(
            ImportAbsenceWindows arg)
        {
            return Client.PostAsync<ImportAbsenceWindows, ImportAbsenceWindowsResponse>(this.username, this.password,
                this.baseuri, "AbsenceWindowService", arg, this.timeoutSeconds);
        }
    }
}