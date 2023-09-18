//.AssignmentPublicHolServiceClient


using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
    public class AssignmentPublicHolServiceClient
    {
        private const string service = "AssignmentPublicHolService";
        private readonly string username;
        private readonly string password;
        private readonly string baseuri;
        private readonly int timeoutSeconds;

        public AssignmentPublicHolServiceClient(string username, string password, string baseuri,
            int timeoutSeconds = 60)
        {
            this.username = username;
            this.password = password;
            this.baseuri = baseuri;
            this.timeoutSeconds = timeoutSeconds;
        }

        public ExportAssignmentPublicHolListResponse ExportAssignmentPublicHolList(
            ExportAssignmentPublicHolList arg)
        {
            return Client.Post<ExportAssignmentPublicHolList, ExportAssignmentPublicHolListResponse>(this.username,
                this.password, this.baseuri, "AssignmentPublicHolService", arg, this.timeoutSeconds);
        }

        public Task<ExportAssignmentPublicHolListResponse> ExportAssignmentPublicHolListAsync(
            ExportAssignmentPublicHolList arg)
        {
            return Client.PostAsync<ExportAssignmentPublicHolList, ExportAssignmentPublicHolListResponse>(this.username,
                this.password, this.baseuri, "AssignmentPublicHolService", arg, this.timeoutSeconds);
        }

        public ExportAssignmentPublicHolFromEmployeeListResponse ExportAssignmentPublicHolFromEmployeeList(
            ExportAssignmentPublicHolFromEmployeeList arg)
        {
            return Client
                .Post<ExportAssignmentPublicHolFromEmployeeList, ExportAssignmentPublicHolFromEmployeeListResponse>(
                    this.username, this.password, this.baseuri, "AssignmentPublicHolService", arg, this.timeoutSeconds);
        }

        public Task<ExportAssignmentPublicHolFromEmployeeListResponse> ExportAssignmentPublicHolFromEmployeeListAsync(
            ExportAssignmentPublicHolFromEmployeeList arg)
        {
            return Client
                .PostAsync<ExportAssignmentPublicHolFromEmployeeList,
                    ExportAssignmentPublicHolFromEmployeeListResponse>(this.username, this.password, this.baseuri,
                    "AssignmentPublicHolService", arg, this.timeoutSeconds);
        }

        public ExportAssignmentPublicHolResponse ExportAssignmentPublicHol(
            ExportAssignmentPublicHol arg)
        {
            return Client.Post<ExportAssignmentPublicHol, ExportAssignmentPublicHolResponse>(this.username,
                this.password, this.baseuri, "AssignmentPublicHolService", arg, this.timeoutSeconds);
        }

        public Task<ExportAssignmentPublicHolResponse> ExportAssignmentPublicHolAsync(
            ExportAssignmentPublicHol arg)
        {
            return Client.PostAsync<ExportAssignmentPublicHol, ExportAssignmentPublicHolResponse>(this.username,
                this.password, this.baseuri, "AssignmentPublicHolService", arg, this.timeoutSeconds);
        }
    }
}