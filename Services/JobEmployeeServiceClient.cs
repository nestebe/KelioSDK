//.JobEmployeeServiceClient


using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
    public class JobEmployeeServiceClient
    {
        private const string service = "JobEmployeeService";
        private readonly string username;
        private readonly string password;
        private readonly string baseuri;
        private readonly int timeoutSeconds;

        public JobEmployeeServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
        {
            this.username = username;
            this.password = password;
            this.baseuri = baseuri;
            this.timeoutSeconds = timeoutSeconds;
        }

        public ImportJobsEmployeesResponse ImportJobsEmployees(
            ImportJobsEmployees arg)
        {
            return Client.Post<ImportJobsEmployees, ImportJobsEmployeesResponse>(this.username, this.password,
                this.baseuri, "JobEmployeeService", arg, this.timeoutSeconds);
        }

        public Task<ImportJobsEmployeesResponse> ImportJobsEmployeesAsync(
            ImportJobsEmployees arg)
        {
            return Client.PostAsync<ImportJobsEmployees, ImportJobsEmployeesResponse>(this.username, this.password,
                this.baseuri, "JobEmployeeService", arg, this.timeoutSeconds);
        }

        public ExportJobsEmployeesResponse ExportJobsEmployees(
            ExportJobsEmployees arg)
        {
            return Client.Post<ExportJobsEmployees, ExportJobsEmployeesResponse>(this.username, this.password,
                this.baseuri, "JobEmployeeService", arg, this.timeoutSeconds);
        }

        public Task<ExportJobsEmployeesResponse> ExportJobsEmployeesAsync(
            ExportJobsEmployees arg)
        {
            return Client.PostAsync<ExportJobsEmployees, ExportJobsEmployeesResponse>(this.username, this.password,
                this.baseuri, "JobEmployeeService", arg, this.timeoutSeconds);
        }
    }
}