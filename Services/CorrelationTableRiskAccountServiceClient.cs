//.CorrelationTableRiskAccountServiceClient


using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
    public class CorrelationTableRiskAccountServiceClient
    {
        private const string service = "CorrelationTableRiskAccountService";
        private readonly string username;
        private readonly string password;
        private readonly string baseuri;
        private readonly int timeoutSeconds;

        public CorrelationTableRiskAccountServiceClient(
            string username,
            string password,
            string baseuri, int timeoutSeconds = 60)
        {
            this.username = username;
            this.password = password;
            this.baseuri = baseuri;
            this.timeoutSeconds = timeoutSeconds;
        }

        public ExportCorrelationTableRiskAccountResponse ExportCorrelationTableRiskAccount(
            ExportCorrelationTableRiskAccount arg)
        {
            return Client.Post<ExportCorrelationTableRiskAccount, ExportCorrelationTableRiskAccountResponse>(
                this.username, this.password, this.baseuri, "CorrelationTableRiskAccountService", arg,
                this.timeoutSeconds);
        }

        public Task<ExportCorrelationTableRiskAccountResponse> ExportCorrelationTableRiskAccountAsync(
            ExportCorrelationTableRiskAccount arg)
        {
            return Client.PostAsync<ExportCorrelationTableRiskAccount, ExportCorrelationTableRiskAccountResponse>(
                this.username, this.password, this.baseuri, "CorrelationTableRiskAccountService", arg,
                this.timeoutSeconds);
        }
    }
}