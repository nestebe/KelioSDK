//.SkillAssignmentServiceClient


using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
    public class SkillAssignmentServiceClient
    {
        private const string service = "SkillAssignmentService";
        private readonly string username;
        private readonly string password;
        private readonly string baseuri;
        private readonly int timeoutSeconds;

        public SkillAssignmentServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
        {
            this.username = username;
            this.password = password;
            this.baseuri = baseuri;
            this.timeoutSeconds = timeoutSeconds;
        }

        public ExportSkillAssignmentsResponse ExportSkillAssignments(
            ExportSkillAssignments arg)
        {
            return Client.Post<ExportSkillAssignments, ExportSkillAssignmentsResponse>(this.username, this.password,
                this.baseuri, "SkillAssignmentService", arg, this.timeoutSeconds);
        }

        public Task<ExportSkillAssignmentsResponse> ExportSkillAssignmentsAsync(
            ExportSkillAssignments arg)
        {
            return Client.PostAsync<ExportSkillAssignments, ExportSkillAssignmentsResponse>(this.username,
                this.password, this.baseuri, "SkillAssignmentService", arg, this.timeoutSeconds);
        }

        public ExportSkillAssignmentsListResponse ExportSkillAssignmentsList(
            ExportSkillAssignmentsList arg)
        {
            return Client.Post<ExportSkillAssignmentsList, ExportSkillAssignmentsListResponse>(this.username,
                this.password, this.baseuri, "SkillAssignmentService", arg, this.timeoutSeconds);
        }

        public Task<ExportSkillAssignmentsListResponse> ExportSkillAssignmentsListAsync(
            ExportSkillAssignmentsList arg)
        {
            return Client.PostAsync<ExportSkillAssignmentsList, ExportSkillAssignmentsListResponse>(this.username,
                this.password, this.baseuri, "SkillAssignmentService", arg, this.timeoutSeconds);
        }

        public ImportSkillAssignmentsResponse ImportSkillAssignments(
            ImportSkillAssignments arg)
        {
            return Client.Post<ImportSkillAssignments, ImportSkillAssignmentsResponse>(this.username, this.password,
                this.baseuri, "SkillAssignmentService", arg, this.timeoutSeconds);
        }

        public Task<ImportSkillAssignmentsResponse> ImportSkillAssignmentsAsync(
            ImportSkillAssignments arg)
        {
            return Client.PostAsync<ImportSkillAssignments, ImportSkillAssignmentsResponse>(this.username,
                this.password, this.baseuri, "SkillAssignmentService", arg, this.timeoutSeconds);
        }
    }
}