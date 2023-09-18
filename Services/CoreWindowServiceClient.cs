//.CoreWindowServiceClient


using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
    public class CoreWindowServiceClient
    {
        private const string service = "CoreWindowService";
        private readonly string username;
        private readonly string password;
        private readonly string baseuri;
        private readonly int timeoutSeconds;

        public CoreWindowServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
        {
            this.username = username;
            this.password = password;
            this.baseuri = baseuri;
            this.timeoutSeconds = timeoutSeconds;
        }

        public ImportCoreWindowsResponse ImportCoreWindows(
            ImportCoreWindows arg)
        {
            return Client.Post<ImportCoreWindows, ImportCoreWindowsResponse>(this.username, this.password, this.baseuri,
                "CoreWindowService", arg, this.timeoutSeconds);
        }

        public Task<ImportCoreWindowsResponse> ImportCoreWindowsAsync(
            ImportCoreWindows arg)
        {
            return Client.PostAsync<ImportCoreWindows, ImportCoreWindowsResponse>(this.username, this.password,
                this.baseuri, "CoreWindowService", arg, this.timeoutSeconds);
        }

        public ExportCoreWindowsListResponse ExportCoreWindowsList(
            ExportCoreWindowsList arg)
        {
            return Client.Post<ExportCoreWindowsList, ExportCoreWindowsListResponse>(this.username, this.password,
                this.baseuri, "CoreWindowService", arg, this.timeoutSeconds);
        }

        public Task<ExportCoreWindowsListResponse> ExportCoreWindowsListAsync(
            ExportCoreWindowsList arg)
        {
            return Client.PostAsync<ExportCoreWindowsList, ExportCoreWindowsListResponse>(this.username, this.password,
                this.baseuri, "CoreWindowService", arg, this.timeoutSeconds);
        }

        public ExportCoreWindowsResponse ExportCoreWindows(
            ExportCoreWindows arg)
        {
            return Client.Post<ExportCoreWindows, ExportCoreWindowsResponse>(this.username, this.password, this.baseuri,
                "CoreWindowService", arg, this.timeoutSeconds);
        }

        public Task<ExportCoreWindowsResponse> ExportCoreWindowsAsync(
            ExportCoreWindows arg)
        {
            return Client.PostAsync<ExportCoreWindows, ExportCoreWindowsResponse>(this.username, this.password,
                this.baseuri, "CoreWindowService", arg, this.timeoutSeconds);
        }
    }
}