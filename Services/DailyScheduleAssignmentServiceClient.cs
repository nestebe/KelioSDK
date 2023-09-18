//.DailyScheduleAssignmentServiceClient


using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
    public class DailyScheduleAssignmentServiceClient
    {
        private const string service = "DailyScheduleAssignmentService";
        private readonly string username;
        private readonly string password;
        private readonly string baseuri;
        private readonly int timeoutSeconds;

        public DailyScheduleAssignmentServiceClient(string username, string password, string baseuri,
            int timeoutSeconds = 60)
        {
            this.username = username;
            this.password = password;
            this.baseuri = baseuri;
            this.timeoutSeconds = timeoutSeconds;
        }

        public ExportDailyScheduleAssignmentsListResponse ExportDailyScheduleAssignmentsList(
            ExportDailyScheduleAssignmentsList arg)
        {
            return Client.Post<ExportDailyScheduleAssignmentsList, ExportDailyScheduleAssignmentsListResponse>(
                this.username, this.password, this.baseuri, "DailyScheduleAssignmentService", arg, this.timeoutSeconds);
        }

        public Task<ExportDailyScheduleAssignmentsListResponse> ExportDailyScheduleAssignmentsListAsync(
            ExportDailyScheduleAssignmentsList arg)
        {
            return Client.PostAsync<ExportDailyScheduleAssignmentsList, ExportDailyScheduleAssignmentsListResponse>(
                this.username, this.password, this.baseuri, "DailyScheduleAssignmentService", arg, this.timeoutSeconds);
        }

        public ExportDailyScheduleAssignmentsFromEmployeeListResponse ExportDailyScheduleAssignmentsFromEmployeeList(
            ExportDailyScheduleAssignmentsFromEmployeeList arg)
        {
            return Client
                .Post<ExportDailyScheduleAssignmentsFromEmployeeList,
                    ExportDailyScheduleAssignmentsFromEmployeeListResponse>(this.username, this.password, this.baseuri,
                    "DailyScheduleAssignmentService", arg, this.timeoutSeconds);
        }

        public Task<ExportDailyScheduleAssignmentsFromEmployeeListResponse>
            ExportDailyScheduleAssignmentsFromEmployeeListAsync(
                ExportDailyScheduleAssignmentsFromEmployeeList arg)
        {
            return Client
                .PostAsync<ExportDailyScheduleAssignmentsFromEmployeeList,
                    ExportDailyScheduleAssignmentsFromEmployeeListResponse>(this.username, this.password, this.baseuri,
                    "DailyScheduleAssignmentService", arg, this.timeoutSeconds);
        }

        public ExportDailyScheduleAssignmentsResponse ExportDailyScheduleAssignments(
            ExportDailyScheduleAssignments arg)
        {
            return Client.Post<ExportDailyScheduleAssignments, ExportDailyScheduleAssignmentsResponse>(this.username,
                this.password, this.baseuri, "DailyScheduleAssignmentService", arg, this.timeoutSeconds);
        }

        public Task<ExportDailyScheduleAssignmentsResponse> ExportDailyScheduleAssignmentsAsync(
            ExportDailyScheduleAssignments arg)
        {
            return Client.PostAsync<ExportDailyScheduleAssignments, ExportDailyScheduleAssignmentsResponse>(
                this.username, this.password, this.baseuri, "DailyScheduleAssignmentService", arg, this.timeoutSeconds);
        }

        public ImportDailyScheduleAssignmentsResponse ImportDailyScheduleAssignments(
            ImportDailyScheduleAssignments arg)
        {
            return Client.Post<ImportDailyScheduleAssignments, ImportDailyScheduleAssignmentsResponse>(this.username,
                this.password, this.baseuri, "DailyScheduleAssignmentService", arg, this.timeoutSeconds);
        }

        public Task<ImportDailyScheduleAssignmentsResponse> ImportDailyScheduleAssignmentsAsync(
            ImportDailyScheduleAssignments arg)
        {
            return Client.PostAsync<ImportDailyScheduleAssignments, ImportDailyScheduleAssignmentsResponse>(
                this.username, this.password, this.baseuri, "DailyScheduleAssignmentService", arg, this.timeoutSeconds);
        }

        public DeleteDailyScheduleAssignmentsResponse DeleteDailyScheduleAssignments(
            DeleteDailyScheduleAssignments arg)
        {
            return Client.Post<DeleteDailyScheduleAssignments, DeleteDailyScheduleAssignmentsResponse>(this.username,
                this.password, this.baseuri, "DailyScheduleAssignmentService", arg, this.timeoutSeconds);
        }

        public Task<DeleteDailyScheduleAssignmentsResponse> DeleteDailyScheduleAssignmentsAsync(
            DeleteDailyScheduleAssignments arg)
        {
            return Client.PostAsync<DeleteDailyScheduleAssignments, DeleteDailyScheduleAssignmentsResponse>(
                this.username, this.password, this.baseuri, "DailyScheduleAssignmentService", arg, this.timeoutSeconds);
        }
    }
}