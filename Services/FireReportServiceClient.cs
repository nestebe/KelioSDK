//.FireReportServiceClient


using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
    public class FireReportServiceClient
    {
        private const string service = "FireReportService";
        private readonly string username;
        private readonly string password;
        private readonly string baseuri;
        private readonly int timeoutSeconds;

        public FireReportServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
        {
            this.username = username;
            this.password = password;
            this.baseuri = baseuri;
            this.timeoutSeconds = timeoutSeconds;
        }

        public ExportDetailFireReportPeoplePresentResponse ExportDetailFireReportPeoplePresent(
            ExportDetailFireReportPeoplePresent arg)
        {
            return Client.Post<ExportDetailFireReportPeoplePresent, ExportDetailFireReportPeoplePresentResponse>(
                this.username, this.password, this.baseuri, "FireReportService", arg, this.timeoutSeconds);
        }

        public Task<ExportDetailFireReportPeoplePresentResponse> ExportDetailFireReportPeoplePresentAsync(
            ExportDetailFireReportPeoplePresent arg)
        {
            return Client.PostAsync<ExportDetailFireReportPeoplePresent, ExportDetailFireReportPeoplePresentResponse>(
                this.username, this.password, this.baseuri, "FireReportService", arg, this.timeoutSeconds);
        }

        public ExportFireReportPeoplePresentResponse ExportFireReportPeoplePresent(
            ExportFireReportPeoplePresent arg)
        {
            return Client.Post<ExportFireReportPeoplePresent, ExportFireReportPeoplePresentResponse>(this.username,
                this.password, this.baseuri, "FireReportService", arg, this.timeoutSeconds);
        }

        public Task<ExportFireReportPeoplePresentResponse> ExportFireReportPeoplePresentAsync(
            ExportFireReportPeoplePresent arg)
        {
            return Client.PostAsync<ExportFireReportPeoplePresent, ExportFireReportPeoplePresentResponse>(this.username,
                this.password, this.baseuri, "FireReportService", arg, this.timeoutSeconds);
        }
    }
}