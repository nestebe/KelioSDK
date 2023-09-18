//.UserProfileAssignmentServiceClient


using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
    public class UserProfileAssignmentServiceClient
    {
        private const string service = "UserProfileAssignmentService";
        private readonly string username;
        private readonly string password;
        private readonly string baseuri;
        private readonly int timeoutSeconds;

        public UserProfileAssignmentServiceClient(string username, string password, string baseuri,
            int timeoutSeconds = 60)
        {
            this.username = username;
            this.password = password;
            this.baseuri = baseuri;
            this.timeoutSeconds = timeoutSeconds;
        }

        public ExportUserProfileAssignmentsResponse ExportUserProfileAssignments(
            ExportUserProfileAssignments arg)
        {
            return Client.Post<ExportUserProfileAssignments, ExportUserProfileAssignmentsResponse>(this.username,
                this.password, this.baseuri, "UserProfileAssignmentService", arg, this.timeoutSeconds);
        }

        public Task<ExportUserProfileAssignmentsResponse> ExportUserProfileAssignmentsAsync(
            ExportUserProfileAssignments arg)
        {
            return Client.PostAsync<ExportUserProfileAssignments, ExportUserProfileAssignmentsResponse>(this.username,
                this.password, this.baseuri, "UserProfileAssignmentService", arg, this.timeoutSeconds);
        }

        public ExportUserProfileAssignmentsListResponse ExportUserProfileAssignmentsList(
            ExportUserProfileAssignmentsList arg)
        {
            return Client.Post<ExportUserProfileAssignmentsList, ExportUserProfileAssignmentsListResponse>(
                this.username, this.password, this.baseuri, "UserProfileAssignmentService", arg, this.timeoutSeconds);
        }

        public Task<ExportUserProfileAssignmentsListResponse> ExportUserProfileAssignmentsListAsync(
            ExportUserProfileAssignmentsList arg)
        {
            return Client.PostAsync<ExportUserProfileAssignmentsList, ExportUserProfileAssignmentsListResponse>(
                this.username, this.password, this.baseuri, "UserProfileAssignmentService", arg, this.timeoutSeconds);
        }

        public ImportUserProfileAssignmentsResponse ImportUserProfileAssignments(
            ImportUserProfileAssignments arg)
        {
            return Client.Post<ImportUserProfileAssignments, ImportUserProfileAssignmentsResponse>(this.username,
                this.password, this.baseuri, "UserProfileAssignmentService", arg, this.timeoutSeconds);
        }

        public Task<ImportUserProfileAssignmentsResponse> ImportUserProfileAssignmentsAsync(
            ImportUserProfileAssignments arg)
        {
            return Client.PostAsync<ImportUserProfileAssignments, ImportUserProfileAssignmentsResponse>(this.username,
                this.password, this.baseuri, "UserProfileAssignmentService", arg, this.timeoutSeconds);
        }
    }
}