//.PopulationServiceClient


using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
    public class PopulationServiceClient
    {
        private const string service = "PopulationService";
        private readonly string username;
        private readonly string password;
        private readonly string baseuri;
        private readonly int timeoutSeconds;

        public PopulationServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
        {
            this.username = username;
            this.password = password;
            this.baseuri = baseuri;
            this.timeoutSeconds = timeoutSeconds;
        }

        public ImportMixedPopulationResponse ImportMixedPopulation(
            ImportMixedPopulation arg)
        {
            return Client.Post<ImportMixedPopulation, ImportMixedPopulationResponse>(this.username, this.password,
                this.baseuri, "PopulationService", arg, this.timeoutSeconds);
        }

        public Task<ImportMixedPopulationResponse> ImportMixedPopulationAsync(
            ImportMixedPopulation arg)
        {
            return Client.PostAsync<ImportMixedPopulation, ImportMixedPopulationResponse>(this.username, this.password,
                this.baseuri, "PopulationService", arg, this.timeoutSeconds);
        }

        public ExportPopulationDescriptionsResponse ExportPopulationDescriptions(
            ExportPopulationDescriptions arg)
        {
            return Client.Post<ExportPopulationDescriptions, ExportPopulationDescriptionsResponse>(this.username,
                this.password, this.baseuri, "PopulationService", arg, this.timeoutSeconds);
        }

        public Task<ExportPopulationDescriptionsResponse> ExportPopulationDescriptionsAsync(
            ExportPopulationDescriptions arg)
        {
            return Client.PostAsync<ExportPopulationDescriptions, ExportPopulationDescriptionsResponse>(this.username,
                this.password, this.baseuri, "PopulationService", arg, this.timeoutSeconds);
        }

        public ExportPopulationResponse ExportPopulation(ExportPopulation arg)
        {
            return Client.Post<ExportPopulation, ExportPopulationResponse>(this.username, this.password, this.baseuri,
                "PopulationService", arg, this.timeoutSeconds);
        }

        public Task<ExportPopulationResponse> ExportPopulationAsync(
            ExportPopulation arg)
        {
            return Client.PostAsync<ExportPopulation, ExportPopulationResponse>(this.username, this.password,
                this.baseuri, "PopulationService", arg, this.timeoutSeconds);
        }
    }
}