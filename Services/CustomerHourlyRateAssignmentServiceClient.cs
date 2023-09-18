//.CustomerHourlyRateAssignmentServiceClient


using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
    public class CustomerHourlyRateAssignmentServiceClient
    {
        private const string service = "CustomerHourlyRateAssignmentService";
        private readonly string username;
        private readonly string password;
        private readonly string baseuri;
        private readonly int timeoutSeconds;

        public CustomerHourlyRateAssignmentServiceClient(
            string username,
            string password,
            string baseuri, int timeoutSeconds = 60)
        {
            this.username = username;
            this.password = password;
            this.baseuri = baseuri;
            this.timeoutSeconds = timeoutSeconds;
        }

        public ExportCustomerHourlyRateAssignmentsListResponse ExportCustomerHourlyRateAssignmentsList(
            ExportCustomerHourlyRateAssignmentsList arg)
        {
            return Client
                .Post<ExportCustomerHourlyRateAssignmentsList, ExportCustomerHourlyRateAssignmentsListResponse>(
                    this.username, this.password, this.baseuri, "CustomerHourlyRateAssignmentService", arg,
                    this.timeoutSeconds);
        }

        public Task<ExportCustomerHourlyRateAssignmentsListResponse> ExportCustomerHourlyRateAssignmentsListAsync(
            ExportCustomerHourlyRateAssignmentsList arg)
        {
            return Client
                .PostAsync<ExportCustomerHourlyRateAssignmentsList, ExportCustomerHourlyRateAssignmentsListResponse>(
                    this.username, this.password, this.baseuri, "CustomerHourlyRateAssignmentService", arg,
                    this.timeoutSeconds);
        }

        public ImportCustomerHourlyRateAssignmentsResponse ImportCustomerHourlyRateAssignments(
            ImportCustomerHourlyRateAssignments arg)
        {
            return Client.Post<ImportCustomerHourlyRateAssignments, ImportCustomerHourlyRateAssignmentsResponse>(
                this.username, this.password, this.baseuri, "CustomerHourlyRateAssignmentService", arg,
                this.timeoutSeconds);
        }

        public Task<ImportCustomerHourlyRateAssignmentsResponse> ImportCustomerHourlyRateAssignmentsAsync(
            ImportCustomerHourlyRateAssignments arg)
        {
            return Client.PostAsync<ImportCustomerHourlyRateAssignments, ImportCustomerHourlyRateAssignmentsResponse>(
                this.username, this.password, this.baseuri, "CustomerHourlyRateAssignmentService", arg,
                this.timeoutSeconds);
        }
    }
}