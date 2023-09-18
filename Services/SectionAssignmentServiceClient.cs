//.SectionAssignmentServiceClient


using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
    public class SectionAssignmentServiceClient
    {
        private const string service = "SectionAssignmentService";
        private readonly string username;
        private readonly string password;
        private readonly string baseuri;
        private readonly int timeoutSeconds;

        public SectionAssignmentServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
        {
            this.username = username;
            this.password = password;
            this.baseuri = baseuri;
            this.timeoutSeconds = timeoutSeconds;
        }

        public ImportSectionAssignmentsResponse ImportSectionAssignments(
            ImportSectionAssignments arg)
        {
            return Client.Post<ImportSectionAssignments, ImportSectionAssignmentsResponse>(this.username, this.password,
                this.baseuri, "SectionAssignmentService", arg, this.timeoutSeconds);
        }

        public Task<ImportSectionAssignmentsResponse> ImportSectionAssignmentsAsync(
            ImportSectionAssignments arg)
        {
            return Client.PostAsync<ImportSectionAssignments, ImportSectionAssignmentsResponse>(this.username,
                this.password, this.baseuri, "SectionAssignmentService", arg, this.timeoutSeconds);
        }

        public ExportSectionAssignmentsResponse ExportSectionAssignments(
            ExportSectionAssignments arg)
        {
            return Client.Post<ExportSectionAssignments, ExportSectionAssignmentsResponse>(this.username, this.password,
                this.baseuri, "SectionAssignmentService", arg, this.timeoutSeconds);
        }

        public Task<ExportSectionAssignmentsResponse> ExportSectionAssignmentsAsync(
            ExportSectionAssignments arg)
        {
            return Client.PostAsync<ExportSectionAssignments, ExportSectionAssignmentsResponse>(this.username,
                this.password, this.baseuri, "SectionAssignmentService", arg, this.timeoutSeconds);
        }

        public ExportSectionAssignmentsListResponse ExportSectionAssignmentsList(
            ExportSectionAssignmentsList arg)
        {
            return Client.Post<ExportSectionAssignmentsList, ExportSectionAssignmentsListResponse>(this.username,
                this.password, this.baseuri, "SectionAssignmentService", arg, this.timeoutSeconds);
        }

        public Task<ExportSectionAssignmentsListResponse> ExportSectionAssignmentsListAsync(
            ExportSectionAssignmentsList arg)
        {
            return Client.PostAsync<ExportSectionAssignmentsList, ExportSectionAssignmentsListResponse>(this.username,
                this.password, this.baseuri, "SectionAssignmentService", arg, this.timeoutSeconds);
        }
    }
}