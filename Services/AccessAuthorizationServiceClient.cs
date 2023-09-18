//.AccessAuthorizationServiceClient


using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
    public class AccessAuthorizationServiceClient
    {
        private const string service = "AccessAuthorizationService";
        private readonly string username;
        private readonly string password;
        private readonly string baseuri;
        private readonly int timeoutSeconds;

        public AccessAuthorizationServiceClient(string username, string password, string baseuri,
            int timeoutSeconds = 60)
        {
            this.username = username;
            this.password = password;
            this.baseuri = baseuri;
            this.timeoutSeconds = timeoutSeconds;
        }

        public ExportAccessAuthorizationListResponse ExportAccessAuthorizationList(
            ExportAccessAuthorizationList arg)
        {
            return Client.Post<ExportAccessAuthorizationList, ExportAccessAuthorizationListResponse>(this.username,
                this.password, this.baseuri, "AccessAuthorizationService", arg, this.timeoutSeconds);
        }

        public Task<ExportAccessAuthorizationListResponse> ExportAccessAuthorizationListAsync(
            ExportAccessAuthorizationList arg)
        {
            return Client.PostAsync<ExportAccessAuthorizationList, ExportAccessAuthorizationListResponse>(this.username,
                this.password, this.baseuri, "AccessAuthorizationService", arg, this.timeoutSeconds);
        }

        public ExportAccessAuthorizationResponse ExportAccessAuthorization(
            ExportAccessAuthorization arg)
        {
            return Client.Post<ExportAccessAuthorization, ExportAccessAuthorizationResponse>(this.username,
                this.password, this.baseuri, "AccessAuthorizationService", arg, this.timeoutSeconds);
        }

        public Task<ExportAccessAuthorizationResponse> ExportAccessAuthorizationAsync(
            ExportAccessAuthorization arg)
        {
            return Client.PostAsync<ExportAccessAuthorization, ExportAccessAuthorizationResponse>(this.username,
                this.password, this.baseuri, "AccessAuthorizationService", arg, this.timeoutSeconds);
        }

        public ImportAccessAuthorizationResponse ImportAccessAuthorization(
            ImportAccessAuthorization arg)
        {
            return Client.Post<ImportAccessAuthorization, ImportAccessAuthorizationResponse>(this.username,
                this.password, this.baseuri, "AccessAuthorizationService", arg, this.timeoutSeconds);
        }

        public Task<ImportAccessAuthorizationResponse> ImportAccessAuthorizationAsync(
            ImportAccessAuthorization arg)
        {
            return Client.PostAsync<ImportAccessAuthorization, ImportAccessAuthorizationResponse>(this.username,
                this.password, this.baseuri, "AccessAuthorizationService", arg, this.timeoutSeconds);
        }

        public DeleteAccessAuthorizationResponse DeleteAccessAuthorization(
            DeleteAccessAuthorization arg)
        {
            return Client.Post<DeleteAccessAuthorization, DeleteAccessAuthorizationResponse>(this.username,
                this.password, this.baseuri, "AccessAuthorizationService", arg, this.timeoutSeconds);
        }

        public Task<DeleteAccessAuthorizationResponse> DeleteAccessAuthorizationAsync(
            DeleteAccessAuthorization arg)
        {
            return Client.PostAsync<DeleteAccessAuthorization, DeleteAccessAuthorizationResponse>(this.username,
                this.password, this.baseuri, "AccessAuthorizationService", arg, this.timeoutSeconds);
        }
    }
}