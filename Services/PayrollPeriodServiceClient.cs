//.PayrollPeriodServiceClient


using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
    public class PayrollPeriodServiceClient
    {
        private const string service = "PayrollPeriodService";
        private readonly string username;
        private readonly string password;
        private readonly string baseuri;
        private readonly int timeoutSeconds;

        public PayrollPeriodServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
        {
            this.username = username;
            this.password = password;
            this.baseuri = baseuri;
            this.timeoutSeconds = timeoutSeconds;
        }

        public ExportPayrollPeriodsResponse ExportPayrollPeriods(
            ExportPayrollPeriods arg)
        {
            return Client.Post<ExportPayrollPeriods, ExportPayrollPeriodsResponse>(this.username, this.password,
                this.baseuri, "PayrollPeriodService", arg, this.timeoutSeconds);
        }

        public Task<ExportPayrollPeriodsResponse> ExportPayrollPeriodsAsync(
            ExportPayrollPeriods arg)
        {
            return Client.PostAsync<ExportPayrollPeriods, ExportPayrollPeriodsResponse>(this.username, this.password,
                this.baseuri, "PayrollPeriodService", arg, this.timeoutSeconds);
        }
    }
}