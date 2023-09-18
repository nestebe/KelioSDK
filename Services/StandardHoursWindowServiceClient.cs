//.StandardHoursWindowServiceClient


using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
    public class StandardHoursWindowServiceClient
    {
        private const string service = "StandardHoursWindowService";
        private readonly string username;
        private readonly string password;
        private readonly string baseuri;
        private readonly int timeoutSeconds;

        public StandardHoursWindowServiceClient(string username, string password, string baseuri,
            int timeoutSeconds = 60)
        {
            this.username = username;
            this.password = password;
            this.baseuri = baseuri;
            this.timeoutSeconds = timeoutSeconds;
        }

        public ImportStandardHoursWindowsResponse ImportStandardHoursWindows(
            ImportStandardHoursWindows arg)
        {
            return Client.Post<ImportStandardHoursWindows, ImportStandardHoursWindowsResponse>(this.username,
                this.password, this.baseuri, "StandardHoursWindowService", arg, this.timeoutSeconds);
        }

        public Task<ImportStandardHoursWindowsResponse> ImportStandardHoursWindowsAsync(
            ImportStandardHoursWindows arg)
        {
            return Client.PostAsync<ImportStandardHoursWindows, ImportStandardHoursWindowsResponse>(this.username,
                this.password, this.baseuri, "StandardHoursWindowService", arg, this.timeoutSeconds);
        }

        public ExportStandardHoursWindowsListResponse ExportStandardHoursWindowsList(
            ExportStandardHoursWindowsList arg)
        {
            return Client.Post<ExportStandardHoursWindowsList, ExportStandardHoursWindowsListResponse>(this.username,
                this.password, this.baseuri, "StandardHoursWindowService", arg, this.timeoutSeconds);
        }

        public Task<ExportStandardHoursWindowsListResponse> ExportStandardHoursWindowsListAsync(
            ExportStandardHoursWindowsList arg)
        {
            return Client.PostAsync<ExportStandardHoursWindowsList, ExportStandardHoursWindowsListResponse>(
                this.username, this.password, this.baseuri, "StandardHoursWindowService", arg, this.timeoutSeconds);
        }

        public ExportStandardHoursWindowsResponse ExportStandardHoursWindows(
            ExportStandardHoursWindows arg)
        {
            return Client.Post<ExportStandardHoursWindows, ExportStandardHoursWindowsResponse>(this.username,
                this.password, this.baseuri, "StandardHoursWindowService", arg, this.timeoutSeconds);
        }

        public Task<ExportStandardHoursWindowsResponse> ExportStandardHoursWindowsAsync(
            ExportStandardHoursWindows arg)
        {
            return Client.PostAsync<ExportStandardHoursWindows, ExportStandardHoursWindowsResponse>(this.username,
                this.password, this.baseuri, "StandardHoursWindowService", arg, this.timeoutSeconds);
        }
    }
}