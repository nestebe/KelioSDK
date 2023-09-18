//.ReaderGroupServiceClient


using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
    public class ReaderGroupServiceClient
    {
        private const string service = "ReaderGroupService";
        private readonly string username;
        private readonly string password;
        private readonly string baseuri;
        private readonly int timeoutSeconds;

        public ReaderGroupServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
        {
            this.username = username;
            this.password = password;
            this.baseuri = baseuri;
            this.timeoutSeconds = timeoutSeconds;
        }

        public ExportReaderGroupContentsResponse ExportReaderGroupContents(
            ExportReaderGroupContents arg)
        {
            return Client.Post<ExportReaderGroupContents, ExportReaderGroupContentsResponse>(this.username,
                this.password, this.baseuri, "ReaderGroupService", arg, this.timeoutSeconds);
        }

        public Task<ExportReaderGroupContentsResponse> ExportReaderGroupContentsAsync(
            ExportReaderGroupContents arg)
        {
            return Client.PostAsync<ExportReaderGroupContents, ExportReaderGroupContentsResponse>(this.username,
                this.password, this.baseuri, "ReaderGroupService", arg, this.timeoutSeconds);
        }

        public ImportReaderGroupsResponse ImportReaderGroups(
            ImportReaderGroups arg)
        {
            return Client.Post<ImportReaderGroups, ImportReaderGroupsResponse>(this.username, this.password,
                this.baseuri, "ReaderGroupService", arg, this.timeoutSeconds);
        }

        public Task<ImportReaderGroupsResponse> ImportReaderGroupsAsync(
            ImportReaderGroups arg)
        {
            return Client.PostAsync<ImportReaderGroups, ImportReaderGroupsResponse>(this.username, this.password,
                this.baseuri, "ReaderGroupService", arg, this.timeoutSeconds);
        }
    }
}