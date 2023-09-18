//.HourlyRateServiceClient


using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
    public class HourlyRateServiceClient
    {
        private const string service = "HourlyRateService";
        private readonly string username;
        private readonly string password;
        private readonly string baseuri;
        private readonly int timeoutSeconds;

        public HourlyRateServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
        {
            this.username = username;
            this.password = password;
            this.baseuri = baseuri;
            this.timeoutSeconds = timeoutSeconds;
        }

        public ExportHourlyRatesListResponse ExportHourlyRatesList(
            ExportHourlyRatesList arg)
        {
            return Client.Post<ExportHourlyRatesList, ExportHourlyRatesListResponse>(this.username, this.password,
                this.baseuri, "HourlyRateService", arg, this.timeoutSeconds);
        }

        public Task<ExportHourlyRatesListResponse> ExportHourlyRatesListAsync(
            ExportHourlyRatesList arg)
        {
            return Client.PostAsync<ExportHourlyRatesList, ExportHourlyRatesListResponse>(this.username, this.password,
                this.baseuri, "HourlyRateService", arg, this.timeoutSeconds);
        }

        public ExportHourlyRatesResponse ExportHourlyRates(
            ExportHourlyRates arg)
        {
            return Client.Post<ExportHourlyRates, ExportHourlyRatesResponse>(this.username, this.password, this.baseuri,
                "HourlyRateService", arg, this.timeoutSeconds);
        }

        public Task<ExportHourlyRatesResponse> ExportHourlyRatesAsync(
            ExportHourlyRates arg)
        {
            return Client.PostAsync<ExportHourlyRates, ExportHourlyRatesResponse>(this.username, this.password,
                this.baseuri, "HourlyRateService", arg, this.timeoutSeconds);
        }

        public ImportHourlyRatesResponse ImportHourlyRates(
            ImportHourlyRates arg)
        {
            return Client.Post<ImportHourlyRates, ImportHourlyRatesResponse>(this.username, this.password, this.baseuri,
                "HourlyRateService", arg, this.timeoutSeconds);
        }

        public Task<ImportHourlyRatesResponse> ImportHourlyRatesAsync(
            ImportHourlyRates arg)
        {
            return Client.PostAsync<ImportHourlyRates, ImportHourlyRatesResponse>(this.username, this.password,
                this.baseuri, "HourlyRateService", arg, this.timeoutSeconds);
        }
    }
}