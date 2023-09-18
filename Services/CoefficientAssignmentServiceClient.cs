//.CoefficientAssignmentServiceClient


using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
    public class CoefficientAssignmentServiceClient
    {
        private const string service = "CoefficientAssignmentService";
        private readonly string username;
        private readonly string password;
        private readonly string baseuri;
        private readonly int timeoutSeconds;

        public CoefficientAssignmentServiceClient(string username, string password, string baseuri,
            int timeoutSeconds = 60)
        {
            this.username = username;
            this.password = password;
            this.baseuri = baseuri;
            this.timeoutSeconds = timeoutSeconds;
        }

        public ImportCoefficientAssignmentsResponse ImportCoefficientAssignments(
            ImportCoefficientAssignments arg)
        {
            return Client.Post<ImportCoefficientAssignments, ImportCoefficientAssignmentsResponse>(this.username,
                this.password, this.baseuri, "CoefficientAssignmentService", arg, this.timeoutSeconds);
        }

        public Task<ImportCoefficientAssignmentsResponse> ImportCoefficientAssignmentsAsync(
            ImportCoefficientAssignments arg)
        {
            return Client.PostAsync<ImportCoefficientAssignments, ImportCoefficientAssignmentsResponse>(this.username,
                this.password, this.baseuri, "CoefficientAssignmentService", arg, this.timeoutSeconds);
        }

        public ExportCoefficientAssignmentsListResponse ExportCoefficientAssignmentsList(
            ExportCoefficientAssignmentsList arg)
        {
            return Client.Post<ExportCoefficientAssignmentsList, ExportCoefficientAssignmentsListResponse>(
                this.username, this.password, this.baseuri, "CoefficientAssignmentService", arg, this.timeoutSeconds);
        }

        public Task<ExportCoefficientAssignmentsListResponse> ExportCoefficientAssignmentsListAsync(
            ExportCoefficientAssignmentsList arg)
        {
            return Client.PostAsync<ExportCoefficientAssignmentsList, ExportCoefficientAssignmentsListResponse>(
                this.username, this.password, this.baseuri, "CoefficientAssignmentService", arg, this.timeoutSeconds);
        }

        public ExportCoefficientAssignmentsResponse ExportCoefficientAssignments(
            ExportCoefficientAssignments arg)
        {
            return Client.Post<ExportCoefficientAssignments, ExportCoefficientAssignmentsResponse>(this.username,
                this.password, this.baseuri, "CoefficientAssignmentService", arg, this.timeoutSeconds);
        }

        public Task<ExportCoefficientAssignmentsResponse> ExportCoefficientAssignmentsAsync(
            ExportCoefficientAssignments arg)
        {
            return Client.PostAsync<ExportCoefficientAssignments, ExportCoefficientAssignmentsResponse>(this.username,
                this.password, this.baseuri, "CoefficientAssignmentService", arg, this.timeoutSeconds);
        }
    }
}