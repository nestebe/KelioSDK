//.SpecialHoursWindowServiceClient


using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
    public class SpecialHoursWindowServiceClient
    {
        private const string service = "SpecialHoursWindowService";
        private readonly string username;
        private readonly string password;
        private readonly string baseuri;
        private readonly int timeoutSeconds;

        public SpecialHoursWindowServiceClient(string username, string password, string baseuri,
            int timeoutSeconds = 60)
        {
            this.username = username;
            this.password = password;
            this.baseuri = baseuri;
            this.timeoutSeconds = timeoutSeconds;
        }

        public ExportSpecialHoursWindowsResponse ExportSpecialHoursWindows(
            ExportSpecialHoursWindows arg)
        {
            return Client.Post<ExportSpecialHoursWindows, ExportSpecialHoursWindowsResponse>(this.username,
                this.password, this.baseuri, "SpecialHoursWindowService", arg, this.timeoutSeconds);
        }

        public Task<ExportSpecialHoursWindowsResponse> ExportSpecialHoursWindowsAsync(
            ExportSpecialHoursWindows arg)
        {
            return Client.PostAsync<ExportSpecialHoursWindows, ExportSpecialHoursWindowsResponse>(this.username,
                this.password, this.baseuri, "SpecialHoursWindowService", arg, this.timeoutSeconds);
        }

        public ExportSpecialHoursWindowsListResponse ExportSpecialHoursWindowsList(
            ExportSpecialHoursWindowsList arg)
        {
            return Client.Post<ExportSpecialHoursWindowsList, ExportSpecialHoursWindowsListResponse>(this.username,
                this.password, this.baseuri, "SpecialHoursWindowService", arg, this.timeoutSeconds);
        }

        public Task<ExportSpecialHoursWindowsListResponse> ExportSpecialHoursWindowsListAsync(
            ExportSpecialHoursWindowsList arg)
        {
            return Client.PostAsync<ExportSpecialHoursWindowsList, ExportSpecialHoursWindowsListResponse>(this.username,
                this.password, this.baseuri, "SpecialHoursWindowService", arg, this.timeoutSeconds);
        }

        public ImportSpecialHoursWindowsResponse ImportSpecialHoursWindows(
            ImportSpecialHoursWindows arg)
        {
            return Client.Post<ImportSpecialHoursWindows, ImportSpecialHoursWindowsResponse>(this.username,
                this.password, this.baseuri, "SpecialHoursWindowService", arg, this.timeoutSeconds);
        }

        public Task<ImportSpecialHoursWindowsResponse> ImportSpecialHoursWindowsAsync(
            ImportSpecialHoursWindows arg)
        {
            return Client.PostAsync<ImportSpecialHoursWindows, ImportSpecialHoursWindowsResponse>(this.username,
                this.password, this.baseuri, "SpecialHoursWindowService", arg, this.timeoutSeconds);
        }
    }
}