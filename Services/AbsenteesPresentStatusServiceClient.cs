//.AbsenteesPresentStatusServiceClient


using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
    public class AbsenteesPresentStatusServiceClient
    {
        private const string service = "AbsenteesPresentStatusService";
        private readonly string username;
        private readonly string password;
        private readonly string baseuri;
        private readonly int timeoutSeconds;

        public AbsenteesPresentStatusServiceClient(string username, string password, string baseuri,
            int timeoutSeconds = 60)
        {
            this.username = username;
            this.password = password;
            this.baseuri = baseuri;
            this.timeoutSeconds = timeoutSeconds;
        }

        public ExportAbsenteesPresentStatusResponse ExportAbsenteesPresentStatus(
            ExportAbsenteesPresentStatus arg)
        {
            return Client.Post<ExportAbsenteesPresentStatus, ExportAbsenteesPresentStatusResponse>(this.username,
                this.password, this.baseuri, "AbsenteesPresentStatusService", arg, this.timeoutSeconds);
        }

        public Task<ExportAbsenteesPresentStatusResponse> ExportAbsenteesPresentStatusAsync(
            ExportAbsenteesPresentStatus arg)
        {
            return Client.PostAsync<ExportAbsenteesPresentStatus, ExportAbsenteesPresentStatusResponse>(this.username,
                this.password, this.baseuri, "AbsenteesPresentStatusService", arg, this.timeoutSeconds);
        }

        public ExportAbsenteesPresentStatusListResponse ExportAbsenteesPresentStatusList(
            ExportAbsenteesPresentStatusList arg)
        {
            return Client.Post<ExportAbsenteesPresentStatusList, ExportAbsenteesPresentStatusListResponse>(
                this.username, this.password, this.baseuri, "AbsenteesPresentStatusService", arg, this.timeoutSeconds);
        }

        public Task<ExportAbsenteesPresentStatusListResponse> ExportAbsenteesPresentStatusListAsync(
            ExportAbsenteesPresentStatusList arg)
        {
            return Client.PostAsync<ExportAbsenteesPresentStatusList, ExportAbsenteesPresentStatusListResponse>(
                this.username, this.password, this.baseuri, "AbsenteesPresentStatusService", arg, this.timeoutSeconds);
        }
    }
}