//.WorkDurationAssignmentServiceClient


using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
    public class WorkDurationAssignmentServiceClient
    {
        private const string service = "WorkDurationAssignmentService";
        private readonly string username;
        private readonly string password;
        private readonly string baseuri;
        private readonly int timeoutSeconds;

        public WorkDurationAssignmentServiceClient(string username, string password, string baseuri,
            int timeoutSeconds = 60)
        {
            this.username = username;
            this.password = password;
            this.baseuri = baseuri;
            this.timeoutSeconds = timeoutSeconds;
        }

        public ExportWorkDurationAssignmentsResponse ExportWorkDurationAssignments(
            ExportWorkDurationAssignments arg)
        {
            return Client.Post<ExportWorkDurationAssignments, ExportWorkDurationAssignmentsResponse>(this.username,
                this.password, this.baseuri, "WorkDurationAssignmentService", arg, this.timeoutSeconds);
        }

        public Task<ExportWorkDurationAssignmentsResponse> ExportWorkDurationAssignmentsAsync(
            ExportWorkDurationAssignments arg)
        {
            return Client.PostAsync<ExportWorkDurationAssignments, ExportWorkDurationAssignmentsResponse>(this.username,
                this.password, this.baseuri, "WorkDurationAssignmentService", arg, this.timeoutSeconds);
        }

        public DeleteWorkDurationAssignmentsResponse DeleteWorkDurationAssignments(
            DeleteWorkDurationAssignments arg)
        {
            return Client.Post<DeleteWorkDurationAssignments, DeleteWorkDurationAssignmentsResponse>(this.username,
                this.password, this.baseuri, "WorkDurationAssignmentService", arg, this.timeoutSeconds);
        }

        public Task<DeleteWorkDurationAssignmentsResponse> DeleteWorkDurationAssignmentsAsync(
            DeleteWorkDurationAssignments arg)
        {
            return Client.PostAsync<DeleteWorkDurationAssignments, DeleteWorkDurationAssignmentsResponse>(this.username,
                this.password, this.baseuri, "WorkDurationAssignmentService", arg, this.timeoutSeconds);
        }

        public ImportWorkDurationAssignmentsResponse ImportWorkDurationAssignments(
            ImportWorkDurationAssignments arg)
        {
            return Client.Post<ImportWorkDurationAssignments, ImportWorkDurationAssignmentsResponse>(this.username,
                this.password, this.baseuri, "WorkDurationAssignmentService", arg, this.timeoutSeconds);
        }

        public Task<ImportWorkDurationAssignmentsResponse> ImportWorkDurationAssignmentsAsync(
            ImportWorkDurationAssignments arg)
        {
            return Client.PostAsync<ImportWorkDurationAssignments, ImportWorkDurationAssignmentsResponse>(this.username,
                this.password, this.baseuri, "WorkDurationAssignmentService", arg, this.timeoutSeconds);
        }
    }
}