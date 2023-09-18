//.ScheduleAssignmentServiceClient


using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
    public class ScheduleAssignmentServiceClient
    {
        private const string service = "ScheduleAssignmentService";
        private readonly string username;
        private readonly string password;
        private readonly string baseuri;
        private readonly int timeoutSeconds;

        public ScheduleAssignmentServiceClient(string username, string password, string baseuri,
            int timeoutSeconds = 60)
        {
            this.username = username;
            this.password = password;
            this.baseuri = baseuri;
            this.timeoutSeconds = timeoutSeconds;
        }

        public ImportScheduleAssignmentsResponse ImportScheduleAssignments(
            ImportScheduleAssignments arg)
        {
            return Client.Post<ImportScheduleAssignments, ImportScheduleAssignmentsResponse>(this.username,
                this.password, this.baseuri, "ScheduleAssignmentService", arg, this.timeoutSeconds);
        }

        public Task<ImportScheduleAssignmentsResponse> ImportScheduleAssignmentsAsync(
            ImportScheduleAssignments arg)
        {
            return Client.PostAsync<ImportScheduleAssignments, ImportScheduleAssignmentsResponse>(this.username,
                this.password, this.baseuri, "ScheduleAssignmentService", arg, this.timeoutSeconds);
        }

        public ExportScheduleAssignmentsResponse ExportScheduleAssignments(
            ExportScheduleAssignments arg)
        {
            return Client.Post<ExportScheduleAssignments, ExportScheduleAssignmentsResponse>(this.username,
                this.password, this.baseuri, "ScheduleAssignmentService", arg, this.timeoutSeconds);
        }

        public Task<ExportScheduleAssignmentsResponse> ExportScheduleAssignmentsAsync(
            ExportScheduleAssignments arg)
        {
            return Client.PostAsync<ExportScheduleAssignments, ExportScheduleAssignmentsResponse>(this.username,
                this.password, this.baseuri, "ScheduleAssignmentService", arg, this.timeoutSeconds);
        }

        public ExportScheduleAssignmentsListResponse ExportScheduleAssignmentsList(
            ExportScheduleAssignmentsList arg)
        {
            return Client.Post<ExportScheduleAssignmentsList, ExportScheduleAssignmentsListResponse>(this.username,
                this.password, this.baseuri, "ScheduleAssignmentService", arg, this.timeoutSeconds);
        }

        public Task<ExportScheduleAssignmentsListResponse> ExportScheduleAssignmentsListAsync(
            ExportScheduleAssignmentsList arg)
        {
            return Client.PostAsync<ExportScheduleAssignmentsList, ExportScheduleAssignmentsListResponse>(this.username,
                this.password, this.baseuri, "ScheduleAssignmentService", arg, this.timeoutSeconds);
        }
    }
}