//.PostJobAndSkillAssignmentServiceClient


using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
    public class PostJobAndSkillAssignmentServiceClient
    {
        private const string service = "PostJobAndSkillAssignmentService";
        private readonly string username;
        private readonly string password;
        private readonly string baseuri;
        private readonly int timeoutSeconds;

        public PostJobAndSkillAssignmentServiceClient(string username, string password, string baseuri,
            int timeoutSeconds = 60)
        {
            this.username = username;
            this.password = password;
            this.baseuri = baseuri;
            this.timeoutSeconds = timeoutSeconds;
        }

        public ExportPostJobAndSkillAssignmentResponse ExportPostJobAndSkillAssignment(
            ExportPostJobAndSkillAssignment arg)
        {
            return Client.Post<ExportPostJobAndSkillAssignment, ExportPostJobAndSkillAssignmentResponse>(this.username,
                this.password, this.baseuri, "PostJobAndSkillAssignmentService", arg, this.timeoutSeconds);
        }

        public Task<ExportPostJobAndSkillAssignmentResponse> ExportPostJobAndSkillAssignmentAsync(
            ExportPostJobAndSkillAssignment arg)
        {
            return Client.PostAsync<ExportPostJobAndSkillAssignment, ExportPostJobAndSkillAssignmentResponse>(
                this.username, this.password, this.baseuri, "PostJobAndSkillAssignmentService", arg,
                this.timeoutSeconds);
        }
    }
}