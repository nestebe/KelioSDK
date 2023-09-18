//.PredefinedFieldServiceClient


using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
    public class PredefinedFieldServiceClient
    {
        private const string service = "PredefinedFieldService";
        private readonly string username;
        private readonly string password;
        private readonly string baseuri;
        private readonly int timeoutSeconds;

        public PredefinedFieldServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
        {
            this.username = username;
            this.password = password;
            this.baseuri = baseuri;
            this.timeoutSeconds = timeoutSeconds;
        }

        public ExportPredefinedFreeFieldsResponse ExportPredefinedFreeFields(
            ExportPredefinedFreeFields arg)
        {
            return Client.Post<ExportPredefinedFreeFields, ExportPredefinedFreeFieldsResponse>(this.username,
                this.password, this.baseuri, "PredefinedFieldService", arg, this.timeoutSeconds);
        }

        public Task<ExportPredefinedFreeFieldsResponse> ExportPredefinedFreeFieldsAsync(
            ExportPredefinedFreeFields arg)
        {
            return Client.PostAsync<ExportPredefinedFreeFields, ExportPredefinedFreeFieldsResponse>(this.username,
                this.password, this.baseuri, "PredefinedFieldService", arg, this.timeoutSeconds);
        }

        public ImportPredefinedFieldsResponse ImportPredefinedFields(
            ImportPredefinedFields arg)
        {
            return Client.Post<ImportPredefinedFields, ImportPredefinedFieldsResponse>(this.username, this.password,
                this.baseuri, "PredefinedFieldService", arg, this.timeoutSeconds);
        }

        public Task<ImportPredefinedFieldsResponse> ImportPredefinedFieldsAsync(
            ImportPredefinedFields arg)
        {
            return Client.PostAsync<ImportPredefinedFields, ImportPredefinedFieldsResponse>(this.username,
                this.password, this.baseuri, "PredefinedFieldService", arg, this.timeoutSeconds);
        }
    }
}